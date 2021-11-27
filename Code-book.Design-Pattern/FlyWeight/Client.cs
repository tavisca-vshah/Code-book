namespace Code_book.Design_Pattern.FlyWeight
{
    public class Address
    {
        public string Pincode = "123456";
        public string City = "Mumbai";
    }

    public static class SingleInstance
    {
        public readonly static Address Address = new Address();
    }

    public class Employee
    {
        public Address GetCompanyAddress()
        {
            return SingleInstance.Address;
        }

        public string Name = "";
    }
}
