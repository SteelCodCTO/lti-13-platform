using NP.Lti13Platform.Core.Interfaces;

namespace NP.Lti13Platform.Core.Models;

/// <summary>
/// Represents a membership in a context.
/// </summary>
public class Membership: IMembership
{
    /// <summary>
    /// The unique identifier of the context in which the membership exists, as defined by the LTI 1.3 specification.
    /// </summary>
    public required string ContextId { get; set; }

    /// <summary>
    /// The unique identifier of the user who is a member of the context, as defined by the LTI 1.3 specification.
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// The status of the membership (active or inactive) as defined by the LTI 1.3 specification.
    /// </summary>
    public required MembershipStatus Status { get; set; }

    /// <summary>
    /// The roles assigned to the member in the context, as defined by the LTI 1.3 specification.
    /// </summary>
    public required IEnumerable<string> Roles { get; set; }

    /// <summary>
    /// The IDs of the users mentored by this user, as defined by the LTI 1.3 specification.
    /// </summary>
    public required IEnumerable<string> MentoredUserIds { get; set; }
}

