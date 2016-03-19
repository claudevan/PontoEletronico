using PontoEletronico.Domain.Entities;
using PontoEletronico.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PontoEletronico.Infra.Data.Repositories
{
    public class MarcacaoRepository : RepositoryBase<Marcacao>, IMarcacaoRepository
    {
        public IEnumerable<Marcacao> BuscarPorFuncionario(int Id)
        {
            return Db.Marcacoes.Where(m => m.FuncionarioId == Id);
        }
    }
}
