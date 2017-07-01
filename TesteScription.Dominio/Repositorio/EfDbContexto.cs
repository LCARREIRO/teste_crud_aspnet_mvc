using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.Configuration;

using TesteScription.Dominio.Modelo;
using TesteScription.Dominio.Entidade;

namespace TesteScription.Dominio.Repositorio
{
    public class EfDbContexto : DbContext
    {
        public EfDbContexto()
            : base(ConfigurationManager.ConnectionStrings["TesteDataBase"].ConnectionString)
        {
        }
        public DbSet<ContatoModelo> CONTATOS { get; set; }
        public DbSet<UsuarioModelo> USUARIOS { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EfDbContexto>());
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}



