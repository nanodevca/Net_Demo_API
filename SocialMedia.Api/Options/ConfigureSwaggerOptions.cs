﻿using System;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SocialMedia.Api.Options
{
	public class ConfigureSwaggerOptions: IConfigureOptions<SwaggerGenOptions>
	{
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => _provider = provider;


        public void Configure(SwaggerGenOptions options)
        {
            foreach(var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateVersionInfo(description));
            }

        }

        private OpenApiInfo CreateVersionInfo (ApiVersionDescription description )
        {
            OpenApiInfo info = new OpenApiInfo
            {
                Title = "SocialMedia ",
                Version = description.ApiVersion.ToString()
            };

            if(description.IsDeprecated)
            {
                info.Description = "This api version has been deprecated"; 
            }

            return info;
        }
    }
}

