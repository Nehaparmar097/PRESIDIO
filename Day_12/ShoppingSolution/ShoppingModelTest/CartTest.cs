using ShoppingDALLibrary;
using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppinCustomerRepoTest
{
    public class CartTest
    {
        public class CartRepoTest
        {
            IRepository<int, Cart> repository;

            [SetUp]
            public void Setup()
            {
                repository = new CartRepository();
            }

            [Test]
            public void Delete_Success()
            {
                // Arrange
                Cart cartToDelete = new Cart { Id = 1 }; // Create a new cart
                repository.Add(cartToDelete); // Add the cart to the repository

                // Act
                Cart deletedCart = repository.Delete(cartToDelete.Id);

                // Assert
                Assert.IsNotNull(deletedCart); // Ensure that a cart is returned
                Assert.AreEqual(cartToDelete.Id, deletedCart.Id); // Ensure that the correct cart is deleted
            }

            [Test]
            public void Delete_NotFound_ReturnsNull()
            {
                // Act
                Cart deletedCart = repository.Delete(999); // Attempt to delete a cart that doesn't exist

                // Assert
                Assert.IsNull(deletedCart); // Ensure that null is returned
            }

            [Test]
            public void GetByKey_Success()
            {
                // Arrange
                Cart cartToAdd = new Cart { Id = 1 }; // Create a new cart
                repository.Add(cartToAdd); // Add the cart to the repository

                // Act
                Cart retrievedCart = repository.GetByKey(cartToAdd.Id);

                // Assert
                Assert.IsNotNull(retrievedCart); // Ensure that a cart is retrieved
                Assert.AreEqual(cartToAdd.Id, retrievedCart.Id); // Ensure that the correct cart is retrieved
            }

            [Test]
            public void GetByKey_NotFound_ReturnsNull()
            {
                // Act
                Cart retrievedCart = repository.GetByKey(999); 
                // Assert
                Assert.IsNull(retrievedCart); 
            }

            [Test]
            public void Update_Success()
            {
                // Arrange
                Cart originalCart = new Cart { Id = 1 }; 
                repository.Add(originalCart);

                Cart updatedCart = new Cart { Id = 1 }; 
                // Act
                Cart result = repository.Update(updatedCart);

                // Assert
                Assert.IsNotNull(result); // Ensure that a cart is returned
                Assert.AreEqual(updatedCart.Id, result.Id); // Ensure that the correct cart is updated
            }

            [Test]
            public void Update_NotFound_ReturnsNull()
            {
                // Arrange
                Cart updatedCart = new Cart { Id = 999 }; // Create an updated version of a cart that doesn't exist

                // Act
                Cart result = repository.Update(updatedCart);

                // Assert
                Assert.IsNull(result); 
            }
        }
    }
}
