using System;
using AutoMapper;
using MediatR;
using SocialMedia.Application.UserProfiles.Commands;
using SocialMedia.Dal;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.UserProfiles.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
    {
        private readonly DataContext _ctx;


        public CreateUserCommandHandler(DataContext context)
        {
            _ctx = context;
        }
        public async Task<UserProfile> Handle(CreateUserCommand req, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.CreateBasicInfo(req.FirstName, req.LastName, req.EmailAddress,
                req.Phone, req.CurrentCity, req.DateOfBirth);

            var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);

            _ctx.UserProfiles.Add(userProfile);
            await _ctx.SaveChangesAsync();

            return userProfile;
        }
    }
}

