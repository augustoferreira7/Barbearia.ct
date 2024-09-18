using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;

namespace Barbearia
{
    public partial class ScreenRegister : Form
    {
        public ScreenRegister()
        {
            InitializeComponent();
        }

        

        

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_ja_cds_Click(object sender, EventArgs e)
        {
            txb_UserCd.Text = string.Empty; // Limpa o campos do usuário
            txb_PassowordCd.Text = string.Empty; // Limpa o campo da senha
            txb_UserCd.Focus(); // Coloca o foco no campo de usuário
            ScreenRegister principalScreen = new ScreenRegister();
            this.Visible = false; // Esconder a tela de login
            principalScreen.ShowDialog(); // Abre a tela preincipal
            this.Visible = true; // Volta a mostrar a tela login

            MessageBox.Show("Cadastrado com sucesso");
            this.Close();
            
            
        }

        private void txb_senhaCadastro(object sender, EventArgs e)
        {

        }
    }
    
}
