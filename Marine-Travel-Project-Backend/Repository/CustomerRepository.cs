using Marine_Travel_Project_Backend.Models;
using Marine_Travel_Project_Backend.Repository.Interfaces;

namespace Marine_Travel_Project_Backend.Repository;

internal class CustomerRepository : ICustomerRepository
{
    public Dictionary<Guid ,CustomerModel> Get()
    {
        //Simulating DB call
        var entities = new Dictionary<Guid, CustomerModel>
        {
            [Guid.NewGuid()] = new CustomerModel { FullName = "Mikkel Glerup", Title = "Mr.", CompanyId = Guid.NewGuid() },
            [Guid.NewGuid()] = new CustomerModel { FullName = "Lasse Jessen", Title = "Mr.", CompanyId = Guid.NewGuid() },
            [Guid.NewGuid()] = new CustomerModel { FullName = "Niels Christensen", Title = "Mr.", CompanyId = Guid.NewGuid() },
            [Guid.NewGuid()] = new CustomerModel { FullName = "Benjamin Andersen", Title = "Dr.", CompanyId = Guid.NewGuid() },
            [Guid.NewGuid()] = new CustomerModel { FullName = "Mikkel kronborg", Title = "Mrs" , CompanyId = Guid.NewGuid() },
            [Guid.NewGuid()] = new CustomerModel { FullName = "Malthe Phillipsen", Title = "", CompanyId = Guid.NewGuid() },
        };
        
        foreach (var key in entities.Keys)
        {
            entities[key].CustomerId = key;
        }
        return entities;
    }
}
