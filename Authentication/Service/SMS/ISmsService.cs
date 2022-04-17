using Authentication.Service.SMS;

namespace Authentication.Interface
{
    public interface ISmsService
    {
        void SendSMS(string text , string phonenumber , SmsProviderBase provider);
        void SendSMSPattern(string text , string phonenumber , string patternCode , SmsProviderBase provider);
    }
}