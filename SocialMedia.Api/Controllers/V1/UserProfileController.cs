using System;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Api.Commons.Constants;
using SocialMedia.Api.DTOs.UserProfile;
using SocialMedia.Application.UserProfiles.Commands;

namespace SocialMedia.Api.Controllers.V1
{
	[ApiVersion("1.0")]
	[Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfileController: Controller
	{
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

		public UserProfileController(IMediator mediator, IMapper mapper)
		{
            _mediator = mediator;
            _mapper = mapper;

        }

		[HttpGet]
		public IActionResult GetAllProfile()
		{
            return Ok();
		}

        [HttpGet]
        [Route(ApiRoutes.UserProfile.GetById)]
        public IActionResult GetAllProfile(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody] CreateUserProfileDto profileInfo)
        {
            var command = _mapper.Map<CreateUserCommand>(profileInfo);
            var response = await _mediator.Send(command);
        }
    }
}

