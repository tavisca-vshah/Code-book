namespace Code_book.Design_Pattern.Facade
{
    public class Product
    {
        public string GetDetails()
        {
            return "Product information";
        }
    }

    public class Payment
    {
        public void PayOnline()
        {

        }
    }
    public class Invoice
    {
        public void GenerateInvoice()
        {

        }
    }
}
