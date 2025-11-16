

using Marine_Travel_Project_Backend.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Marine_Travel_Project_Backend.Controllers;

internal class CompanyController
{
    private readonly ILogger<CompanyController> _logger;
    private readonly CompanyRepository _companyRepo;
    public CompanyController(ILogger<CompanyController> logger, CompanyRepository companyRepo)
    {
        _logger = logger;
        _companyRepo = companyRepo;
    }

    [Function("GetCompany")]
    public IActionResult GetCompany([HttpTrigger(AuthorizationLevel.Function, "get", Route = "Company/{id}")] HttpRequest req)
    {
        string companyId = req.RouteValues["id"]?.ToString() ?? string.Empty;
        Guid id;
        bool isValid = Guid.TryParse(companyId, out id);

        if (!isValid)
            return new BadRequestResult();

        var company = _companyRepo.Get(id);

        if (company is null)
            return new NotFoundResult();
        return new OkObjectResult(company);

    }
}

