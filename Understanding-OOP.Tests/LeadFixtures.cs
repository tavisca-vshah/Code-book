using FluentAssertions;
using System;
using System.Collections.Generic;
using Understanding_OOP.Tests.ModelBuilders;
using Xunit;

namespace Understanding_OOP.Tests
{
    public class LeadFixtures
    {
        [Fact]
        public void Validate_Should_Throws_ValidationException_When_Name_IsNotValid()
        {
            Lead customer = new CustomerBuilder<Lead>();

            Action validate = () => customer.Validate();
            validate.Should().Throw<ArgumentException>().WithMessage("CustomerName cannot be null. (Parameter 'CustomerName')");
        }
        [InlineData(null, "PhoneNumber cannot be null. (Parameter 'PhoneNumber')")]
        [InlineData("", "PhoneNumber cannot be empty. (Parameter 'PhoneNumber')")]
        [InlineData("qwertyuiopf", "PhoneNumber must consist of 10 characters. (Parameter 'PhoneNumber')")]
        [Theory]
        public void Validate_Should_Throws_ValidationException_When_Phone_IsNotValid(string phoneNumber, string errorMessage)
        {
            Lead customer = new CustomerBuilder<Lead>()
                                .WithCustomerName("john")
                                .WithPhone(phoneNumber)
                                .WithBillDate(DateTime.Now)
                                .WithBillAmount(100m)
                                .WithAddress("Random address");

            Action validate = () => customer.Validate();
            validate.Should().Throw<ArgumentException>().WithMessage(errorMessage);
        }
        [Fact]
        public void Validate_Should_Not_Throws_ValidationException_When_OtherThanNameAndPhoneNumber_IsNotProvided()
        {
            Lead customer = new CustomerBuilder<Lead>().WithCustomerName("john").WithPhone("9999999999")
                                .WithAddress("Random address");

            customer.Validate();
        }
        [Fact]
        public void Validate_Should_Not_Throws_ValidationException_When_AllFieldAreValid()
        {
            Lead customer = new CustomerBuilder<Lead>()
                                .WithCustomerName("john")
                                .WithPhone("9999999999");

            customer.Validate();
        }

        public static IEnumerable<object[]> Data => new[]
        {
            new object[] { DateTime.MinValue, "BillDate cannot be 1/1/0001 12:00:00 AM. (Parameter 'BillDate')" },
            new object[] { default(DateTime), "BillDate cannot be 1/1/0001 12:00:00 AM. (Parameter 'BillDate')" },
        };
    }
}
