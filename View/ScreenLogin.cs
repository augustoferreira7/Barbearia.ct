using Barbearia.Model;
using Barbearia.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia
{
    public partial class ScreenLogin : Form
    {
        public ScreenLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            

            User user = new User(txbEmailUser.Text, txbPasswordUser.Text);

            if(new UserDAO().TestLogin(user))
            {
               
                this.Visible = false;
                new ScreenPrincipal().ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Email ou Senha Incorretos", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private void txb_nomeusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new ScreenRegister().ShowDialog();
        }
    }
}
