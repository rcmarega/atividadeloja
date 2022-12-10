using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoLojaGeek
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            FrmSplash splash = new FrmSplash();
            splash.Show();
            Thread.Sleep(3000);
            splash.Close();
            this.txtLogin.Focus();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtLogin.Text;
            senha = txtSenha.Text;
            if (login == "admin" && senha == "admin")
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Suas credenciais não foram validadas!! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                this.txtLogin.Focus();
            }

        }
    }
}
