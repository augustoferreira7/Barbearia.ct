using MarqueSeuImovel.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        public void Atualizar(Usuario usuarioAtualizado)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Usuarios SET 
            Name = @name, 
            Email = @email, 
            Telephone = @tel,  
            Password = @password 
            WHERE CodCliente = @codcliente";
          
            Command.Parameters.AddWithValue("@name", usuarioAtualizado.Name);
            Command.Parameters.AddWithValue("@email", usuarioAtualizado.Email);        
            Command.Parameters.AddWithValue("@telephone", usuarioAtualizado.Telephone);
            Command.Parameters.AddWithValue("@password", usuarioAtualizado.Password);
            Command.Parameters.AddWithValue("@codcliente", usuarioAtualizado.CodCliente);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int codCliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Usuario WHERE CodCliente = @codcliente";
            Command.Parameters.AddWithValue("@codcliente", codCliente);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Usuario> ListAllUsuarios()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Usuarios";

            List<Usuario> listUsers = new List<Usuario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario user = new Usuario((int)rd["CodCliente"],
                        (string)rd["Name"], (string)rd["Email"],
                        (string)rd["Telephone"], (string)rd["Password"]);
                    listUsers.Add(user);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listUsers;
        }
    }
}
