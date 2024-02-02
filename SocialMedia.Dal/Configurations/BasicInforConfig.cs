using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Dal.Configurations
{
	public class BasicInforConfig: IEntityTypeConfiguration<BasicInfo>
	{
        public void Configure(EntityTypeBuilder<BasicInfo> builder)
        {
        }
    }
}

