using System;

namespace Code_book.Design_Pattern.Prototype
{
    public class Address: ICloneable
    {
        public string Pincode { get; set; }
        public string City { get; set; }

        public object Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}