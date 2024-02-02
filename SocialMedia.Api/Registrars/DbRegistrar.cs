using System;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Dal;

namespace SocialMedia.Api.Registrars
{
	public class DbRegistrar: IWebApplicationBuilderRegistrar
	{

        public void RegisterServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("SqliteConnetion");
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
        }
    }
}

