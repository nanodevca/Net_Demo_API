using System;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Api.DTOs.UserProfile
{
	public class UserProfileResponseDto
	{
        public Guid UserProfileId { get; set; }

        public BasicInfo BasicInfoDto { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime LastModified { get; set; }
    }
}

