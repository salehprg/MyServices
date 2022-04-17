using Authentication.Interface;
using Authentication.Service.SMS;

namespace Authentication.Service
{
    public class UserService : IUserService
    {
        ISmsService smsService;
        public UserService(ISmsService smsService)
        {
            this.smsService = smsService;
        }

        public Task ForgotPassword()
        {
            SmsProviderNegin smsProviderNegin = new SmsProviderNegin();
            
            smsService.SendSMS("forgot password" , "09154807673" , smsProviderNegin);
        }

        public Task GetProfileInfo()
        {
            
        }

        public Task Login()
        {
            
        }

        public Task Register()
        {
            
        }
    }
}