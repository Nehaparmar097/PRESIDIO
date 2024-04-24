namespace ShoppingCustomerRepoTest
{
    public class ItemPresentException:Exception
    {
        string message;
        public ItemPresentException()
        {
            message = "Customer with the given Id is not present";
        }
        public override string Message => message;
    }
}