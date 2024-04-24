
using ShoppingDALLibrary;
using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCustomerRepoTest;

namespace ShoppinProductRepoTest
{
    public class ProductTest
    {
        IRepository<int, Product> repository;

        [SetUp]

        public void Setup()

        {

            repository = new ProductRepository();

        }

        [Test]

        public void AddSuccessTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            var result = repository.Add(product);

            //Assert

            Assert.IsNotNull(result);

        }

        [Test]

        public void AddFailTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product);

            Product product1 = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            var exception = Assert.Throws<ItemPresentException>(() => repository.Add(product1));

            //Assert

            Assert.That(exception.Message, Is.EqualTo("Item already present"));


        }

        [Test]

        public void GetAllSuccessTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 90
            };

            repository.Add(product);

            Product product1 = new Product() {
                Id = 2,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product1);

            List<Product> products = repository.GetAll().ToList();

            //Assert

            Assert.AreEqual(2, products.Count);

        }

        [Test]

        public void GetAllFailTest()

        {

            List<Product> products = repository.GetAll().ToList();

            //Assert

            Assert.IsEmpty(products);

        }

        [Test]

        public void GetIdSuccessTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product);

            var result = repository.GetByKey(1);

            Assert.IsNotNull(result);

        }

        [Test]

        public void GetIdFailTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product);

            var exception = Assert.Throws<NoProductWithGiveIdException>(() => repository.GetByKey(2));

            //Assert

            Assert.AreEqual("Product with the given Id is not present", exception.Message);

        }

        [Test]

        public void DeleteSuccessTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product);

            var result = repository.Delete(1);

            Assert.IsNotNull(result);

        }

        [Test]

        public void DeleteFailTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product);

            var exception = Assert.Throws<NoProductWithGiveIdException>(() => repository.Delete(2));

            //Assert

            Assert.AreEqual("Product with the given Id is not present", exception.Message);

        }

        [Test]

        public void UpdateSuccessTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product);

            Product product1 = new Product() {
                Id = 2,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            var result = repository.Update(product1);

            Assert.AreEqual(100, result.Price);

        }

        [Test]

        public void UpdateFailTest()

        {

            Product product = new Product() {
                Id = 1,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            repository.Add(product);

            Product product1 = new Product() {
                Id = 2,
                Price = 10.99,
                Name = "Product 1",
                Image = "image1.jpg",
                QuantityInHand = 20
            };

            var exception = Assert.Throws<NoProductWithGiveIdException>(() => repository.Update(product1));

            //Assert

            Assert.AreEqual("Product with the given Id is not present", exception.Message);

        }

    }
}
