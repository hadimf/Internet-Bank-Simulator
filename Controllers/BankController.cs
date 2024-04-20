using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers;

[ApiController]
[Route("[controller]")]
public class BankController : ControllerBase
{


    private readonly ILogger<BankController> _logger;

    public BankController(ILogger<BankController> logger)
    {
        _logger = logger;
    }


}
