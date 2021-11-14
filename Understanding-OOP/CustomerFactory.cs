using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Understanding_OOP
{
    public static class CustomerFactory
    {
        private static ConcurrentDictionary<string, CustomerBase> _customers = new ConcurrentDictionary<string, CustomerBase>(StringComparer.OrdinalIgnoreCase);
        //static CustomerFactory()
        //{
        //    /*
        //     * Eager loading
        //     */
        //}
        public static CustomerBase Create(string customerType)
        {
            /*
             * Design pattern: Simple factory
             */
            if(_customers.Count == 0)
            {
                /* 
                 * lazy initailization
                 */
                _customers.TryAdd("customer", new Customer());
                _customers.TryAdd("lead", new Lead());
            }
            if(_customers.TryGetValue(customerType, out CustomerBase instance))
            {
                return instance;
            }

            throw new ArgumentException("The Customer type provided is parameter is invalid");
        }
    }
}