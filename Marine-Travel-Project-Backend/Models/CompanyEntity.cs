

namespace Marine_Travel_Project_Backend.Models;

internal record CompanyEntity 
{
    public Guid CompanyId { get; init; }
    public string CompanyName { get; init; } = string.Empty;
}
