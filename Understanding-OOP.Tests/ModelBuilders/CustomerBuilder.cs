using System;
using System.Collections.Generic;
using System.Text;

namespace Understanding_OOP.Tests.ModelBuilders
{
    public class CustomerBuilder<T> where T : CustomerBase, new()
    {
        private T _instance = new T();
        public CustomerBuilder<T> WithCustomerName(string name)
        {
            _instance.CustomerName = name;
            return this;
        }

        public CustomerBuilder<T> WithPhone(string phoneNumber)
        {
            _instance.PhoneNumber = phoneNumber;
            return this;
        }
        public CustomerBuilder<T> WithBillAmount(decimal billAmount)
        {
            _instance.BillAmount = billAmount;
            return this;
        }
        public CustomerBuilder<T> WithBillDate(DateTime billDate)
        {
            _instance.BillDate = billDate;
            return this;
        }
        public CustomerBuilder<T> WithAddress(string address)
        {
            _instance.Address = address;
            return this;
        }

        public static implicit operator T(CustomerBuilder<T> instance) { return instance.Build(); }
        public T Build()
        {
            return _instance;
        }
    }
}
