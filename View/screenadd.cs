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

namespace Barbearia
{
    public partial class Screenadd : Form
    {
        private int cod = -1;

        public Screenadd()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
              
            TxbNomeAdd.Clear();
            TxbEmailAdd.Clear();
            TxbTelephoneAdd.Clear();
            TxbPasswordAdd.Clear();
            TxbCodCli.Clear();

            BtnDeleteAdd.Visible = false;
            BtnUpadeteAdd.Visible = false;
        }
       

        private void UpdateListView()
        {
            LtvAdd.Items.Clear();

            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.ListAllCustomer();

            foreach (User user in users)
            {

                ListViewItem item = new ListViewItem(user.Name);
                item.SubItems.Add(user.CodCliente.ToString());
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Telephone);
                item.SubItems.Add(user.Password);


                LtvAdd.Items.Add(item);
            }
        }

        //private bool ValidateFields()
        //{
        //    if (TxbPasswordAdd.Text.Length == 0)
        //    {
        //        MessageBox.Show("Os campos CRECI e Senha são obrigatórios", "ATENÇÃO",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    return true;
        //}
        private bool ValidatePasswordFields()
        {
            if (string.IsNullOrWhiteSpace(TxbPasswordAdd.Text))
            {
                MessageBox.Show("A senha é obrigatória.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


       

        private void BtnDeleteAdd_Click(object sender, EventArgs e)
        {
            UserDAO userDao = new UserDAO();


            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    userDao.Delete(int.Parse(TxbCodCli.Text));
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void BtnInsertAdd_Click(object sender, EventArgs e)
        {
            //int CodCli = int.Parse(TxbCodCli.Text);
            string Name = TxbNomeAdd.Text;
            string Email = TxbEmailAdd.Text;
            string Telefone = TxbTelephoneAdd.Text;
            string Password = TxbPasswordAdd.Text;

            User user = new User(Name, Email, Telefone, Password);

            UserDAO userDAO = new UserDAO();

            userDAO.Insert(user);

            MessageBox.Show(
                
                "Nome: " + TxbNomeAdd.Text +
                "\nEmail: " + TxbEmailAdd +
                "\nTelefone: " + TxbTelephoneAdd +
                "\nSenha: " + TxbPasswordAdd);

            UpdateListView();
            ClearFields();
        }

        private void LtvAdd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;

            try
            {
                index = LtvAdd.FocusedItem.Index;
                TxbNomeAdd.Text = LtvAdd.Items[index].SubItems[0].Text;
                TxbEmailAdd.Text = LtvAdd.Items[index].SubItems[2].Text;
                TxbTelephoneAdd.Text = LtvAdd.Items[index].SubItems[3].Text;
                TxbPasswordAdd.Text = LtvAdd.Items[index].SubItems[4].Text;
                TxbCodCli.Text = (LtvAdd.Items[index].SubItems[1].Text);

                BtnDeleteAdd.Visible = true;
                BtnUpadeteAdd.Visible = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpadeteAdd_Click(object sender, EventArgs e)
        {
            if (ValidatePasswordFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    new UserDAO().Atualizar(new User(
                        int.Parse(TxbCodCli.Text),
                        TxbNomeAdd.Text,
                        TxbEmailAdd.Text,
                        TxbTelephoneAdd.Text,
                        TxbPasswordAdd.Text));
                    MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

       

        private void screenadd_Load_1(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void BtnClearAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void LtvAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
