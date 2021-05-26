using CQRS_Microservices.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CQRS_Microservices.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync();
    }
}