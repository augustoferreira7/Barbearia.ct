using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.controller
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3022501BARBEARIA";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Passaword = "aluno";

        public Connection() {
            string stringConnection = @"Data Source = " + Server + "; Initial Catalog = " + DataBase +
            "; User Id =" + Username + "; Passaword =" + Passaword + "; Encrypt = false";
            //string stringConnection = @"Data Source ="
            //Environment.MachineName + @"/SQLEXPRESS;
            //Initial Catalog = " DataBase + ";
            //Integrated Security=true";

            con = new SqlConnection(stringConnection);
            con.Open(); // Abrir a conexão com o banco
        }

        //Tenta fechar a conexão com o banco 

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            con.Close();
            
        }
        // Rtorna a conexão que foi aberta 

        public SqlConnection ReturnConnection()
        {
            return con;
        }

    }
}
