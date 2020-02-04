using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Core.Data.SQLServer;

namespace OnlineStore.UnitTest
{
    public class DbConnection
    {
        public DbContextOptionsBuilder<OnlineStoreDbContext> InitConfiguration()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .BuildServiceProvider();

            var config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
             .Build();

            var builder = new DbContextOptionsBuilder<OnlineStoreDbContext>();
            //Or any other way builder.UseSqlServer($"Server=VSA-SAT-DB1\\SQL2K14;Database=onlinestore;User ID=uttam;Password=uttam;")
            builder.UseSqlServer(config["ConnectionStrings"])
                    .UseInternalServiceProvider(serviceProvider);

            return builder;
        }
    }
}




