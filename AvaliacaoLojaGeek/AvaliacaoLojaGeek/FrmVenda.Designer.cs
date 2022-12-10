namespace AvaliacaoLojaGeek
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtualizarPedido = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnLocalizarVenda = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizarPedido
            // 
            this.btnAtualizarPedido.Location = new System.Drawing.Point(602, 59);
            this.btnAtualizarPedido.Name = "btnAtualizarPedido";
            this.btnAtualizarPedido.Size = new System.Drawing.Size(130, 23);
            this.btnAtualizarPedido.TabIndex = 47;
            this.btnAtualizarPedido.Text = "Atualizar Pedido";
            this.btnAtualizarPedido.UseVisualStyleBackColor = true;
            this.btnAtualizarPedido.Click += new System.EventHandler(this.btnAtualizarPedido_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(412, 224);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(103, 23);
            this.btnExcluirItem.TabIndex = 46;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Location = new System.Drawing.Point(412, 195);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(103, 23);
            this.btnEditarItem.TabIndex = 45;
            this.btnEditarItem.Text = "Editar Item";
            this.btnEditarItem.UseVisualStyleBackColor = true;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(412, 166);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(103, 23);
            this.btnNovoItem.TabIndex = 44;
            this.btnNovoItem.Text = "Novo item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(635, 329);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 23);
            this.btnSair.TabIndex = 43;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(635, 300);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(97, 23);
            this.btnFinalizarVenda.TabIndex = 42;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Location = new System.Drawing.Point(635, 271);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(97, 23);
            this.btnFinalizarPedido.TabIndex = 41;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Location = new System.Drawing.Point(602, 20);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(130, 23);
            this.btnNovoPedido.TabIndex = 40;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(451, 431);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 39;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(353, 431);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 20);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total R$";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(415, 127);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProduto.TabIndex = 37;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Location = new System.Drawing.Point(412, 110);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(58, 13);
            this.lblIdProduto.TabIndex = 36;
            this.lblIdProduto.Text = "ID Produto";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(13, 222);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 35;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(10, 205);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(83, 13);
            this.lblPreco.TabIndex = 34;
            this.lblPreco.Text = "Preço / Valor";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(13, 174);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 33;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(10, 157);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 13);
            this.lblQuantidade.TabIndex = 32;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(13, 126);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(396, 21);
            this.cbxProduto.TabIndex = 31;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(10, 109);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(51, 13);
            this.lblProduto.TabIndex = 30;
            this.lblProduto.Text = "Produto";
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(10, 271);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(619, 151);
            this.dgvVenda.TabIndex = 29;
            this.dgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellContentClick);
            // 
            // btnLocalizarVenda
            // 
            this.btnLocalizarVenda.Location = new System.Drawing.Point(125, 27);
            this.btnLocalizarVenda.Name = "btnLocalizarVenda";
            this.btnLocalizarVenda.Size = new System.Drawing.Size(162, 23);
            this.btnLocalizarVenda.TabIndex = 28;
            this.btnLocalizarVenda.Text = "Localizar";
            this.btnLocalizarVenda.UseVisualStyleBackColor = true;
            this.btnLocalizarVenda.Click += new System.EventHandler(this.btnLocalizarVenda_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(13, 76);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(396, 21);
            this.cbxCliente.TabIndex = 27;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(10, 59);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Location = new System.Drawing.Point(13, 29);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(108, 20);
            this.txtIdVenda.TabIndex = 25;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(10, 13);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(111, 13);
            this.lblPedido.TabIndex = 24;
            this.lblPedido.Text = "Id Pedido / Venda";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(152, 200);
            this.lblEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(57, 13);
            this.lblEstoque.TabIndex = 48;
            this.lblEstoque.Text = "Estoque:";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 465);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.btnAtualizarPedido);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnNovoItem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnLocalizarVenda);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.lblPedido);
            this.Name = "FrmVenda";
            this.Text = "FrmVenda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarPedido;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnLocalizarVenda;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblEstoque;
    }
}