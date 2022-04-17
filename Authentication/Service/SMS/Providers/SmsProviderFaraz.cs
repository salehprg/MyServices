namespace Authentication.Service.SMS
{
    public class SmsProviderFaraz : SmsProviderBase
    {
        public override string link { get => "Faraz api"; set{link = value;} }

        protected override void SendSMSAPI(string text , string number)
        {
            Console.WriteLine($"Send {text} to {number} with {link}");
        }

        public override void SendSMSAPI_Pattern(string text, string number , string pattern)
        {
            Console.WriteLine($"Faraz : Send {text} to {number} pattern {link}");
        }
    }
}