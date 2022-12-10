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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente cliente = new Cliente();
                cliente.Inserir(txtNome.Text, txtCpf.Text, txtData_nascimento.Text, txtCelular.Text, txtCep.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text);
                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> cli = cliente.listacliente();
                dgvCliente.DataSource = cli;
                txtNome.Text = "";
                txtCpf.Text = "";
                txtData_nascimento.Text = "";
                txtCelular.Text = "";
                txtCep.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor digite um ID!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
            else
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Localizar(Id);
                txtNome.Text = cliente.nome;
                txtCpf.Text = cliente.cpf;
                txtData_nascimento.Text = cliente.data_nascimento;
                txtCelular.Text = cliente.celular;
                txtCep.Text = cliente.cep;
                txtEndereco.Text = cliente.endereco;
                txtBairro.Text = cliente.bairro;
                txtCidade.Text = cliente.cidade;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Atualizar(Id, txtNome.Text, txtCpf.Text, txtData_nascimento.Text, txtCelular.Text, txtCep.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text);
                MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> clientes = cliente.listacliente();
                dgvCliente.DataSource = clientes;
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtData_nascimento.Text = "";
                txtCelular.Text = "";
                txtCep.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                this.txtNome.Focus();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Excluir(Id);
                MessageBox.Show("Cliente excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> clientes = cliente.listacliente();
                dgvCliente.DataSource = clientes;
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtData_nascimento.Text = "";
                txtCelular.Text = "";
                txtCep.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                this.txtNome.Focus();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                row.Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCpf.Text = row.Cells[2].Value.ToString();
                txtData_nascimento.Text = row.Cells[3].Value.ToString();
                txtCelular.Text = row.Cells[4].Value.ToString();
                txtCep.Text = row.Cells[5].Value.ToString();
                txtEndereco.Text = row.Cells[6].Value.ToString();
                txtBairro.Text = row.Cells[7].Value.ToString();
                txtCidade.Text = row.Cells[8].Value.ToString();


            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
