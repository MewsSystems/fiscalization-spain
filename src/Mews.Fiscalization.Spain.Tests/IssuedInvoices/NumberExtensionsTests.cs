using Mews.Fiscalization.Spain.Converters;
using Xunit;

namespace Mews.Fiscalization.Spain.Tests.IssuedInvoices
{
    public class NumberExtensionsTests
    {
        [Fact]
        public void DecimalSerialization()
        {
            Assert.Equal("67.50", 67.5m.Serialize());
            Assert.Equal("67.00", 67m.Serialize());
            Assert.Equal("67.50", 67.5000000000m.Serialize());
        }
    }
}
