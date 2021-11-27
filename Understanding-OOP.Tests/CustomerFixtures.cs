using FluentAssertions;
using System;
using System.Collections.Generic;
using Understanding_OOP.Tests.ModelBuilders;
using ValidationStrategies;
using Xunit;


namespace Understanding_OOP.Tests
{
    public class CustomerFixtures
    {
        [Fact]
        public void Validate_Should_Throws_ValidationException_When_Name_IsNotValid()
        {
            Customer customer = new CustomerBuilder().WithDefaultValidationStrategy();

            Action validate = () => customer.Validate();
            validate.Should().Throw<ArgumentException>().WithMessage("CustomerName cannot be null. (Parameter 'CustomerName')");
        }

        [InlineData(null, "PhoneNumber cannot be null. (Parameter 'PhoneNumber')")]
        [InlineData("", "PhoneNumber cannot be empty. (Parameter 'PhoneNumber')")]
        [InlineData("qwertyuiopf", "PhoneNumber must consist of 10 characters. (Parameter 'PhoneNumber')")]
        [Theory]
        public void Validate_Should_Throws_ValidationException_When_Phone_IsNotValid(string phoneNumber,string errorMessage)
        {
            Customer customer = new CustomerBuilder()
                                .WithCustomerName("john")
                                .WithPhone(phoneNumber)
                                .WithBillDate(DateTime.Now)
                                .WithBillAmount(100m)
                                .WithAddress("Random address")
                                .WithDefaultValidationStrategy();

            Action validate = () => customer.Validate();
            validate.Should().Throw<ArgumentException>().WithMessage(errorMessage);
        }
       
        [Theory]
        [MemberData(nameof(Data))]
        public void Validate_Should_Throws_ValidationException_When_BillDate_IsNotValid(DateTime dateTime, string errorMessage)
        {
            Customer customer = new CustomerBuilder()
                                .WithCustomerName("john")
                                .WithPhone("9999999999")
                                .WithBillDate(dateTime)
                                .WithBillAmount(100m)
                                .WithAddress("Random address")
                                .WithDefaultValidationStrategy();

            Action validate = () => customer.Validate();
            validate.Should().Throw<ArgumentException>().WithMessage(errorMessage);
        }
        [Fact]
        public void Validate_Should_Not_Throws_ValidationException_When_AllFieldAreValid()
        {
            Customer customer = new CustomerBuilder()
                                .WithCustomerName("john")
                                .WithPhone("9999999999")
                                .WithBillDate(DateTime.Now)
                                .WithBillAmount(100m)
                                .WithAddress("Random address")
                                .WithDefaultValidationStrategy();

            customer.Validate();
        }

        public static IEnumerable<object[]> Data => new[]
        {
            new object[] { DateTime.MinValue, "BillDate cannot be 1/1/0001 12:00:00 AM. (Parameter 'BillDate')" },
            new object[] { default(DateTime), "BillDate cannot be 1/1/0001 12:00:00 AM. (Parameter 'BillDate')" },
        };
    }
}
