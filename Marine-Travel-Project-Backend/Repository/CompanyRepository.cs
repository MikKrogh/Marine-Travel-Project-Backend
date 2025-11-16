
using Marine_Travel_Project_Backend.Models;

namespace Marine_Travel_Project_Backend.Repository;

internal class CompanyRepository 
{
    public CompanyEntity? Get(Guid companyId)
    {
        if (companyId == Guid.Empty)
        {
            return null;
        }
        return new CompanyEntity
        {
            CompanyId = companyId,
            CompanyName = companyId.ToString().Take(5) + "Test Company A/S"
        };
    }
}
