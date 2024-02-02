using AutoMapper;
using SocialMedia.Api.DTOs.UserProfile;
using SocialMedia.Application.UserProfiles.Commands;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.Mapper
{
	internal class UserProfileMapper: Profile
	{
		public UserProfileMapper()
		{
			CreateMap<CreateUserProfileDto, CreateUserCommand>();
			CreateMap<UserProfile, UserProfileResponseDto>();
		}
	}
}

