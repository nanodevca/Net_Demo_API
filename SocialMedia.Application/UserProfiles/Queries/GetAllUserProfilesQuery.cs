using System;
using MediatR;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.UserProfiles.Queries
{
	public class GetAllUserProfilesQuery: IRequest<IEnumerable<UserProfile>>
	{
		
	}
}

