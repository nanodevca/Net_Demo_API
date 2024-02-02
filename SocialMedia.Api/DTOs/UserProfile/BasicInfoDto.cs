using System;
namespace SocialMedia.Api.DTOs.UserProfile
{
	public class BasicInfoDto
	{
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Phone { get; set; }

        public string CurrentCity { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}

