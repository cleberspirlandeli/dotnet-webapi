using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ClienteModels
    {
        public ClienteModels(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }
    }
}
