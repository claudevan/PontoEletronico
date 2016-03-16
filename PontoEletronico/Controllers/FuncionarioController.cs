using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontoEletronico.Models.Model;
using PontoEletronico.Models.Negocio;

namespace PontoEletronico.Controllers
{
    public class FuncionarioController : Controller
    {
        [Route("Funcionario", Name="Funcionario")]
        public ActionResult Funcionario()
        {
            ViewBag.Id = new FuncionarioNeg().GetNextId();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(FuncionarioModel funcionario)
        {
           if(ModelState.IsValid)
            {
                new FuncionarioNeg().Cadastrar(funcionario);

                return View("Funcionario");
            }
           else
            {
                return View("Funcionario");
            }
            //return RedirectToAction("Funcionario", "Funcionario");
        }

        public ActionResult GetFuncionario(string Id)
        {
            FuncionarioModel funcionario = new FuncionarioNeg().GetById(Id);

            return Json(funcionario);
        }
    }
}