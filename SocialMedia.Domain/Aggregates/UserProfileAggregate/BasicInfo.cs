using System;
namespace SocialMedia.Domain.Aggregates.UserProfileAggregate
{
	public class BasicInfo
	{
		private BasicInfo()
		{

		}

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public string EmailAddress { get; private set; }

		public string Phone { get; private set; }

		public string CurrentCity { get; private set; }

		public DateTime DateOfBirth { get; private set; }

		// Factory methods

        public static BasicInfo CreateBasicInfo(string firstName, string lastName, string emailAddress, string phone, string currentCity, DateTime dateOfBirth)
		{
            // TODO: Add validation, error handling strategies, error notification strategies

            var basicInfo = new BasicInfo
			{
				FirstName = firstName,
				LastName = lastName,
				EmailAddress = emailAddress,
				Phone = phone,
				CurrentCity = currentCity,
				DateOfBirth = dateOfBirth
			};

			return basicInfo;
		}
	}
}

