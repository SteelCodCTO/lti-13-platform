namespace NP.Lti13Platform.Core.Interfaces;

/// <summary>
/// Represents a membership in a context.
/// </summary>
public interface IMembership
{
    /// <summary>
    /// The unique identifier of the context in which the membership exists, as defined by the LTI 1.3 specification.
    /// </summary>
    public string ContextId { get; }

    /// <summary>
    /// The unique identifier of the user who is a member of the context, as defined by the LTI 1.3 specification.
    /// </summary>
    public string UserId { get; }

    /// <summary>
    /// The status of the membership (active or inactive) as defined by the LTI 1.3 specification.
    /// </summary>
    public MembershipStatus Status { get; }

    /// <summary>
    /// The roles assigned to the member in the context, as defined by the LTI 1.3 specification.
    /// </summary>
    public IEnumerable<string> Roles { get; }

    /// <summary>
    /// The IDs of the users mentored by this user, as defined by the LTI 1.3 specification.
    /// </summary>
    public IEnumerable<string> MentoredUserIds { get; }
}

/// <summary>
/// Represents the status of a membership.
/// </summary>
public enum MembershipStatus
{
    /// <summary>
    /// The membership is active as defined by the LTI 1.3 specification.
    /// </summary>
    Active,
    /// <summary>
    /// The membership is inactive as defined by the LTI 1.3 specification.
    /// </summary>
    Inactive
}
