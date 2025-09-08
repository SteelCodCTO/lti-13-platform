using NP.Lti13Platform.Core.Interfaces;

namespace NP.Lti13Platform.Core.Models;

/// <summary>
/// Represents a service token.
/// </summary>
public class ServiceToken: IServiceToken
{
    /// <summary>
    /// The unique identifier for the service token as defined by the LTI 1.3 specification.
    /// </summary>
    public required string ServiceTokenId { get; set; }

    /// <summary>
    /// The unique identifier for the tool associated with this service token as defined by the LTI 1.3 specification.
    /// </summary>
    public required string ToolId { get; set; }

    /// <summary>
    /// The expiration date and time of the service token as defined by the LTI 1.3 specification.
    /// </summary>
    public required DateTimeOffset Expiration { get; set; }


    /// <summary>
    /// Creates a strongly-typed clone of the given IGrade instance.
    /// </summary>
    public static ServiceToken Clone(IServiceToken li)
    {
        return new ServiceToken
        {
            ServiceTokenId = li.ServiceTokenId,
            ToolId = li.ToolId,
            Expiration = li.Expiration
        };
    }

}
