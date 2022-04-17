namespace Authentication.Service.SMS
{
    public class SmsProviderNegin : SmsProviderBase
    {
        public override string link { get => "negin api"; set{link = value;} }

        protected override void SendSMSAPI(string text , string number)
        {
            Console.WriteLine($"Send {text} to {number} with {link}");
        }
    }
}