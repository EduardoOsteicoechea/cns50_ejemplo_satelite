namespace ExampleSatelite.Sage50.AvantLeap.PurchaseBill
{
    public class CreatePurchaseBillCommand
    {
        private string _Error_Message = "";
        public string _Error() => this._Error_Message.Trim();
        public CreatePurchaseBillCommand() 
        {
            new CreatePurchaseBillForm().ShowDialog();
            new CreatePurchaseBill();
        }
    }
}
