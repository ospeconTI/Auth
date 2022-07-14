using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSPeConTI.Auth.Services.Domain.Entities;

namespace OSPeConTI.Auth.Services.Infrastructure.EntityConfigurations
{
    class TipoMaterialEntityTypeConfiguration : IEntityTypeConfiguration<TipoMaterial>
    {
        public void Configure(EntityTypeBuilder<TipoMaterial> TipoMaterialConfiguration)
        {
            TipoMaterialConfiguration.ToTable("TipoMateriales", CatalogoMaterialesContext.DEFAULT_SCHEMA);

            TipoMaterialConfiguration.HasKey(o => o.Id);

            TipoMaterialConfiguration.Ignore(b => b.DomainEvents);

        }
    }
}