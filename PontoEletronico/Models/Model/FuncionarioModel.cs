using System;
using System.ComponentModel.DataAnnotations;

namespace PontoEletronico.Models.Model
{
    public class FuncionarioModel
    {
        [Required]
        public string Id { get; set; }
        [Required, StringLength(10)]
        public string Nome { get; set; }
        [Required, StringLength(8)]
        public string Senha { get; set; }
        public string Foto { get; set; }

    }
}