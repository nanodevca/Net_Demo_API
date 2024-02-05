
using SocialMedia.Application.UserProfiles.Queries;

namespace SocialMedia.Api.Registrars
{
	public class MapperRegistrar: IWebApplicationBuilderRegistrar
	{

        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfilesQuery));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(GetAllUserProfilesQuery)));
        }
    }
}

