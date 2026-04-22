using Soenneker.Tests.HostedUnit;

namespace Soenneker.Kiota.NoOpAuthenticationProvider.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class NoOpAuthenticationProviderTests : HostedUnitTest
{
    public NoOpAuthenticationProviderTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
