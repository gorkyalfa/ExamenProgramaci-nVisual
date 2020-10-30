using Examen.Models;
using Microsoft.EntityFrameworkCore;


namespace Examen.Data
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder _builder)
        {
            _builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Car> Cars { get; set; } 

    }
}
