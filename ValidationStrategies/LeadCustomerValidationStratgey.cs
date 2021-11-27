using Dawn;
using System;
using Understanding_OOP_Contracts;

namespace ValidationStrategies
{
    public class LeadCustomerValidationStratgey : IValidationStrategy<ICustomerBase>
    {
        public void Validate(ICustomerBase obj)
        {
            Guard.Argument(obj.CustomerName, nameof(ICustomerBase.CustomerName)).NotNull().NotEmpty();
            Guard.Argument(obj.PhoneNumber, nameof(ICustomerBase.PhoneNumber)).NotNull().NotEmpty().Length(10);
        }
    }
}
