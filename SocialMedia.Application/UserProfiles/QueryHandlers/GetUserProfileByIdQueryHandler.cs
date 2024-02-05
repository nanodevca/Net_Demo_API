using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Application.UserProfiles.Queries;
using SocialMedia.Dal;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.UserProfiles.QueryHandlers
{
	public class GetUserProfileByIdQueryHandler: IRequestHandler<GetUserProfileByIdQuery, UserProfile>
	{
        private readonly DataContext _ctx;
		public GetUserProfileByIdQueryHandler(DataContext context)
		{
            _ctx = context;
		}

        public async Task<UserProfile> Handle(GetUserProfileByIdQuery req, CancellationToken cancellationToken)
        {
            return await _ctx.UserProfiles.FirstOrDefaultAsync(profile => profile.UserProfileId == req.UserProfileId);
        }
    }
}

