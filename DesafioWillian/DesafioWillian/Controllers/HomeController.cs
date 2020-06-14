using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DesafioWillian.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string nome, int idade , string email)
        {
            string idadeVeif = Convert.ToString(idade);
            if (nome != null && idadeVeif != null && email != null)
            {
                Models.InsercaoUsuario.InsereUsuario(nome, idade, email);
            }

           

            return View();
        }



    }
}
