using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TesteScription.Dominio.Modelo;

namespace TesteScription.Dominio.Entidade
{
    public class ContatoEntidade : EntityTypeConfiguration<ContatoModelo>
    {

        public ContatoEntidade()
        {
            ToTable("TB_CONTATOS");

            HasKey(c => c.ID)
                .HasEntitySetName("ID");

            Property(c => c.Nome)
                .HasColumnName("NM_CONTATO")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.Telefone)
                .HasColumnName("NR_TELEFONE")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnName("DS_EMAIL")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
