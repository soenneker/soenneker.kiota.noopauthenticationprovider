using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Kiota.NoOpAuthenticationProvider.Tests;

[Collection("Collection")]
public class NoOpAuthenticationProviderTests : FixturedUnitTest
{
    public NoOpAuthenticationProviderTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
