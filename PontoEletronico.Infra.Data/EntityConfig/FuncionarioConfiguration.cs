using PontoEletronico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PontoEletronico.Infra.Data.EntityConfig
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            HasKey(f => f.FuncionarioId);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
