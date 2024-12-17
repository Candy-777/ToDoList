using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class Extencions
    {
        public static void AddDataBase(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AppDbContext>(o=>
            {
                o.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True;");
            });
        }
    }
}
