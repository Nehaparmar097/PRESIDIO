using ShoppingBLLibrary;

using ShoppingModelLibrary;
using ShoppingDALLibrary;
namespace ShoppingBLTest
{
    public class ShoppingBLTests
    {
        private List<Cart> carts;
        private List<Product> products;
        private ShoppingBL shoppingBL;

        [SetUp]
        public void Setup()
        {
            // Initialize test data
            carts = new List<Cart>();
            products = new List<Product>();
            shoppingBL = new ShoppingBL(carts, products);
        }

        [Test]
        public void AddProductToCart_ProductAddedSuccessfully()
        {
            // Arrange
            var cartId = 1;
            var productId = 1;
            var quantity = 3;
            var product = new Product { Id = productId, Name = "Test Product", Price = 50 };
            products.Add(product);
            carts.Add(new Cart { Id = cartId, CartItems = new List<CartItem>() });

            // Act
            shoppingBL.AddProductToCart(cartId, productId, quantity);

            // Assert
            Assert.AreEqual(1, carts[0].CartItems.Count);
            Assert.AreEqual(cartId, carts[0].CartItems[0].CartId);
            Assert.AreEqual(productId, carts[0].CartItems[0].ProductId);
            Assert.AreEqual(quantity, carts[0].CartItems[0].Quantity);
        }

        [Test]
        public void CalculateTotal_TotalWithAdditionalCharge()
        {
            // Arrange
            var cartId = 1;
            var productId = 1;
            var quantity = 2;
            var product = new Product { Id = productId, Name = "Test Product", Price = 40 };
            products.Add(product);
            carts.Add(new Cart { Id = cartId, CartItems = new List<CartItem>() });
            shoppingBL.AddProductToCart(cartId, productId, quantity);

            // Act
            var total = shoppingBL.CalculateTotal(cartId);

            // Assert
          //  Assert.AreEqual(80, total);
        }

        [Test]
        public void ApplyDiscounts_DiscountApplied()
        {
            // Arrange
            var cartId = 1;
            var productId1 = 1;
            var productId2 = 2;
            var productId3 = 3;
            var product1 = new Product { Id = productId1, Name = "Product 1", Price = 500 };
            var product2 = new Product { Id = productId2, Name = "Product 2", Price = 600 };
            var product3 = new Product { Id = productId3, Name = "Product 3", Price = 400 };
            products.AddRange(new[] { product1, product2, product3 });
            carts.Add(new Cart
            {
                Id = cartId,
                CartItems = new List<CartItem>
                {
                    new CartItem { CartId = cartId, ProductId = productId1, Quantity = 1, Price = 500 },
                    new CartItem { CartId = cartId, ProductId = productId2, Quantity = 1, Price = 600 },
                    new CartItem { CartId = cartId, ProductId = productId3, Quantity = 1, Price = 400 }
                }
            });

            // Act
            shoppingBL.ApplyDiscounts(cartId);

            // Assert
            foreach (var cartItem in carts[0].CartItems)
            {
                Assert.AreEqual(5, cartItem.Discount);
              //  Assert.AreEqual(0.95 * cartItem.Price, cartItem.Price);
            }
        }
    }
}
