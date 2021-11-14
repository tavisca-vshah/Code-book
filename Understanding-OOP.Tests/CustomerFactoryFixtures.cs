using System;
using Xunit;
using FluentAssertions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Understanding_OOP.Tests
{
    public class CustomerFactoryFixtures
    {
        [Theory]
        [InlineData("Customer",typeof(Customer))]
        [InlineData("customer", typeof(Customer))]
        [InlineData("lead", typeof(Lead))]
        [InlineData("Lead", typeof(Lead))]
        [InlineData("CUSTOMER", typeof(Customer))]
        [InlineData("LEAD", typeof(Lead))]
        public void Create_Should_RespectiveType_Objects(string customerType, Type expectedCutomerType)
        {
            var customer = CustomerFactory.Create(customerType);
            customer.Should().BeOfType(expectedCutomerType);
        }
        [Fact]
        public void Create_Should_Throws_Exception_On_InvalidCustomerType()
        {
            Action getCustomerInstance = () => CustomerFactory.Create("dummy");
            getCustomerInstance.Should().Throw<ArgumentException>().WithMessage("The Customer type provided is parameter is invalid");
        }
        [Fact]
        public void TestsForThreadSafety()
        {
            var customerTypes = new List<string> { "customer", "lead", "Customer", "Lead" };
            var actions = new List<Action>();
            customerTypes.ForEach(customerType => actions.Add(() => CustomerFactory.Create(customerType)));

            Parallel.Invoke(actions.ToArray());
        }
    }
}
