using System;
namespace SocialMedia.Api.Commons.Constants
{
	public class ApiRoutes
	{
		public const string BaseRoute = "api/v{version:apiVersion}/[controller]";

		public class UserProfile
		{
			public const string GetById = "{id}";

        }

        public class Post
        {
            public const string GetById = "{id}";

        }
    }
}

