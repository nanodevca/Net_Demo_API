using System;
using MediatR;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Application.UserProfiles.Commands
{
	public class UpdateUserBasicInfoCommand: IRequest<UserProfile>
	{
        public Guid UserProfileId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Phone { get; set; }

        public string CurrentCity { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}

