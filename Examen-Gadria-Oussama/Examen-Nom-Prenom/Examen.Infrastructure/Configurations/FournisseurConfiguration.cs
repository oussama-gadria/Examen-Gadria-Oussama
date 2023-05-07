using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class FournisseurConfiguration : IEntityTypeConfiguration<Fournisseur>
    {
        public void Configure(EntityTypeBuilder<Fournisseur> builder)
        {
            builder.HasMany(f => f.Produits)
                .WithMany(p => p.Fournisseurs)
                .UsingEntity(j => j.ToTable("Facture"));
        }
    }
}
