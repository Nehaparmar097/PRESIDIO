using ShoppingBLLibrary;

using ShoppingModelLibrary;
using ShoppingDALLibrary;
namespace ShoppingBLTest
{

    private Mock<IRepository<int, Cart>> cartRepoMock;
    private Mock<IRepository<int, Product>> productRepoMock;
    private IShopping shoppingBL;

    [SetUp]
    public void Setup()
    {
        // Create mock repositories
        cartRepoMock = new Mock<IRepository<int, Cart>>();
        productRepoMock = new Mock<IRepository<int, Product>>();

        // Create an instance of the shopping business logic class using the mock repositories
        shoppingBL = new ShoppingBL(cartRepoMock.Object, productRepoMock.Object);
    }

    [Test]
    public void AddProductToCart_QuantityWithinLimit_ProductAddedToCart()
    {
        // Arrange
        int cartId = 1;
        int productId = 1;
        int quantity = 3;

        var cart = new Cart { Id = cartId, CartItems = new List<CartItem>() };
        var product = new Product { Id = productId, Price = 10.00, QuantityInHand = 10 };

        cartRepoMock.Setup(repo => repo.GetById(cartId)).Returns(cart);
        productRepoMock.Setup(repo => repo.GetById(productId)).Returns(product);

        // Act
        shoppingBL.AddProductToCart(cartId, productId, quantity);

        // Assert
        Assert.AreEqual(1, cart.CartItems.Count);
        Assert.AreEqual(productId, cart.CartItems[0].ProductId);
        Assert.AreEqual(quantity, cart.CartItems[0].Quantity);
    }

    [Test]
    public void AddProductToCart_QuantityExceedsLimit_ArgumentExceptionThrown()
    {
        // Arrange
        int cartId = 1;
        int productId = 1;
        int quantity = 6;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => shoppingBL.AddProductToCart(cartId, productId, quantity));
    }

    [Test]
    public void AddProductToCart_CartNotFound_NoCartItemAdded()
    {
        // Arrange
        int cartId = 1;
        int productId = 1;
        int quantity = 3;

        // Act
        shoppingBL.AddProductToCart(cartId, productId, quantity);

        // Assert
        // Verify that no interactions occur with the product repository
        productRepoMock.Verify(repo => repo.GetById(It.IsAny<int>()), Times.Never);
    }

    [Test]
    public void AddProductToCart_ProductNotFound_NoCartItemAdded()
    {
        // Arrange
        int cartId = 1;
        int productId = 1;
        int quantity = 3;

        var cart = new Cart { Id = cartId, CartItems = new List<CartItem>() };
        cartRepoMock.Setup(repo => repo.GetById(cartId)).Returns(cart);

        // Act
        shoppingBL.AddProductToCart(cartId, productId, quantity);

        // Assert
        // Verify that no interactions occur with the cart repository
        cartRepoMock.Verify(repo => repo.GetById(It.IsAny<int>()), Times.Never);
    }
}
