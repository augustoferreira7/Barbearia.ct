using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Model
{
    internal class ContaCliente
    {
        public int CodCliente {  get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Password { get; set; }

        public ContaCliente(string nome, string email, int telefone, string password) 
        { 
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Password = password;
        }


    }
}
