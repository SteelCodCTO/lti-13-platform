using Microsoft.Extensions.Options;
using NP.Lti13Platform.Core.Interfaces;
using NP.Lti13Platform.Core.Models;

namespace NP.Lti13Platform.Core.Services;

internal class DefaultPlatformService(IOptionsMonitor<Platform> config) : ILti13PlatformService
{
    public async Task<Platform?> GetPlatformAsync(string clientId, CancellationToken cancellationToken = default) => await Task.FromResult(config.CurrentValue.Guid != Guid.Empty ? config.CurrentValue : null);
}
