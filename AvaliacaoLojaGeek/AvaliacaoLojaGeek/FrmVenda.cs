using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoLojaGeek
{
    public partial class FrmVenda : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\source\repos\AvaliacaoLojaGeek\AvaliacaoLojaGeek\DbLojaGeek.mdf;Integrated Security=True");

        public FrmVenda()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaCbxCliente()
        {
            string cli = "SELECT * FROM cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "cpf";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }


        public void CarregaCbxProduto()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string pro = "SELECT Id,nome FROM Produto";
            SqlCommand cmd = new SqlCommand(pro, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            con.Close();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            if (cbxCliente.DisplayMember == "")
            {
                cbxProduto.Enabled = false;
                txtIdProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;
                dgvVenda.Enabled = false;
                btnNovoItem.Enabled = false;
                btnEditarItem.Enabled = false;
                btnExcluirItem.Enabled = false;
                txtTotal.Enabled = false;
                btnFinalizarPedido.Enabled = false;
            }
            CarregaCbxCliente();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            cbxProduto.Enabled = true;
            CarregaCbxProduto();
            txtIdProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            txtTotal.Enabled = true;
            btnAtualizarPedido.Enabled = true;
            btnFinalizarPedido.Enabled = true;
            btnFinalizarVenda.Enabled = true;
            btnEditarItem.Enabled = true;
            btnNovoItem.Enabled = true;
            btnExcluirItem.Enabled = true;
            dgvVenda.Columns.Add("ID", "ID");
            dgvVenda.Columns.Add("Produto", "Produto");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("Valor", "Valor");
            dgvVenda.Columns.Add("Total", "Total");
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Produto WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtValor.Text = dr["preco"].ToString();
                txtIdProduto.Text = dr["Id"].ToString();
                txtQuantidade.Focus();
                dr.Close();
                con.Close();
            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Quantidade_Produto", con);
            cmd2.Parameters.AddWithValue("@Id", txtIdProduto.Text);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblEstoque.Text = dr2["quantidade"].ToString();
            }
            dr2.Close();
            con.Close();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                if (txtIdProduto.Text == Convert.ToString(dr.Cells[0].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvVenda);
                item.Cells[0].Value = txtIdProduto.Text;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txtQuantidade.Text;
                item.Cells[3].Value = txtValor.Text;
                item.Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvVenda.Rows.Add(item);
                txtIdProduto.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                cbxProduto.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvVenda.Rows)
                    soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotal.Text = Convert.ToString(soma);
            }
            else
            {
                MessageBox.Show("Produto já cadastrado!", "Produto repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvVenda.Rows[e.RowIndex];
            cbxProduto.Text = row.Cells[1].Value.ToString();
            txtIdProduto.Text = row.Cells[0].Value.ToString();
            txtQuantidade.Text = row.Cells[2].Value.ToString();
            txtValor.Text = row.Cells[3].Value.ToString();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows[linha].Cells[0].Value = txtIdProduto.Text;
            dgvVenda.Rows[linha].Cells[1].Value = cbxProduto.Text;
            dgvVenda.Rows[linha].Cells[2].Value = txtQuantidade.Text;
            dgvVenda.Rows[linha].Cells[3].Value = txtValor.Text;
            dgvVenda.Rows[linha].Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
            cbxProduto.Text = "";
            txtIdProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtTotal.Text = Convert.ToString(soma);
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows.RemoveAt(linha);
            dgvVenda.Refresh();
            cbxProduto.Text = "";
            txtIdProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtTotal.Text = Convert.ToString(soma);
        }


        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Quantidade_Produto", con);
            cmd.Parameters.AddWithValue("@Id", txtIdProduto.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            int valor1 = 0;
            bool conversaoSucedida = int.TryParse(txtQuantidade.Text, out valor1);
            if (dr.Read())
            {
                int valor2 = Convert.ToInt32(dr["quantidade"].ToString());
                if (valor1 > valor2)
                {
                    MessageBox.Show("Não tem quantidade suficiente!", "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantidade.Text = "";
                    txtQuantidade.Focus();
                }
            }
            con.Close();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("InserirVenda", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_pessoa", SqlDbType.NChar).Value = cbxCliente.SelectedValue;
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text);
            cmd.Parameters.AddWithValue("@data_venda", SqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.AddWithValue("@situacao", SqlDbType.NChar).Value = "Aberta";
            cmd.ExecuteNonQuery();
            string idvenda = "SELECT IDENT_CURRENT('Venda') AS id_venda";
            SqlCommand cmd2 = new SqlCommand(idvenda, con);
            Int32 idvenda2 = Convert.ToInt32(cmd2.ExecuteScalar());
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand cmditens = new SqlCommand("InserirItensPedidos", con);
                cmditens.CommandType = CommandType.StoredProcedure;
                cmditens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = idvenda2;
                cmditens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                cmditens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                cmditens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                cmditens.ExecuteNonQuery();
            }
            con.Close();
            dgvVenda.Rows.Clear();
            dgvVenda.Refresh();
            txtTotal.Text = "";
            MessageBox.Show("Pedido realizado com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLocalizarVenda_Click(object sender, EventArgs e)
        {
            CarregaCbxProduto();
            txtTotal.Text = "";
            dgvVenda.Columns.Clear();
            dgvVenda.Rows.Clear();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("VendaId", con);
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string venda = dt.Rows[0]["situacao"].ToString();
                int linhas = dt.Rows.Count;
                if (dt.Rows.Count > 0 && venda == "Aberta  ")
                {
                    con.Close();
                    con.Open();
                    SqlCommand pedido = new SqlCommand("LocalizarPedido", con);
                    pedido.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
                    pedido.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ped = new SqlDataAdapter(pedido);
                    DataTable dtped = new DataTable();
                    ped.Fill(dtped);
                    int linhasped = dtped.Rows.Count;
                    if (dtped.Rows.Count > 0)
                    {
                        cbxCliente.Enabled = true;
                        cbxCliente.Text = "";
                        cbxCliente.Text = dtped.Rows[0]["nomecliente"].ToString();
                        txtTotal.Text = dtped.Rows[0]["total"].ToString();
                        cbxProduto.Enabled = true;
                        txtQuantidade.Enabled = true;
                        txtValor.Enabled = true;
                        btnNovoItem.Enabled = true;
                        btnEditarItem.Enabled = true;
                        btnExcluirItem.Enabled = true;
                        btnFinalizarVenda.Enabled = true;
                        btnNovoPedido.Enabled = false;
                        btnAtualizarPedido.Enabled = true;
                        dgvVenda.Columns.Add("ID", "ID");
                        dgvVenda.Columns.Add("Produto", "Produto");
                        dgvVenda.Columns.Add("Quantidade", "Quantidade");
                        dgvVenda.Columns.Add("Valor", "Valor");
                        dgvVenda.Columns.Add("Total", "Total");
                        for (int i = 0; i < linhasped; i++)
                        {
                            DataGridViewRow itemped = new DataGridViewRow();
                            itemped.CreateCells(dgvVenda);
                            itemped.Cells[0].Value = dtped.Rows[i]["id_produto"].ToString();
                            itemped.Cells[1].Value = dtped.Rows[i]["nomeproduto"].ToString();
                            itemped.Cells[2].Value = dtped.Rows[i]["quantidade"].ToString();
                            itemped.Cells[3].Value = dtped.Rows[i]["valor_unitario"].ToString();
                            itemped.Cells[4].Value = dtped.Rows[i]["valor_total"].ToString();
                            dgvVenda.Rows.Add(itemped);
                        }
                    }
                }
                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand lvenda = new SqlCommand("LocalizarVendido", con);
                    lvenda.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
                    lvenda.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ven = new SqlDataAdapter(lvenda);
                    DataTable dtven = new DataTable();
                    ven.Fill(dtven);
                    int linhasven = dtven.Rows.Count;
                    if (linhasven > 0)
                    {
                        cbxCliente.Enabled = true;
                        cbxCliente.Text = "";
                        cbxCliente.Text = dtven.Rows[0]["nomecliente"].ToString();
                        txtTotal.Text = dtven.Rows[0]["total"].ToString();
                        cbxProduto.Enabled = true;
                        txtQuantidade.Enabled = true;
                        txtValor.Enabled = true;
                        btnNovoItem.Enabled = true;
                        btnEditarItem.Enabled = true;
                        btnExcluirItem.Enabled = true;
                        btnFinalizarVenda.Enabled = true;
                        btnNovoPedido.Enabled = false;
                        btnAtualizarPedido.Enabled = true;
                        dgvVenda.Columns.Add("ID", "ID");
                        dgvVenda.Columns.Add("Produto", "Produto");
                        dgvVenda.Columns.Add("Quantidade", "Quantidade");
                        dgvVenda.Columns.Add("Valor", "Valor");
                        dgvVenda.Columns.Add("Total", "Total");
                        for (int i = 0; i < linhasven; i++)
                        {
                            DataGridViewRow itemven = new DataGridViewRow();
                            itemven.CreateCells(dgvVenda);
                            itemven.Cells[0].Value = dtven.Rows[i]["id_produto"].ToString();
                            itemven.Cells[1].Value = dtven.Rows[i]["nomeproduto"].ToString();
                            itemven.Cells[2].Value = dtven.Rows[i]["quantidade"].ToString();
                            itemven.Cells[3].Value = dtven.Rows[i]["valor_unitario"].ToString();
                            itemven.Cells[4].Value = dtven.Rows[i]["valor_total"].ToString();
                            dgvVenda.Rows.Add(itemven);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum pedido ou venda localizado!", "Não localizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnAtualizarPedido_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Venda SET total = @total WHERE Id = @Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text);
            cmd.ExecuteNonQuery();
            SqlCommand deletarpedido = new SqlCommand("DELETE FROM ItensPedido WHERE id_venda = @Id", con);
            deletarpedido.CommandType = CommandType.Text;
            deletarpedido.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
            deletarpedido.ExecuteNonQuery();
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand itens = new SqlCommand("InserirItensPedidos", con);
                itens.CommandType = CommandType.StoredProcedure;
                itens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
                itens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                itens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                itens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                itens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                itens.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Pedido atualizado com sucesso!", "Pedido Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvVenda.Columns.Clear();
            dgvVenda.Rows.Clear();
            txtIdVenda.Text = "";
            txtTotal.Text = "";
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Venda SET situacao = @situacao WHERE Id = @Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
            cmd.Parameters.AddWithValue("@situacao", SqlDbType.NChar).Value = "Fechada";
            cmd.ExecuteNonQuery();
            SqlCommand deletarpedido = new SqlCommand("DELETE FROM ItensPedido WHERE id_venda = @Id", con);
            deletarpedido.CommandType = CommandType.Text;
            deletarpedido.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
            deletarpedido.ExecuteNonQuery();
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand itens = new SqlCommand("InserirItensVendidos", con);
                itens.CommandType = CommandType.StoredProcedure;
                itens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = Convert.ToInt32(txtIdVenda.Text.Trim());
                itens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                itens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                itens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                itens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                itens.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Venda realizada com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvVenda.Columns.Clear();
            dgvVenda.Rows.Clear();
            txtIdVenda.Text = "";
            txtTotal.Text = "";
        }
    }
}
