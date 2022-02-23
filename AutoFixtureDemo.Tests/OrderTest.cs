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

            // inject a specific value - this will be used for all instances of customer
            fixture.Inject(new Customer
            {
                CustomerName = "John Smith"
            });

            var order = fixture.Create<Order>();

            // act
            // assert
        }

        [Fact]
        public void FreezingValues()
        {
            // arrange
            var fixture = new Fixture();

            var id = fixture.Create<int>();
            fixture.Inject(id);

            var customerName = fixture.Create<string>();
            fixture.Inject(customerName);

            var sut = fixture.Create<Order>();

            // act
            var result = sut.ToString();

            // assert
            Assert.Equal($"{id}--{customerName}", result);
        }

        [Fact]
        public void FreezingValuesConcise()
        {
            // arrange
            var fixture = new Fixture();

            var id = fixture.Freeze<int>();
            var customerName = fixture.Freeze<string>();

            var sut = fixture.Create<Order>();

            // act
            var result = sut.ToString();

            // assert
            Assert.Equal($"{id}--{customerName}", result);
        }
    }
}
