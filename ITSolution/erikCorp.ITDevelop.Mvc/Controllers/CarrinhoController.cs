using erikCorp.ITDevelop.Domain.Carrinho;
using erikCorp.ITDevelop.Mvc.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace erikCorp.ITDevelop.Mvc.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>();

            //populando
            for (int i = 1; i <= 10; i++)
            {
                var n = i < 10 ? "0" + i : i + "";
                produtos.Add(new Produto
                {
                    nome = "PROD-" + n,
                    valor = 3.3m * i,
                    temEstoque = true,
                    data = DateTime.Now
                });
            }

            var model = new CarrinhoViewModel
            {
                //produtos = produtos,
                //valoTotal = produtos.Sum(p => p.valor),
                //mensagem = "Obrigado por comprar"
                valoTotal = 22M,//se passa os parametros incorretos
                mensagem = "ah"
            };

            return RedirectToAction("CheckOut", model);// redireciona para validar os dados do formulario
        }

        //Este metodo valida o formulario, caso algum campo seja desrespeitado o form é invalido
        public IActionResult CheckOut(CarrinhoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["SemErro"] = "OPS";
                ModelState.AddModelError(errorMessage: "O modelo esta invalido", key: "erro");
            }
            else
            {
                ViewData["SemErro"] = "Modelo OK";
            }
            return View(model);
        }
    }
}