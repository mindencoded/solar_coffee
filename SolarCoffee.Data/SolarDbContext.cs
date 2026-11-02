using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Data
{
    public class SolarDbContext(DbContextOptions options) : IdentityDbContext(options)
    {
        public virtual DbSet<Customer>  Customers { get; set; }
    
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
    }
}