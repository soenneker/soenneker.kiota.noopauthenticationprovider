using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace Soenneker.Kiota.NoOpAuthenticationProvider;

/// <summary>
/// A Kiota AuthenticationProvider implementation that performs no authentication. Useful for scenarios where no Authorization header is required.
/// </summary>
public sealed class NoOpAuthenticationProvider : IAuthenticationProvider
{
    public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}