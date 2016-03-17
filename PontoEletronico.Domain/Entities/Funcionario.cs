using System;
using System.Collections.Generic;

namespace PontoEletronico.Domain.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Marcacao> Marcacoes { get; set; }

        //TODO: Regra de negócio aqui
    }
}
