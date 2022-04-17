namespace Authentication.Service.SMS
{
    public abstract class SmsProviderBase
    {
        public abstract string link {get;set;}

        protected abstract void SendSMSAPI(string text , string number);
        
        public virtual void SendSMSAPI_Pattern(string text , string number , string pattern)
        {
            Console.WriteLine($"Not Implemented");
        }

        public void SendSMS(string text , string number)
        {
            Console.WriteLine($"Sending sms text : {text} Number : {number}");

            SendSMSAPI(text , number);
        }
    }
}