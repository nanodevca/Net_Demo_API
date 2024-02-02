using System;
namespace SocialMedia.Api.Registrars
{
	public interface IWebApplicationRegistrar
	{
		public void RegisterPipelineComponents(WebApplication app);
    }
}

