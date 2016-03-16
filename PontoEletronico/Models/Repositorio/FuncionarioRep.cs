using System.Collections.Generic;
using System.Linq;
using PontoEletronico.Models.Model;

namespace PontoEletronico.Models.Repositorio
{
    public class FuncionarioRep
    {
        private static List<FuncionarioModel> _listFuncionarios;


        public FuncionarioRep()
        {
            if(_listFuncionarios == null)
            {
                _listFuncionarios = new List<FuncionarioModel>();
            }
        }

        public int GetNextId()
        {
            return _listFuncionarios.Count + 1;
        }

        public FuncionarioModel GetById(string id)
        {
            return _listFuncionarios.SingleOrDefault(x => x.Id == id);
        }

        public void Cadastrar(FuncionarioModel funcionario)
        {
            var id = 1;


            while (_listFuncionarios.Any(x => x.Id == id.ToString()))
                id++;

            _listFuncionarios.Add(funcionario);
        }

        public void Atualizar(FuncionarioModel funcionario)
        {
            var funcionarioDadoAnterior = GetById(funcionario.Id);
            if(funcionarioDadoAnterior != null)
            {
                foreach(var propertyInfo in typeof(FuncionarioModel)
                    .GetProperties().Where(x => x.Name != "Id"))
                {
                    propertyInfo.SetValue(funcionarioDadoAnterior, propertyInfo.GetValue(funcionario));
                }
            }
        }

        public void Deletar(string id)
        {
            var obj = GetById(id);

            _listFuncionarios.Remove(obj);
        }

        public IEnumerable<FuncionarioModel> Listar()
        {
            return _listFuncionarios;
        }
    }
}