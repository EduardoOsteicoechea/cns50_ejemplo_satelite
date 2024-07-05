namespace ExampleSatelite.Sage50.AvantLeap.SalesBill
{
    public class CreateSalesBillCommand
    {
        public CreateSalesBillCommand() 
        {
            new CreateSalesBillForm().ShowDialog();
            new CreateSalesBill();
        }
    }
}
