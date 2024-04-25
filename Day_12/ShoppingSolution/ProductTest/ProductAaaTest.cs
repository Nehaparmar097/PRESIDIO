using ShoppingDALLibrary;
using ShoppingModelLibrary;
namespace ProductTest
{
    public class Tests
    {
        IRepository<int, Customer> repository;

        [SetUp]

        public void Setup()

        {

            repository = new CustomerRepository();

        }

        [Test]

        public void AddSuccessTest()

        {

            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };

            var result = repository.Add(customer);

            //Assert

            Assert.IsNotNull(result);

        }

        [Test]

        public void AddFailTest()

        {

            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };

            repository.Add(customer);

            Customer customer1 = new Customer() { Id = 1, Age = 22, Phone = "345654" };

            var exception = Assert.Throws<ItemPresentException>(() => repository.Add(customer1));

            //Assert

            Assert.AreEqual("Item already present", exception.Message);

        }

        [Test]

        public void GetAllSuccessTest()

        {

            Customer customer = new Customer() { Id = 1, Age = 22, Phone = "345654" };

            repository.Add(customer);

            Customer customer1 = new Customer() { Id = 2, Age = 23, Phone = "76542" };

            repository.Add(customer1);

            List<Customer> customers = repository.GetAll().ToList();

            //Assert

            Assert.AreEqual(2, customers.Count);

        }

        [Test]

        public void GetAllFailTest()

        {

            List<Customer> customers = repository.GetAll().ToList();

            //Assert

            Assert.IsEmpty(customers);

        }

    }
}