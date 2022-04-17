namespace Authentication.Interface
{
    public interface IUserService
    {
        Task Login();
        Task Register();
        Task ForgotPassword();
        Task GetProfileInfo();
        
    }
}