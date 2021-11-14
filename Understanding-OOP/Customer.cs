using Dawn;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Understanding_OOP
{
    public class CustomerBase
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
        public override void Validate()
        {
            base.Validate();
            Guard.Argument(BillAmount, nameof(BillAmount)).NotZero().NotNegative();
            Guard.Argument(BillDate, nameof(BillDate)).NotDefault();
            Guard.Argument(Address, nameof(Address));
        }
    }

    public class Lead: CustomerBase
    {
    }
}