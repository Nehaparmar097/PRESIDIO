using PizzaShopAPIJWT.model.DTOs;
using PizzaShopAPIJWT.model;

namespace PizzaShopAPIJWT.interfaces
{
    public interface IUserService
    {
        public Task<LoginReturnDTO> Login(UserLoginDTO loginDTO);
        public Task<Customer> Register(CustomerUserDTO customerDTO);
    }
}
