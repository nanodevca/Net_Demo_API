using System;
namespace SocialMedia.Api.Registrars
{
	public interface IWebApplicationBuilderRegistrar
	{
		public void RegisterServices(WebApplicationBuilder builder);
	}
}

