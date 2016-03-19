using PontoEletronico.Domain.Entities;
using System.Collections.Generic;

namespace PontoEletronico.Domain.Interfaces
{
    public interface IMarcacaoRepository :IRepositoryBase<Marcacao>
    {
        IEnumerable<Marcacao> BuscarPorFuncionario(int Id);
    }
}
