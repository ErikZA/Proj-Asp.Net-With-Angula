using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using erikCorp.ITDevelop.Mvc.Models;

namespace erikCorp.ITDevelop.Mvc.Controllers
{
    [Route ("")]
    [Route ("painel-decontrole")]// conceito de URLs amigaveis varias urls direcionam para um mesmo enereço
    [Route ("painel-decontroles")]
    [Route ("painel")] // primeiro nome da rota
    [Route("api/[Controller]")]// definindo uma rota como end point de uma API  onde Controler vai ser substituido pelo nome do controlador
    public class HomeController : Controller
    {
        [Route("")] //Facilita para o buscador de rotas defoul
        [Route ("index")] // 
        public IActionResult Index() //segundo nome da rota
        {
            return View();
        }

        [Route("sobre/{id:long}/{nome}")] // restrição de atributos em rotas, se os parametros incorretps forem passados
        //a rota não é aberta
        public IActionResult sobre(long id, string name) //segundo nome da rota
        {
            return View();
        }

        [Route ("privacidade")] //sempre deixar a rota mais expressiva como a ultima do metodo
        [Route("politica-de-privacidade")]// é possivel definir varias rotas para um controlador
        public IActionResult Privacy()
        {
            return View();
        }

        [Route ("erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
