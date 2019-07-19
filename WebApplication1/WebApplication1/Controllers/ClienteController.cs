using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private static List<ClienteModels> clientes = new List<ClienteModels>();

        [HttpGet]
        public List<ClienteModels> Get()
        {
            return clientes;
        }

        [HttpPost]
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                clientes.Add(new ClienteModels(nome));
        }

        [HttpPut]
        public void Put(string nome)
        {
            //clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
            int position = clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome)));
            Console.WriteLine(position);
        }

        [HttpDelete]
        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}
