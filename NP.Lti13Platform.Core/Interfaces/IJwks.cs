using Microsoft.IdentityModel.Tokens;

namespace NP.Lti13Platform.Core.Interfaces;


/// <summary>
/// Create an instance of Jwks using the provided key or uri.
/// </summary>
/// <returns>An instance of Jwks depending on the type of string provided.</returns>
public interface IJwks
{
    /// <summary>
    /// Gets the security keys asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A collection of security keys.</returns>
    public Task<IEnumerable<SecurityKey>> GetKeysAsync(CancellationToken cancellationToken = default);

}

///// <summary>
///// Represents a JWKS with a public key.
///// </summary>
//public interface IJwtPublicKey : IJwks
//{
//    /// <summary>
//    /// Gets or sets the public key.
//    /// </summary>
//    public string PublicKey { get; set; }
//}


///// <summary>
///// Represents a JWKS with a URI.
///// </summary>
//public interface IJwksUri : IJwks
//{
//    /// <summary>
//    /// Gets or sets the URI of the JWKS.
//    /// </summary>
//    public string Uri { get; set; }
//}
