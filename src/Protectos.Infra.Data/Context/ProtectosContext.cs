using Protectos.Domain.Entities.Administradoras;
using Protectos.Infra.Data.Mappings.Administradoras;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Protectos.Infra.Data.Context
{
    public class ProtectosContext : DbContext
    {
        public ProtectosContext() : base("DefaultConnection")
        {            
        }   
          
        public virtual DbSet<Administradora> Administradora { get; set; }
        public virtual DbSet<AdministradoraEmail> AdministradoraEmail { get; set; }
        public virtual DbSet<AdministradoraEndereco> AdministradoraEndereco { get; set; }
        public virtual DbSet<AdministradoraTelefone> AdministradoraTelefone { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();         

            modelBuilder.Configurations.Add(new AdministradoraMapping());
            modelBuilder.Configurations.Add(new AdministradoraEnderecoMapping());
            modelBuilder.Configurations.Add(new AdministradoraEmailMapping());
            modelBuilder.Configurations.Add(new AdministradoraTelefoneMapping());           

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
