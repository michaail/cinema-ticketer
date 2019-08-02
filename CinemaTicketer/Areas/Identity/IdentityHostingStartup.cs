using System;
using CinemaTicketer.Areas.Identity.Data;
using CinemaTicketer.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CinemaTicketer.Areas.Identity.IdentityHostingStartup))]
namespace CinemaTicketer.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<User>().AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<CinemaTicketerContext>();
            });
        }
    }
}