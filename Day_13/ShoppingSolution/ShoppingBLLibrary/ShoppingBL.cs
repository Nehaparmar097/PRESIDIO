using ShoppingModelLibrary;
namespace ShoppingBLLibrary
{
    public class ShoppingBL : IShopping
    {
        private readonly List<Cart> carts;
        private readonly List<Product> products;

        public ShoppingBL(List<Cart> carts, List<Product> products)
        {
            this.carts = carts;
            this.products = products;
        }

        public void AddProductToCart(int cartId, int productId, int quantity)
        {
            if (quantity > 5)
                throw new ArgumentException("Cant add more than 5 of a single product.");

            var cart = carts.FirstOrDefault(c => c.Id == cartId);
            if (cart == null) return;

            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product == null) return;

            var cartItem = new CartItem
            {
                CartId = cartId,
                ProductId = productId,
                Product = product,
                Quantity = quantity,
                Price = product.Price,
                Discount = 0,
                PriceExpiryDate = DateTime.Now.AddDays(30) 
            };

            cart.CartItems.Add(cartItem);
        }

        public double CalculateTotal(int cartId)
        {
            var cart = carts.FirstOrDefault(c => c.Id == cartId);
            if (cart == null) return 0;

            double total = cart.CartItems.Sum(item => item.Price * item.Quantity);
            if (total < 100)
                total += 100; 
            return total;
        }

        public void ApplyDiscounts(int cartId)
        {
            var cart = carts.FirstOrDefault(c => c.Id == cartId);
            if (cart == null) return;

            
            if (cart.CartItems.Count == 3 && cart.CartItems.Sum(i => i.Price * i.Quantity) >= 1500)
            {
                foreach (var item in cart.CartItems)
                {
                    item.Discount = 5; 
                    item.Price *= 0.95; 
                }
            }
        }
    }
}
