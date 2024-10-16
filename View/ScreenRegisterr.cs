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
    public partial class ScreenRegisterr : Form
    {
        public ScreenRegisterr()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            ScreenPrincipal tela_Principal = new ScreenPrincipal();
            this.Visible = false;
            tela_Principal.ShowDialog();

            MessageBox.Show(
               "Nome: " + txb_nomeusuario.Text +
               "\nCadastro Comcluido com sucesso");
        }

        private void txb_nomeusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
