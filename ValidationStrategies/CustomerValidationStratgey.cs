using Dawn;
using System;
using Understanding_OOP_Contracts;

namespace ValidationStrategies
{
    public class CustomerValidationStratgey : IValidationStrategy<ICustomerBase>
    {
        public void Validate(ICustomerBase obj)
        {
            Guard.Argument(obj.CustomerName, nameof(ICustomerBase.CustomerName)).NotNull().NotEmpty();
            Guard.Argument(obj.PhoneNumber, nameof(ICustomerBase.PhoneNumber)).NotNull().NotEmpty().Length(10);
            Guard.Argument(obj.BillAmount, nameof(ICustomerBase.BillAmount)).NotZero().NotNegative();
            Guard.Argument(obj.BillDate, nameof(ICustomerBase.BillDate)).NotDefault();
            Guard.Argument(obj.Address, nameof(ICustomerBase.Address));
        }
    }
}
