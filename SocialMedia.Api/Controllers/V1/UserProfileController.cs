using System;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Api.Commons.Constants;
using SocialMedia.Api.DTOs.UserProfile;
using SocialMedia.Application.UserProfiles.Commands;
using SocialMedia.Application.UserProfiles.Queries;

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
		public async Task<IActionResult> GetAllProfile()
		{
            var query = new GetAllUserProfilesQuery();
            var response = await _mediator.Send(query);
            var profiles = _mapper.Map<List<UserProfileResponseDto>>(response);

            return Ok(profiles);
        }

        [HttpGet]
        [Route(ApiRoutes.UserProfile.IdRoute)]
        public async Task<IActionResult> GetUserProfileById(string id)
        {
            var query = new GetUserProfileByIdQuery { UserProfileId = Guid.Parse(id)};
            var response = await _mediator.Send(query);
            var profile = _mapper.Map<UserProfileResponseDto>(response);

            return Ok(profile);

           
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserProfile([FromBody] CreateUserProfileDto profileInfo)
        {
            var command = _mapper.Map<CreateUserCommand>(profileInfo);
            var response = await _mediator.Send(command);
            var userProfile = _mapper.Map<UserProfileResponseDto>(response);

            return CreatedAtAction(nameof(GetUserProfileById),
                                   new { id = response.UserProfileId },
                                   userProfile);
        }

        [HttpPatch]
        [Route(ApiRoutes.UserProfile.IdRoute)]
        public async Task<IActionResult> UpdateUserProfile([FromBody] UpdateUserProfileDto profileInfo)
        {
            return Ok();
        }
    }
}

