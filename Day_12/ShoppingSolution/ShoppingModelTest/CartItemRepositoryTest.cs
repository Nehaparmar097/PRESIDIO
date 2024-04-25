using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingDALLibrary;
namespace ShoppinCustomerRepoTest
{
    public class CartItemRepositoryTest
    {
        private CartItemRepository repository;

        [SetUp]
        public void Setup()
        {
            repository = new CartItemRepository();
        }

        [Test]
        public void Delete_CartItemExists_ReturnsCartItem()
        {
            // Arrange
            int cartItemId = 1;
            var cartItemToDelete = new CartItem { CartId = cartItemId };
            repository.Add(cartItemToDelete);

            // Act
            var deletedCartItem = repository.Delete(cartItemId);

            // Assert
            Assert.IsNotNull(deletedCartItem);
            Assert.AreEqual(cartItemId, deletedCartItem.CartId);
        }

        [Test]
        public void Delete_CartItemDoesNotExist_ReturnsNull()
        {
            // Act
            var deletedCartItem = repository.Delete(999);

            // Assert
            Assert.IsNull(deletedCartItem);
        }

        [Test]
        public void GetByKey_CartItemExists_ReturnsCartItem()
        {
            // Arrange
            int cartItemId = 1;
            var expectedCartItem = new CartItem { CartId = cartItemId };
            repository.Add(expectedCartItem);

            // Act
            var retrievedCartItem = repository.GetByKey(cartItemId);

            // Assert
            Assert.IsNotNull(retrievedCartItem);
            Assert.AreEqual(cartItemId, retrievedCartItem.CartId);
        }

        [Test]
        public void GetByKey_CartItemDoesNotExist_ReturnsNull()
        {
            // Act
            var retrievedCartItem = repository.GetByKey(999);

            // Assert
            Assert.IsNull(retrievedCartItem);
        }

        [Test]
        public void Update_CartItemExists_ReturnsUpdatedCartItem()
        {
            // Arrange
            int cartItemId = 1;
            var originalCartItem = new CartItem { CartId = cartItemId };
            repository.Add(originalCartItem);

            var updatedCartItem = new CartItem { CartId = cartItemId, Quantity = 10, Price = 20.99 };

            // Act
            var result = repository.Update(updatedCartItem);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(updatedCartItem.CartId, result.CartId);
            Assert.AreEqual(updatedCartItem.Quantity, result.Quantity);
            Assert.AreEqual(updatedCartItem.Price, result.Price);
        }
    }

}

