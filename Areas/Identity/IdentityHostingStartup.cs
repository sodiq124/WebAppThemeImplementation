//using System;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using WebAppThemeImplementation.Areas.Identity.Data;
//using WebAppThemeImplementation.Data;

//[assembly: HostingStartup(typeof(WebAppThemeImplementation.Areas.Identity.IdentityHostingStartup))]
//namespace WebAppThemeImplementation.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<WebDBContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("WebDBContextConnection")));

//                services.AddDefaultIdentity<WebAppThemeUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                    .AddEntityFrameworkStores<WebDBContext>();
//            });
//        }
//    }
//}