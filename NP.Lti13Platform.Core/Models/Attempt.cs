using NP.Lti13Platform.Core.Interfaces;

namespace NP.Lti13Platform.Core.Models;

/// <summary>
/// Represents an attempt on a resource link.
/// </summary>
public class Attempt: IAttempt
{
    ///// <summary>
    ///// The unique identifier of the deployment
    ///// </summary>
    //public required string DeploymentId { get; set; }

    /// <summary>
    /// The unique identifier of the line item for which this attempt is made.
    /// </summary>
    public required string LineItemId { get; set; }

    /// <summary>
    /// The unique identifier of the user making the attempt.
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// Which number attempt this is for the user. 1 = first
    /// </summary>
    public int AttemptNumber { get; set; } = 0; // tool-side concept; not part of the spec

    /// <summary>
    /// Date and time when the attempt becomes available.
    /// </summary>
    public DateTimeOffset? AvailableStartDateTime { get; set; }

    /// <summary>
    /// Date and time when the attempt is no longer available.
    /// </summary>
    public DateTimeOffset? AvailableEndDateTime { get; set; }

    /// <summary>
    /// Date and time when the user can start submitting for this attempt.
    /// </summary>
    public DateTimeOffset? SubmisstionStartDateTime { get; set; }

    /// <summary>
    /// Date and time when the user can no longer submit for this attempt.
    /// </summary>
    public DateTimeOffset? SubmissionEndDateTime { get; set; }
}
