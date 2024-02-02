using Microsoft.AspNetCore.Mvc;
using SocialMedia.Api.Commons.Constants;

namespace SocialMedia.Api.Controllers.V1
{
    [ApiVersion("1.0")]
	[Route(ApiRoutes.BaseRoute)]
	[ApiController]
	public class PostsController: Controller
	{
		[HttpGet]
		[Route(ApiRoutes.Post.GetById)]
        public IActionResult GetById(int id)
		{

			return Ok();
		}
	}
}

