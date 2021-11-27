using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Understanding_OOP_Contracts;
using ValidationStrategies;

namespace Understanding_OOP
{
    public static class CustomerFactory
    {
        private static ConcurrentDictionary<string, ICustomerBase> _customers = new ConcurrentDictionary<string, ICustomerBase>(StringComparer.OrdinalIgnoreCase);
        //static CustomerFactory()
        //{
        //    /*
        //     * Eager loading
        //     */
        //}
        public static ICustomerBase Create(string customerType)
        {
            /*
             * Design pattern: Simple factory
             */
            if(_customers.Count == 0)
            {
                /* 
                 * lazy initailization
                 */
                _customers.TryAdd("customer", new Customer(new CustomerValidationStratgey()));
                _customers.TryAdd("lead", new Lead(new LeadCustomerValidationStratgey()));
            }
            if(_customers.TryGetValue(customerType, out ICustomerBase instance))
            {
                return instance;
            }

            throw new ArgumentException("The Customer type provided is parameter is invalid");
        }
    }
}