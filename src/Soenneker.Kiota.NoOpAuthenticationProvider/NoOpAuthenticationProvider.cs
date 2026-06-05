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
    /// Executes the authenticate request async operation.
    /// </summary>
    /// <param name="request">The request.</param>
    /// <param name="additionalAuthenticationContext">The additional authentication context.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}