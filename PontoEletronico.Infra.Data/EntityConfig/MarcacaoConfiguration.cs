using PontoEletronico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEletronico.Infra.Data.EntityConfig
{
    public class MarcacaoConfiguration : EntityTypeConfiguration<Marcacao>
    {
        public MarcacaoConfiguration()
        {
            HasKey(m => m.MarcacaoId);

            //Referência tabela de Funcionários
            HasRequired(m => m.Funcionario)
                .WithMany()
                .HasForeignKey(m => m.FuncionarioId);
        }
    }
}
