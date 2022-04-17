using Authentication.Interface;
using Authentication.Service.SMS;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private readonly ISmsService smsService;

    public UsersController(ILogger<UsersController> logger, ISmsService smsService)
    {
        _logger = logger;
        this.smsService = smsService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        SmsProviderFaraz smsProvider = new SmsProviderFaraz();

        smsService.SendSMS("Hello" , "091548076" , smsProvider);
        smsService.SendSMSPattern("Hello" , "091548076" , "1xc", smsProvider);
        return Ok();
    }
}
