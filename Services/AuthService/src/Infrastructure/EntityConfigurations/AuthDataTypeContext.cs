using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OSPeConTI.Auth.Services.Domain.Entities;

namespace OSPeConTI.Auth.Services.Infrastructure.EntityConfigurations
{
    class AuthDataEntityTypeConfiguration : IEntityTypeConfiguration<AuthData>
    {
        public void Configure(EntityTypeBuilder<AuthData> conf)
        {
            conf.ToTable("AuthData", AuthContext.DEFAULT_SCHEMA);

            conf.HasKey(o => o.Id);

            conf.Ignore(b => b.DomainEvents);
        }
    }
}