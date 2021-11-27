using System;
using Understanding_OOP_Contracts;

namespace Understanding_OOP.Tests.ModelBuilders
{
    public class LeadCustomerBuilder
    {
        private string CustomerName;
        private string PhoneNumber;
        private decimal BillAmount;
        private DateTime BillDate;
        private string Address;

        public IValidationStrategy<ICustomerBase> ValidationStrategy;

        public LeadCustomerBuilder WithCustomerName(string name)
        {
            CustomerName = name;
            return this;
        }

        public LeadCustomerBuilder WithPhone(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            return this;
        }

        public LeadCustomerBuilder WithBillAmount(decimal billAmount)
        {
            BillAmount = billAmount;
            return this;
        }

        public LeadCustomerBuilder WithBillDate(DateTime billDate)
        {
            BillDate = billDate;
            return this;
        }

        public LeadCustomerBuilder WithAddress(string address)
        {
            Address = address;
            return this;
        }
        public LeadCustomerBuilder WithValidationStrategy(IValidationStrategy<ICustomerBase> validationStrategy)
        {
            ValidationStrategy = validationStrategy;
            return this;
        }

        public static implicit operator Lead(LeadCustomerBuilder instance) => instance.Build();

        public Lead Build()
        {
            return new Lead(ValidationStrategy)
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