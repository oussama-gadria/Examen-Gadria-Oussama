using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamContext:DbContext
    {
        //les dbsets
        public DbSet<Biologique> Biologique { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Chimique> Chimique { get; set; }
        public DbSet<Fournisseur> Fournisseur { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Exemple> Exemples { get; set; }
        //....................
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                          Initial Catalog=oussama-gadria-produit;
                                          Integrated Security=true;
                                          MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies(); //activer lazy loading
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExempleConfiguration());
            modelBuilder.ApplyConfiguration(new FournisseurConfiguration());
            modelBuilder.ApplyConfiguration(new ProduitConfiguration());
            //...................
            //tpt 
            //tph => config
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
            .Properties<string>()
                .HaveMaxLength(50);
        }
    }
}
