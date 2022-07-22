using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSPeConTI.Auth.Services.Domain.Entities;

namespace OSPeConTI.Auth.Services.Infrastructure.EntityConfigurations
{
    class UsuarioProfilelEntityTypeConfiguration : IEntityTypeConfiguration<UsuarioProfile>
    {
        public void Configure(EntityTypeBuilder<UsuarioProfile> conf)
        {
            conf.ToTable("UsuarioProfile", AuthContext.DEFAULT_SCHEMA);

            conf.HasKey(o => o.Id);

            conf.Ignore(b => b.DomainEvents);

        }
    }
}