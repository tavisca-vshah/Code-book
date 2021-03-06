using System;
using Understanding_OOP_Contracts;
using ValidationStrategies;

namespace Understanding_OOP.Tests.ModelBuilders
{
    public class CustomerBuilder
    {
        private string CustomerName;
        private string PhoneNumber;
        private decimal BillAmount;
        private DateTime BillDate;
        private string Address;

        public IValidationStrategy<ICustomerBase> ValidationStrategy;

        public CustomerBuilder WithCustomerName(string name)
        {
            CustomerName = name;
            return this;
        }

        public CustomerBuilder WithPhone(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            return this;
        }

        public CustomerBuilder WithBillAmount(decimal billAmount)
        {
            BillAmount = billAmount;
            return this;
        }

        public CustomerBuilder WithBillDate(DateTime billDate)
        {
            BillDate = billDate;
            return this;
        }

        public CustomerBuilder WithAddress(string address)
        {
            Address = address;
            return this;
        }
        public CustomerBuilder WithValidationStrategy(IValidationStrategy<ICustomerBase> validationStrategy)
        {
            ValidationStrategy = validationStrategy;
            return this;
        }
        public CustomerBuilder WithDefaultValidationStrategy()
        {
            ValidationStrategy = new CustomerValidationStratgey();
            return this;
        }

        public static implicit operator Customer(CustomerBuilder instance) => instance.Build();

        public Customer Build()
        {
            return new Customer(ValidationStrategy)
            {
                CustomerName = CustomerName,
                Address = Address,
                BillDate = BillDate,
                PhoneNumber = PhoneNumber,
                BillAmount = BillAmount
            };
        }
    }
}