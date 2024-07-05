namespace ExampleSatelite.Sage50.AvantLeap.PayAction
{
    public class ExecutePayActionCommand
    {
        private string _Error_Message = "";
        public string _Error() => this._Error_Message.Trim();
        public ExecutePayActionCommand() 
        {
            new ExecutePayActionForm().ShowDialog();
            new ExecutePayAction();
        }
    }
}
