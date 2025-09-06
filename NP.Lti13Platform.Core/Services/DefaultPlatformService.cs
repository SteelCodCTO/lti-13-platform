using Microsoft.Extensions.Options;
using NP.Lti13Platform.Core.Interfaces;
using NP.Lti13Platform.Core.Models;

namespace NP.Lti13Platform.Core.Services;

internal class DefaultPlatformService(IOptionsMonitor<IPlatform> config) : ILti13PlatformService
{
    public async Task<IPlatform?> GetPlatformAsync(string clientId, CancellationToken cancellationToken = default) => await Task.FromResult(!string.IsNullOrWhiteSpace(config.CurrentValue.Guid) ? config.CurrentValue : null);
}
