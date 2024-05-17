using PizzaShopAPIJWT.model;
namespace PizzaShopAPIJWT.interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(Customer customer);

    }
}
