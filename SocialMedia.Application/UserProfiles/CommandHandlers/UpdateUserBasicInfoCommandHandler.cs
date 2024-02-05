using System;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Application.UserProfiles.Commands;
using SocialMedia.Dal;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.UserProfiles.CommandHandlers
{
	public class UpdateUserBasicInfoCommandHandler: IRequestHandler<UpdateUserBasicInfoCommand, UserProfile>
	{
        private readonly DataContext _ctx;

		public UpdateUserBasicInfoCommandHandler(DataContext context)
		{
            _ctx = context;
		}

        public async Task<UserProfile> Handle(UpdateUserBasicInfoCommand req, CancellationToken cancellationToken)
        {
            var profile = await _ctx.UserProfiles.FirstOrDefaultAsync(profile => profile.UserProfileId == req.UserProfileId);
            var basicInfo = BasicInfo.CreateBasicInfo(
                    profile.BasicInfo.FirstName ?? req.FirstName,
                    profile.BasicInfo.LastName ?? req.LastName,
                    profile.BasicInfo.EmailAddress ?? req.EmailAddress,
                    profile.BasicInfo.Phone ?? req.Phone,
                    profile.BasicInfo.CurrentCity ?? req.CurrentCity,
                    req.DateOfBirth
                    );

            
        }
    }
}

