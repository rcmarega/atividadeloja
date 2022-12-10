namespace AvaliacaoLojaGeek
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.pbxProduto = new System.Windows.Forms.PictureBox();
            this.pbxVenda = new System.Windows.Forms.PictureBox();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbxCliente
            // 
            //this.pbxCliente.Image = global::AvaliacaoLojaGeek.Properties.Resources.cliente;
            this.pbxCliente.Location = new System.Drawing.Point(14, 39);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(133, 151);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 1;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click);
            // 
            // pbxProduto
            // 
            //this.pbxProduto.Image = global::AvaliacaoLojaGeek.Properties.Resources.produtos;
            this.pbxProduto.Location = new System.Drawing.Point(195, 39);
            this.pbxProduto.Name = "pbxProduto";
            this.pbxProduto.Size = new System.Drawing.Size(139, 151);
            this.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProduto.TabIndex = 2;
            this.pbxProduto.TabStop = false;
            this.pbxProduto.Click += new System.EventHandler(this.pbxProduto_Click);
            // 
            // pbxVenda
            // 
            //this.pbxVenda.Image = global::AvaliacaoLojaGeek.Properties.Resources.vendas;
            this.pbxVenda.Location = new System.Drawing.Point(394, 39);
            this.pbxVenda.Name = "pbxVenda";
            this.pbxVenda.Size = new System.Drawing.Size(139, 151);
            this.pbxVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenda.TabIndex = 3;
            this.pbxVenda.TabStop = false;
            this.pbxVenda.Click += new System.EventHandler(this.pbxVenda_Click);
            // 
            // pbxSair
            // 
            //this.pbxSair.Image = global::AvaliacaoLojaGeek.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(602, 39);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(139, 151);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 4;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produtos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxVenda);
            this.Controls.Add(this.pbxProduto);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.PictureBox pbxProduto;
        private System.Windows.Forms.PictureBox pbxVenda;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}