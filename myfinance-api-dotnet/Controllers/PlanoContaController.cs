using Microsoft.AspNetCore.Mvc;

namespace myfinance_api_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class PlanoContaController : ControllerBase
{
    private readonly MyFinanceDbContext _financeDbContext;

    public PlanoContaController(MyFinanceDbContext financeDbContext)
    {
        _financeDbContext = financeDbContext;
    }

    [HttpGet]
    public string Get()
    {
        var descricao = _financeDbContext.PlanoConta.FirstOrDefault().Descricao;
        return descricao;
    }
}
