using InterviewApp.Common.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.DataAccess.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.GroupId);

            builder.HasAlternateKey(b => b.Email);

            builder.Property(b => b.FirstName)
                .IsRequired();

            builder.Property(b => b.LastName)
                .IsRequired();

            builder.Property(b => b.PhoneNumber)
                .IsRequired();
        }
    }
}
