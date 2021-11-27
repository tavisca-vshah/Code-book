using System;

namespace Understanding_OOP_Contracts
{
    public interface ICustomerBase
    {
        string Address { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }

        void Validate();
    }
}