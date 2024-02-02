using System;
using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.Api.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/posts")]
    [ApiController]
	public class PostsController: Controller
	{
		[HttpGet]
		[Route("{id}")]
        public IActionResult GetById(int id)
		{
			return Ok();
		}
	}
}

