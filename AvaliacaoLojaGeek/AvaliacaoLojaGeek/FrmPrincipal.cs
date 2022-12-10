using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoLojaGeek
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxProduto_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.Show();
        }

        private void pbxVenda_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenda venda = new FrmVenda();
            venda.Show();
        }
    }
}
