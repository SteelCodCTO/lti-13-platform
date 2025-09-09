namespace NP.Lti13Platform.Core.Interfaces;

/// <summary>
/// Represents an attempt on a resource link.
/// </summary>
public interface IAttempt
{
    /// <summary>
    /// The unique identifier of the deployment
    /// </summary>
    public string DeploymentId { get; }

    /// <summary>
    /// The unique identifier of the line item for which this attempt is made.
    /// </summary>
    public string LineItemId { get; }

    ///// <summary>
    ///// The unique identifier of the resource link for which this attempt is made.
    ///// </summary>
    //public string ResourceLinkId { get; set; }

    /// <summary>
    /// The unique identifier of the user making the attempt.
    /// </summary>
    public string UserId { get; }

    /// <summary>
    /// Date and time when the attempt becomes available.
    /// </summary>
    public DateTimeOffset? AvailableStartDateTime { get; }

    /// <summary>
    /// Date and time when the attempt is no longer available.
    /// </summary>
    public DateTimeOffset? AvailableEndDateTime { get; }

    /// <summary>
    /// Date and time when the user can start submitting for this attempt.
    /// </summary>
    public DateTimeOffset? SubmisstionStartDateTime { get; }

    /// <summary>
    /// Date and time when the user can no longer submit for this attempt.
    /// </summary>
    public DateTimeOffset? SubmissionEndDateTime { get; }
}
