namespace NP.Lti13Platform.Core.Interfaces;

/// <summary>
/// Represents a service token.
/// </summary>
public interface IServiceToken
{
    /// <summary>
    /// The unique identifier for the service token as defined by the LTI 1.3 specification.
    /// </summary>
    public string ServiceTokenId { get; set; }

    /// <summary>
    /// The unique identifier for the tool associated with this service token as defined by the LTI 1.3 specification.
    /// </summary>
    public string ToolId { get; set; }

    /// <summary>
    /// The expiration date and time of the service token as defined by the LTI 1.3 specification.
    /// </summary>
    public DateTime Expiration { get; set; }
}
