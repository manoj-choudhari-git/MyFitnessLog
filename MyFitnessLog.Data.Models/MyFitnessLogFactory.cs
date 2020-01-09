using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MyFitnessLog.Data.Models
{
    public class MyFitnessLogFactory: IDesignTimeDbContextFactory<MyFitnessLogContext>
    {
        public MyFitnessLogContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var dbContextBuilder = new DbContextOptionsBuilder<MyFitnessLogContext>();
            string connectionString = configuration.GetConnectionString("SqlConnectionString");

            dbContextBuilder.UseSqlServer(connectionString);
            return new MyFitnessLogContext(dbContextBuilder.Options);
        }
    }
}
