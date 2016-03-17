using System;

namespace PontoEletronico.Domain.Entities
{
    public class Marcacao
    {
        public int MarcacaoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

    }
}
