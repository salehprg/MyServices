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

            return Task.CompletedTask;
        }

        public Task GetProfileInfo()
        {
            return Task.CompletedTask;
        }

        public Task Login()
        {
            return Task.CompletedTask;
        }

        public Task Register()
        {
            return Task.CompletedTask;
        }
    }
}