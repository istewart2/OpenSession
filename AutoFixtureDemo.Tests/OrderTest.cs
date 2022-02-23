using AutoFixture;
using System;
using Xunit;

namespace AutoFixtureDemo.Tests
{
    public class OrderTest
    {
        [Fact]
        public void ManualObjectGraphCreation()
        {
            Customer customer = new Customer()
            {
                CustomerName = "Mary Smith"
            };

            Order order = new Order(customer)
            {
                Id = 1,
                OrderDate = DateTime.Now,
                Items =
            {
                new OrderItem()
                {
                    ProductName = "TestProduct1",
                    Quantity = 5
                },
                new OrderItem()
                {
                    ProductName = "TestProduct2",
                    Quantity = 3
                },
            }
            };

            // act
            // assert
        }

        [Fact]
        public void AutoCreation()
        {
            var fixture = new Fixture();
            var order = fixture.Create<Order>();

            // act
            // assert
        }
    }
}
