namespace NP.Lti13Platform.Core.Interfaces;

/// <summary>
/// Represents a service token.
/// </summary>
public interface IServiceToken
{
    /// <summary>
    /// The unique identifier for the service token as defined by the LTI 1.3 specification.
    /// </summary>
    public string ServiceTokenId { get; }

    /// <summary>
    /// The unique identifier for the tool associated with this service token as defined by the LTI 1.3 specification.
    /// </summary>
    public string ToolId { get; }

    /// <summary>
    /// The space-delimited list of scopes as defined by the LTI 1.3 specification.
    /// </summary>
    public string Scopes { get; set; }

    /// <summary>
    /// The hash for the given scopes.
    /// </summary>
    public int ScopesHash { get; }

    /// <summary>
    /// The token used to refresh (if applicable) the service token as defined by the LTI 1.3 specification.
    /// </summary>
    public string RefreshToken { get; }

    /// <summary>
    /// "Bearer", etc. as defined by the LTI 1.3 specification.
    /// </summary>
    public string TokenType { get; }

    /// <summary>
    /// The expiration date and time of the service token as defined by the LTI 1.3 specification.
    /// </summary>
    public DateTimeOffset Expiration { get; set; }
}
