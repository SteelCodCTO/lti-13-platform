using NP.Lti13Platform.Core.Constants;
using NP.Lti13Platform.Core.Extensions;
using NP.Lti13Platform.Core.Interfaces;
using NP.Lti13Platform.Core.Models;
using NP.Lti13Platform.Core.Populators;
using NP.Lti13Platform.Core.Services;
using System.Text.Json.Serialization;

namespace NP.Lti13Platform.NameRoleProvisioningServices.Populators;

/// <summary>
/// Defines an interface for a message containing custom parameters.
/// </summary>
public interface ICustomMessage
{
    /// <summary>
    /// Gets or sets the dictionary of custom parameters.
    /// </summary>
    [JsonPropertyName("https://purl.imsglobal.org/spec/lti/claim/custom")]
    public IDictionary<string, string>? Custom { get; set; }
}

/// <summary>
/// Populates custom parameters for LTI messages.
/// </summary>
public class CustomPopulator(ILti13CoreDataService dataService) : Populator<ICustomMessage>
{
    /// <summary>
    /// List of resource link variables related to line items, attempts, and grades.
    /// </summary>
    private static readonly IEnumerable<string> LineItemAttemptGradeVariables = [
        Lti13ResourceLinkVariables.AvailableUserStartDateTime,
        Lti13ResourceLinkVariables.AvailableUserEndDateTime,
        Lti13ResourceLinkVariables.SubmissionUserStartDateTime,
        Lti13ResourceLinkVariables.SubmissionUserEndDateTime,
        Lti13ResourceLinkVariables.LineItemUserReleaseDateTime];

    /// <summary>
    /// Populates custom parameters based on the message scope.
    /// </summary>
    /// <param name="obj">The object to populate.</param>
    /// <param name="scope">The message scope.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public override async Task PopulateAsync(ICustomMessage obj, MessageScope scope, CancellationToken cancellationToken = default)
    {
        var customDictionary = scope.Tool.Custom.Merge(scope.Deployment.Custom).Merge(scope.ResourceLink?.Custom);

        if (customDictionary == null)
        {
            return;
        }

        IEnumerable<string> mentoredUserIds = [];
        if (customDictionary.Values.Any(v => v == Lti13UserVariables.ScopeMentor) && scope.Context != null )
        {
            var membership = await dataService.GetMembershipAsync(scope.Context.ContextId, scope.UserScope.User.UserId, cancellationToken);
            if (membership != null && membership.Roles.Contains(Lti13ContextRoles.Mentor))
            {
                mentoredUserIds = membership.MentoredUserIds;
            }
        }

        ILineItem? lineItem = null;
        IAttempt? latestAttempt = null;
        IGrade? grade = null;
        if (customDictionary.Values.Any(v => LineItemAttemptGradeVariables.Contains(v)) && scope.Context != null && scope.ResourceLink != null)
        {
            var lineItems = await dataService.GetLineItemsAsync(scope.Context.ContextId, pageIndex: 0, limit: 1, resourceLinkId: scope.ResourceLink.ResourceLinkId, cancellationToken: cancellationToken);
            if (lineItems.TotalItems == 1)
            {
                lineItem = lineItems.Items.First();

                grade = await dataService.GetGradeAsync(lineItem.LineItemId, scope.UserScope.User.UserId, cancellationToken);
                latestAttempt = await dataService.GetLatestAttemptAsync(lineItem.LineItemId, scope.UserScope.User.UserId, cancellationToken);
            }

        }

        var customPermissions = await dataService.GetCustomPermissions(scope.Deployment.DeploymentId, scope.Context?.ContextId, scope.UserScope.User.UserId, scope.UserScope.ActualUser?.UserId, cancellationToken);

        var dictionaryValues = customDictionary.ToList();
        foreach (var kvp in dictionaryValues)
        {
            var value = kvp.Value switch
            {
                Lti13UserVariables.Id when customPermissions.UserId => scope.UserScope.User.UserId,
                Lti13UserVariables.Image when customPermissions.UserImage => scope.UserScope.User.Picture?.ToString(),
                Lti13UserVariables.Username when customPermissions.UserUsername => scope.UserScope.User.Username,
                Lti13UserVariables.Org when customPermissions.UserOrg => string.Join(',', scope.UserScope.User.Orgs),
                Lti13UserVariables.ScopeMentor when customPermissions.UserScopeMentor => string.Join(',', mentoredUserIds),
                Lti13UserVariables.GradeLevelsOneRoster when customPermissions.UserGradeLevelsOneRoster => string.Join(',', scope.UserScope.User.OneRosterGrades),

                Lti13ResourceLinkVariables.AvailableUserStartDateTime when customPermissions.ResourceLinkAvailableUserStartDateTime => latestAttempt?.AvailableStartDateTime?.ToString("O"),
                Lti13ResourceLinkVariables.AvailableUserEndDateTime when customPermissions.ResourceLinkAvailableUserEndDateTime => latestAttempt?.AvailableEndDateTime?.ToString("O"),
                Lti13ResourceLinkVariables.SubmissionUserStartDateTime when customPermissions.ResourceLinkSubmissionUserStartDateTime => latestAttempt?.SubmisstionStartDateTime?.ToString("O"),
                Lti13ResourceLinkVariables.SubmissionUserEndDateTime when customPermissions.ResourceLinkSubmissionUserEndDateTime => latestAttempt?.SubmissionEndDateTime?.ToString("O"),
                Lti13ResourceLinkVariables.LineItemUserReleaseDateTime when customPermissions.ResourceLinkLineItemUserReleaseDateTime => grade?.ReleaseDateTime?.ToString("O"),
                _ => null
            };

            if (value == null)
            {
                customDictionary.Remove(kvp.Key);
            }
            else
            {
                customDictionary[kvp.Key] = value;
            }
        }

        obj.Custom = obj.Custom.Merge(customDictionary);
    }
}
