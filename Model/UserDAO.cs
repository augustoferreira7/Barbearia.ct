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
    internal class UserDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public UserDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public bool Insert(User prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Customer VALUES 
            (@name, @email, @telephone, @password)";

            Command.Parameters.AddWithValue("@Name", prop.Name);
            Command.Parameters.AddWithValue("@email", prop.Email);
            Command.Parameters.AddWithValue("@telephone", prop.Telephone);
            Command.Parameters.AddWithValue("@password", prop.Password);


            try
            {
                //Executa query definida acima.
                return Command.ExecuteNonQuery() == 0 ?false:true;
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
        public void Atualizar(User usuarioAtualizado)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Customer SET 
            Name = @name, 
            Email = @email, 
            Telephone = @telephone,  
            Password = @password 
            WHERE Cod = @cod";

            Command.Parameters.AddWithValue("@name", usuarioAtualizado.Name);
            Command.Parameters.AddWithValue("@email", usuarioAtualizado.Email);
            Command.Parameters.AddWithValue("@telephone", usuarioAtualizado.Telephone);
            Command.Parameters.AddWithValue("@password", usuarioAtualizado.Password);
            Command.Parameters.AddWithValue("@cod", usuarioAtualizado.CodCliente);
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

        //public void Excluir( int CodCliente)
        //{
            
        //    Command.Connection = Connect.ReturnConnection();
        //    Command.CommandText = @"DELETE FROM Customer WHERE Cod = @cod";
        //    Command.Parameters.AddWithValue("@cod", CodCliente);
        //    try
        //    {
        //        Command.ExecuteNonQuery();
        //    }
        //    catch (Exception err)
        //    {
        //        throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
        //    }
        //    finally
        //    {
        //        Connect.CloseConnection();
        //    }
        //}

        public void Delete(int cliCode)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Customer 
            WHERE Cod = @cod";
            Command.Parameters.AddWithValue("@cod", cliCode);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "cadastro do corretor do banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<User> ListAllCustomer()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Customer";

            List<User> listUsers = new List<User>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    User user = new User((int)rd["Cod"],
                        (string)rd["Name"], (string)rd["Email"],
                        (string)rd["Telephone"], (string)rd["Password"]);
                    listUsers.Add(user);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de Customer no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listUsers;
        }
        public bool TestLogin(User user)
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Customer WHERE Password = @password AND Email = @email";
            Command.Parameters.AddWithValue("@password", user.Password);
            Command.Parameters.AddWithValue("@email", user.Email);
          
            try
            {
                SqlDataReader rd = Command.ExecuteReader();
                if(rd.HasRows)
                {
                    rd.Close();
                    return true;
                }               
                
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

           return false;
        }

        internal void Update(User user)
        {
            throw new NotImplementedException();
        }

       
    }
}
