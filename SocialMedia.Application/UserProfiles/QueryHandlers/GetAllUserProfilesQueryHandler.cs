using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Application.UserProfiles.Queries;
using SocialMedia.Dal;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.UserProfiles.QueryHandlers
{
    public class GetAllUserProfilesQueryHandler : IRequestHandler<GetAllUserProfilesQuery, IEnumerable<UserProfile>>
    {
        private readonly DataContext _ctx;
        public GetAllUserProfilesQueryHandler(DataContext context)
        {
            _ctx = context;
        }

        public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfilesQuery req, CancellationToken cancellationToken)
        {
            return await _ctx.UserProfiles.ToListAsync();
        }

    }
}
