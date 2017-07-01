using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

using TesteScription.Dominio.Modelo;

namespace TesteScription.Dominio.Entidade
{
    public class UsuarioMap : EntityTypeConfiguration<UsuarioModelo>
    {
        public UsuarioMap()
        {
            ToTable("TB_USUARIOS");

            HasKey(c => c.ID)
                .HasEntitySetName("ID");

            Property(c => c.Login)
                .HasColumnName("NM_USUARIO")
                .HasColumnType("Varchar")
                .HasMaxLength(10)
                .IsRequired();

            Property(c => c.Senha)
                .HasColumnName("DS_SENHA")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();            
        }
    }
}
