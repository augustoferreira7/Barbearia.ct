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
    public partial class ScreenCortes : Form
    {
        public ScreenCortes()
        {
            InitializeComponent();
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento.ShowDialog();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento1 = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento1.ShowDialog();
        }

        private void btnLowTaper_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento2 = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento2.ShowDialog();
        }

        private void btnBurst_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento3 = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento3.ShowDialog();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento4 = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento4.ShowDialog();
        }

        private void btnSamurai_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento5 = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento5.ShowDialog();
        }

        private void btnMullet_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento6 = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento6.ShowDialog();
        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            ScreenAgendamento tela_Agendamento7 = new ScreenAgendamento();

            this.Visible = false;

            tela_Agendamento7.ShowDialog();
        }

        private void lblLowTaper_Click(object sender, EventArgs e)
        {

        }

        private void lblAmericano_Click(object sender, EventArgs e)
        {

        }

        private void lblMullet_Click(object sender, EventArgs e)
        {

        }

        private void lblSamurai_Click(object sender, EventArgs e)
        {

        }

        private void lblDMullet_Click(object sender, EventArgs e)
        {

        }

        private void lblDSamurai_Click(object sender, EventArgs e)
        {

        }

        private void LblDLowTaper_Click(object sender, EventArgs e)
        {

        }

        private void lblDAmericano_Click(object sender, EventArgs e)
        {

        }

        private void lblDHigh_Click(object sender, EventArgs e)
        {

        }

        private void lblDBurst_Click(object sender, EventArgs e)
        {

        }

        private void lblHiigh_Click(object sender, EventArgs e)
        {

        }

        private void lblBurst_Click(object sender, EventArgs e)
        {

        }

        private void lblDLow_Click(object sender, EventArgs e)
        {

        }

        private void lblLow_Click(object sender, EventArgs e)
        {

        }

        private void lblDeMid_Click(object sender, EventArgs e)
        {

        }

        private void lblMid_Click(object sender, EventArgs e)
        {

        }

        private void lblDescriçãoCorte_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ScreenPrincipal tela_Principal = new ScreenPrincipal();

            this.Visible = false;

            tela_Principal.ShowDialog();
        }

        private void btnBarbaCorte_Click(object sender, EventArgs e)
        {
            ScreenBarba tela_Barba = new ScreenBarba();

            this.Visible = false;

            tela_Barba.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ScreenRegisterr tela_Registro1 = new ScreenRegisterr();

            this.Visible = false;

            tela_Registro1.ShowDialog();
        }
    }
}
