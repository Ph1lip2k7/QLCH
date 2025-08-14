using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ASM1_VuThienTruong.Data
{
    public class WebBanHangContextFactory : IDesignTimeDbContextFactory<WebBanHangContext>
    {
        public WebBanHangContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<WebBanHangContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new WebBanHangContext(optionsBuilder.Options);
        }
    }
}
