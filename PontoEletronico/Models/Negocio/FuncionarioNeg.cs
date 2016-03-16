using System.Collections.Generic;
using PontoEletronico.Models.Model;
using PontoEletronico.Models.Repositorio;

namespace PontoEletronico.Models.Negocio
{
    public class FuncionarioNeg
    {
        public void Cadastrar(FuncionarioModel funcionario)
        {
            new FuncionarioRep().Cadastrar(funcionario);
        }

        public void Atualizar(FuncionarioModel funcionario)
        {
            new FuncionarioRep().Atualizar(funcionario);
        }

        public void Deletar(string idfuncionario)
        {
            new FuncionarioRep().Deletar(idfuncionario);
        }

        public FuncionarioModel GetById(string id)
        {
            return new FuncionarioRep().GetById(id);
        }

        public int GetNextId()
        {
            return new FuncionarioRep().GetNextId();
        }

        public IEnumerable<FuncionarioModel> Listar()
        {
            return new FuncionarioRep().Listar();
        }
    }
}