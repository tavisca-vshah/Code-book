namespace Code_book.Design_Pattern.Facade
{
    public class Order
    {
        public void PlaceOrder()
        {
            var product = new Product();
            var payment = new Payment();
            var invoice = new Invoice();

            product.GetDetails();
            payment.PayOnline();
            invoice.GenerateInvoice();
        }
    }
}
