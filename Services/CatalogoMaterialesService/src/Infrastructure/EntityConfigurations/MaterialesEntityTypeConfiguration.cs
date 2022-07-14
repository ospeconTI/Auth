using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSPeConTI.Auth.Services.Domain.Entities;

namespace OSPeConTI.Auth.Services.Infrastructure.EntityConfigurations
{
    class MaterialesEntityTypeConfiguration : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> MaterialesConfiguration)
        {
            MaterialesConfiguration.ToTable("Materiales", CatalogoMaterialesContext.DEFAULT_SCHEMA);

            MaterialesConfiguration.HasKey(o => o.Id);

            MaterialesConfiguration.Ignore(b => b.DomainEvents);

            MaterialesConfiguration.Property(b => b.Costo).HasPrecision(18, 2);

        }
    }
}