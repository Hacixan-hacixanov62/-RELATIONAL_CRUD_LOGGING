﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.Metrics;

namespace Domain.Configurations
{
    public class CountryConfiguration : BaseConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);

            base.Configure(builder);
        }
    }
}
