using Microsoft.EntityFrameworkCore;
using WeBlazorServerApp.Data;

[assembly: HostingStartup(typeof(WeBlazorServerApp.Areas.Identity.IdentityHostingStartup))]
namespace WeBlazorServerApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<AccountContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("AccountContextConnection")));
            });               
        }
    }
}
