using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_book.Design_Pattern.Prototype
{
    public class Customer: ICloneable
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            var newCopy = (Customer) this.MemberwiseClone();
            newCopy.Address = (Address)this.Address.Clone();
            return newCopy;
        }
    }
}
