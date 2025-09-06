using NP.Lti13Platform.Core.Interfaces;
using NP.Lti13Platform.Core.Models;

namespace NP.Lti13Platform.Core.Populators
{
    /// <summary>
    /// Represents the scope of an LTI message, including user, tool, deployment, context, and resource link information.
    /// </summary>
    /// <typeparam name="TAddress">The address type for the user.</typeparam>
    /// <typeparam name="TJwks">The JWKS type for the tool.</typeparam>
    /// <param name="UserScope">The user scope.</param>
    /// <param name="Tool">The tool.</param>
    /// <param name="Deployment">The deployment.</param>
    /// <param name="Context">The context.</param>
    /// <param name="ResourceLink">The resource link.</param>
    /// <param name="MessageHint">The message hint.</param>
    public record MessageScope<TAddress, TJwks>(
        UserScope<TAddress> UserScope,
        ITool<TJwks> Tool,
        IDeployment Deployment,
        IContext? Context,
        IResourceLink? ResourceLink,
        string? MessageHint
    ) where TAddress : IAddress where TJwks : IJwks;

    /// <summary>
    /// Represents the user scope within an LTI message, including the user, the actual user (if impersonated), and whether the user is anonymous.
    /// </summary>
    /// <typeparam name="TAddress">The address type for the user.</typeparam>
    /// <param name="User">The user.</param>
    /// <param name="ActualUser">The actual user.</param>
    /// <param name="IsAnonymous">A value indicating whether the user is anonymous.</param>
    public record UserScope<TAddress>(IUser<TAddress> User, IUser<TAddress>? ActualUser, bool IsAnonymous) where TAddress : IAddress;
}
