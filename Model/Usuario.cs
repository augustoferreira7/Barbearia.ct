using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Model
{
    internal class Usuario
    {
        
            public int CodCliente { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Telephone { get; set; }
            public string Password { get; private set; }

            public Usuario(string name, string email, string telephone, string password)
            {
                Name = name;
                Email = email;
                Telephone = telephone;
                Password = password;
            }
    }
}

