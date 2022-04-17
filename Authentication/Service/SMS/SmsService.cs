using Authentication.Interface;

namespace Authentication.Service.SMS
{
    public class SmsService : ISmsService
    {
        public void SendSMS(string text, string phonenumber , SmsProviderBase providerBase)
        {
            providerBase.SendSMS(text , phonenumber);
        }

        public void SendSMSPattern(string text, string phonenumber, string patternCode, SmsProviderBase provider)
        {
            provider.SendSMSAPI_Pattern(text , phonenumber , "ax2");
        }
    }
}