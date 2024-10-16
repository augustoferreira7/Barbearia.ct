using MarqueSeuImovel.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Model
{
    internal class UsuarioDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public UsuarioDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Usuario prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Property VALUES 
            (@name, @email, @telephone, @password)";

            Command.Parameters.AddWithValue("@Name", prop.Name);
            Command.Parameters.AddWithValue("@email", prop.Email);
            Command.Parameters.AddWithValue("@telephone", prop.Telephone);
            Command.Parameters.AddWithValue("@password", prop.Password);


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "usuario no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
    }
}
