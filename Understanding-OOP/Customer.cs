using Dawn;
using System;
using Understanding_OOP_Contracts;

namespace Understanding_OOP
{
    public class CustomerBase : ICustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public virtual void Validate()
        {
            Guard.Argument(CustomerName, nameof(CustomerName)).NotNull().NotEmpty();
            Guard.Argument(PhoneNumber, nameof(PhoneNumber)).NotNull().NotEmpty().Length(10);
        }
    }

    public class Customer : CustomerBase
    {
        private IValidationStrategy<ICustomerBase> _validationStratgey;

        public Customer(IValidationStrategy<ICustomerBase> customerValidationStratgey)
        {
            _validationStratgey = customerValidationStratgey;
        }

        public override void Validate()
        {
            _validationStratgey?.Validate(this);
        }
    }

    public class Lead : CustomerBase
    {
        private IValidationStrategy<ICustomerBase> _validationStratgey;

        public Lead(IValidationStrategy<ICustomerBase> leadCustomerValidationStratgey)
        {
            _validationStratgey = leadCustomerValidationStratgey;
        }

        public override void Validate()
        {
            _validationStratgey?.Validate(this);
        }
    }
}