using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket.Model;

namespace Supermarket.UnitTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange

            var product = new Product(1)
            {
                Name = "Pako Biscuit",
                CurrentPrice = 15M
            };

            var expected = true;

            // Act

            var actual = product.Validate();

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateProductNameMissing()
        {
            // Arrange

            var product = new Product(1)
            {
                CurrentPrice = 15M,
            };

            var expected = false;

            // Act

            var actual = product.Validate();

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateCurrentPriceMissing()
        {
            // Arrange

            var product = new Product(1)
            {
                Name = "Pako"
            };

            var expected = false;

            // Act

            var actual = product.Validate();

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
