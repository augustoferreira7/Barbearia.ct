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
    public partial class ScreenBarba : Form
    {
        public ScreenBarba()
        {
            InitializeComponent();
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_agendamento1 = new ScreenAgendamento();

            this.Visible = false;

            tela_agendamento1.ShowDialog();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_agendamento2 = new ScreenAgendamento();

            this.Visible = false;

            tela_agendamento2.ShowDialog();
        }

        private void btnBurst_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_agendamento3 = new ScreenAgendamento();

            this.Visible = false;

            tela_agendamento3.ShowDialog();
        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_agendamento4 = new ScreenAgendamento();

            this.Visible = false;

            tela_agendamento4.ShowDialog();
        }

        private void btnMullet_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_agendamento5 = new ScreenAgendamento();

            this.Visible = false;

            tela_agendamento5.ShowDialog();
        }

        private void btnSamurai_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_agendamento6 = new ScreenAgendamento();

            this.Visible = false;

            tela_agendamento6.ShowDialog();
        }

        private void btnMenuBarba_Click(object sender, EventArgs e)
        {
            ScreenPrincipal tela_Principal = new ScreenPrincipal();

            this.Visible = false;

            tela_Principal.ShowDialog();
        }

        private void btnCortesBarba_Click(object sender, EventArgs e)
        {
            ScreenCortes tela_Cortes = new ScreenCortes();

            this.Visible = false;

            tela_Cortes.ShowDialog();
        }
    }
}
