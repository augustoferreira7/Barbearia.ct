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
    public partial class ScreenPrincipal : Form
    {
        public ScreenPrincipal()
        {
            InitializeComponent();
        }

        private void ScreenLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCabelo_Click(object sender, EventArgs e)
        {
            ScreenCortes tela_Cortes = new ScreenCortes();

            this.Visible = false;

            tela_Cortes.ShowDialog();
        }

        private void btnBarba_Click(object sender, EventArgs e)
        {
            ScreenBarba tela_Barba = new ScreenBarba();

            this.Visible = false;

            tela_Barba.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ScreenRegisterr tela_Registro2 = new ScreenRegisterr();

            this.Visible = false;

            tela_Registro2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
