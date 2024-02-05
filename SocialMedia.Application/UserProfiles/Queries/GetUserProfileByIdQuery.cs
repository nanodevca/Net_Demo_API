using System;
using MediatR;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.UserProfiles.Queries
{
	public class GetUserProfileByIdQuery: IRequest<UserProfile>
	{
		public Guid UserProfileId { get; set; }
	}
}

