namespace ExampleSatelite.Sage50.AvantLeap.ChargeAction
{
    public class ExecuteChargeActionCommand
    {
        public ExecuteChargeActionCommand() 
        {
            new ExecuteChargeActionForm().ShowDialog();
            new ExecuteChargeAction();
        }
    }
}
