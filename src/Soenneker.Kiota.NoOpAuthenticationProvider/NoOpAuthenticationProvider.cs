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
    /// <summary>
    /// Authenticates request Async for the no op authentication provider.
    /// </summary>
    /// <param name="request">request that defines the request to send.</param>
    /// <param name="additionalAuthenticationContext">additional Authentication Context to process.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task that completes when the authenticate request async operation is complete.</returns>
    public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
