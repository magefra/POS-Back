﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infraestructure.Persistences.Contexts.Configurations
{
    internal class UsersBranchOfficeConfiguration : IEntityTypeConfiguration<UsersBranchOffice>
    {
        public void Configure(EntityTypeBuilder<UsersBranchOffice> entity)
        {
            entity.HasKey(e => e.UserBranchOfficeId)
                    .HasName("PK__UsersBra__7D1E804AFFDF0EA4");

            entity.HasOne(d => d.BranchOffice)
                .WithMany(p => p.UsersBranchOffices)
                .HasForeignKey(d => d.BranchOfficeId)
                .HasConstraintName("FK__UsersBran__Branc__5DCAEF64");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UsersBranchOffices)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UsersBran__UserI__5EBF139D");
        }
    }
}
