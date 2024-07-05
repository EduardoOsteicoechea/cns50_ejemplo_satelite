using ExampleSatelite.Sage50.AvantLeap.PurchaseBill;

namespace ExampleSatelite.Sage50.AvantLeap.PaymentBill
{
    public class CreatePaymentBillCommand
    {
        private string _Error_Message = "";
        public string _Error() => this._Error_Message.Trim();
        public CreatePaymentBillCommand() 
        {
            new CreatePaymentBillForm().ShowDialog();
            new CreatePayBill();
        }
    }
}
