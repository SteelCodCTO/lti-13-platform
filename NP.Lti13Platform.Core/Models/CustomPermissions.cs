using NP.Lti13Platform.Core.Interfaces;

namespace NP.Lti13Platform.Core.Models;

/// <summary>
/// Represents custom permissions for LTI claims.
/// </summary>
public class CustomPermissions: ICustomPermissions
{
    /// <summary>
    /// Indicates whether the user ID is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool UserId { get; set; } = false;
    /// <summary>
    /// Indicates whether the user image is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool UserImage { get; set; } = false;
    /// <summary>
    /// Indicates whether the user username is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool UserUsername { get; set; } = false;
    /// <summary>
    /// Indicates whether the user organization is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool UserOrg { get; set; } = false;
    /// <summary>
    /// Indicates whether the user scope mentor is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool UserScopeMentor { get; set; } = false;
    /// <summary>
    /// Indicates whether the user grade levels (OneRoster) is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool UserGradeLevelsOneRoster { get; set; } = false;

    /// <summary>
    /// Indicates whether the actual user ID is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ActualUserId { get; set; } = false;
    /// <summary>
    /// Indicates whether the actual user image is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ActualUserImage { get; set; } = false;
    /// <summary>
    /// Indicates whether the actual user username is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ActualUserUsername { get; set; } = false;
    /// <summary>
    /// Indicates whether the actual user organization is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ActualUserOrg { get; set; } = false;
    /// <summary>
    /// Indicates whether the actual user scope mentor is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ActualUserScopeMentor { get; set; } = false;
    /// <summary>
    /// Indicates whether the actual user grade levels (OneRoster) is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ActualUserGradeLevelsOneRoster { get; set; } = false;

    /// <summary>
    /// Indicates whether the context ID is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextId { get; set; } = false;
    /// <summary>
    /// Indicates whether the context organization is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextOrg { get; set; } = false;
    /// <summary>
    /// Indicates whether the context type is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextType { get; set; } = false;
    /// <summary>
    /// Indicates whether the context label is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextLabel { get; set; } = false;
    /// <summary>
    /// Indicates whether the context title is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextTitle { get; set; } = false;
    /// <summary>
    /// Indicates whether the context sourced ID is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextSourcedId { get; set; } = false;
    /// <summary>
    /// Indicates whether the context ID history is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextIdHistory { get; set; } = false;
    /// <summary>
    /// Indicates whether the context grade levels (OneRoster) is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ContextGradeLevelsOneRoster { get; set; } = false;

    /// <summary>
    /// Indicates whether the resource link ID is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkId { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link title is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkTitle { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link description is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkDescription { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link available start date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkAvailableStartDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link available user start date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkAvailableUserStartDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link available end date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkAvailableEndDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link available user end date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkAvailableUserEndDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link submission start date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkSubmissionStartDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link submission user start date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkSubmissionUserStartDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link submission end date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkSubmissionEndDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link submission user end date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkSubmissionUserEndDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link line item release date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkLineItemReleaseDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link line item user release date and time is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkLineItemUserReleaseDateTime { get; set; } = false;
    /// <summary>
    /// Indicates whether the resource link ID history is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ResourceLinkIdHistory { get; set; } = false;

    /// <summary>
    /// Indicates whether the tool platform product family code is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ToolPlatformProductFamilyCode { get; set; } = false;
    /// <summary>
    /// Indicates whether the tool platform product version is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ToolPlatformProductVersion { get; set; } = false;
    /// <summary>
    /// Indicates whether the tool platform product instance GUID is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ToolPlatformProductInstanceGuid { get; set; } = false;
    /// <summary>
    /// Indicates whether the tool platform product instance name is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ToolPlatformProductInstanceName { get; set; } = false;
    /// <summary>
    /// Indicates whether the tool platform product instance description is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ToolPlatformProductInstanceDescription { get; set; } = false;
    /// <summary>
    /// Indicates whether the tool platform product instance URL is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ToolPlatformProductInstanceUrl { get; set; } = false;
    /// <summary>
    /// Indicates whether the tool platform product instance contact email is accessible as defined by the LTI 1.3 specification.
    /// </summary>
    public bool ToolPlatformProductInstanceContactEmail { get; set; } = false;
}
