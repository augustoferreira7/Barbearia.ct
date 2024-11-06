using Barbearia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia.View
{
    public partial class ScreenRegister : Form
    {
        public ScreenRegister()
        {
            InitializeComponent();
        }

        private void txb_nomeusuario_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
          try
            {
                if(new UserDAO().Insert(new User(txbNameUser.Text, txbEmail.Text, txbTelephone.Text, txbPassword.Text)))
                    MessageBox.Show(
                    "Cadastro realizado com sucesso", "Sucesso na operação",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch(Exception error) 
            {
                MessageBox.Show(
                    error.Message, "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            
        }
    }

