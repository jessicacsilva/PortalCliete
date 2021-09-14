using Microsoft.AspNetCore.Mvc;
using PortalCadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalCadastroCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Consulta()
        {
            List<ClienteModel> clienteModels = ClienteModel.RetornaListaCliente();

            return View(clienteModels);
        }
    }
}
