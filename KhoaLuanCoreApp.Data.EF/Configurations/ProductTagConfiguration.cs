using KhoaLuanCoreApp.Data.EF.Extentions;
using KhoaLuanCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KhoaLuanCoreApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired()
                .HasColumnType("varchar(50)");
        }
    }
}
