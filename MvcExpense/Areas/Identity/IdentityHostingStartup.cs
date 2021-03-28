using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcExpense.Areas.Identity.Data;
using MvcExpense.Data;

[assembly: HostingStartup(typeof(MvcExpense.Areas.Identity.IdentityHostingStartup))]
namespace MvcExpense.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MvcExpenseDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MvcExpenseDbContextConnection")));

                services.AddDefaultIdentity<MvcExpenseUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MvcExpenseDbContext>();
            });
        }
    }
}