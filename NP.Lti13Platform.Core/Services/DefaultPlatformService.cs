using Microsoft.Extensions.Options;
using NP.Lti13Platform.Core.Configs;
using NP.Lti13Platform.Core.Interfaces;

namespace NP.Lti13Platform.Core.Services;

internal class DefaultPlatformService(IOptionsMonitor<Lti13PlatformConfig> config) : ILti13PlatformService
{
    public async Task<Lti13PlatformConfig?> GetPlatformAsync(string clientId, CancellationToken cancellationToken = default) => await Task.FromResult(config.CurrentValue.Guid != Guid.Empty ? config.CurrentValue : null);
}
