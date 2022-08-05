﻿using DCMS.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DCMS.Infrastructure.Mapping.Main
{

    public partial class ProductTierPricePlanMap : IEntityTypeConfiguration<ProductTierPricePlan>
    {
        //public ProductTierPricePlanMap()
        //{
        //    ToTable("ProductTierPricePlans");
        //    HasKey(o => o.Id);

        //}

        public void Configure(EntityTypeBuilder<ProductTierPricePlan> builder)
        {
            builder.ToTable("ProductTierPricePlans");
            builder.HasKey(b => b.Id);
           
        }
    }


}

