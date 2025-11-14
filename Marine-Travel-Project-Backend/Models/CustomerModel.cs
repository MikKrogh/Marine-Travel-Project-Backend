
namespace Marine_Travel_Project_Backend.Models;

public class CustomerModel
{
    public string FullName { get; set; } = string.Empty;
    public string Title {  get; set; }  = string.Empty;
    public Guid CustomerId { get; set; }

}
