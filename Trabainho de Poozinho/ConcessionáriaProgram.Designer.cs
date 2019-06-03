namespace Trabainho_de_Poozinho
{
    partial class ConcessionáriaProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcessionáriaProgram));
            this.BtnTipos = new System.Windows.Forms.ToolStrip();
            this.BtnVeículos = new System.Windows.Forms.ToolStripButton();
            this.BtnCliente = new System.Windows.Forms.ToolStripButton();
            this.BtnVenda = new System.Windows.Forms.ToolStripButton();
            this.BtnRelCompra = new System.Windows.Forms.ToolStripButton();
            this.BtnRelVenda = new System.Windows.Forms.ToolStripButton();
            this.BtnRelGeral = new System.Windows.Forms.ToolStripButton();
            this.BtnAções = new System.Windows.Forms.ToolStrip();
            this.BtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.BtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.BtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.BtnPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.BtnTipos.SuspendLayout();
            this.BtnAções.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTipos
            // 
            this.BtnTipos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnVeículos,
            this.BtnCliente,
            this.BtnVenda,
            this.BtnRelCompra,
            this.BtnRelVenda,
            this.BtnRelGeral});
            this.BtnTipos.Location = new System.Drawing.Point(0, 0);
            this.BtnTipos.Name = "BtnTipos";
            this.BtnTipos.Size = new System.Drawing.Size(1082, 25);
            this.BtnTipos.TabIndex = 0;
            this.BtnTipos.Text = "toolStrip1";
            // 
            // BtnVeículos
            // 
            this.BtnVeículos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnVeículos.Image = ((System.Drawing.Image)(resources.GetObject("BtnVeículos.Image")));
            this.BtnVeículos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVeículos.Name = "BtnVeículos";
            this.BtnVeículos.Size = new System.Drawing.Size(54, 22);
            this.BtnVeículos.Text = "Veículos";
            this.BtnVeículos.Click += new System.EventHandler(this.BtnVeículos_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnCliente.Image")));
            this.BtnCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(48, 22);
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnVenda
            // 
            this.BtnVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnVenda.Image = ((System.Drawing.Image)(resources.GetObject("BtnVenda.Image")));
            this.BtnVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVenda.Name = "BtnVenda";
            this.BtnVenda.Size = new System.Drawing.Size(43, 22);
            this.BtnVenda.Text = "Venda";
            this.BtnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
            // 
            // BtnRelCompra
            // 
            this.BtnRelCompra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnRelCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelCompra.Image")));
            this.BtnRelCompra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRelCompra.Name = "BtnRelCompra";
            this.BtnRelCompra.Size = new System.Drawing.Size(125, 22);
            this.BtnRelCompra.Text = "Relatório de Compras";
            this.BtnRelCompra.Click += new System.EventHandler(this.BtnRelCompra_Click);
            // 
            // BtnRelVenda
            // 
            this.BtnRelVenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnRelVenda.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelVenda.Image")));
            this.BtnRelVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRelVenda.Name = "BtnRelVenda";
            this.BtnRelVenda.Size = new System.Drawing.Size(114, 22);
            this.BtnRelVenda.Text = "Relatório de Vendas";
            this.BtnRelVenda.ToolTipText = "Relatório de Vendas";
            this.BtnRelVenda.Click += new System.EventHandler(this.BtnRelVenda_Click);
            // 
            // BtnRelGeral
            // 
            this.BtnRelGeral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnRelGeral.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelGeral.Image")));
            this.BtnRelGeral.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRelGeral.Name = "BtnRelGeral";
            this.BtnRelGeral.Size = new System.Drawing.Size(129, 22);
            this.BtnRelGeral.Text = "Relatório Geral Mensal";
            this.BtnRelGeral.Click += new System.EventHandler(this.BtnRelGeral_Click);
            // 
            // BtnAções
            // 
            this.BtnAções.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAdicionar,
            this.BtnExcluir,
            this.BtnAlterar,
            this.BtnPesquisa});
            this.BtnAções.Location = new System.Drawing.Point(0, 25);
            this.BtnAções.Name = "BtnAções";
            this.BtnAções.Size = new System.Drawing.Size(1082, 25);
            this.BtnAções.TabIndex = 1;
            this.BtnAções.Text = "toolStrip2";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.Image")));
            this.BtnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(62, 22);
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(45, 22);
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlterar.Image")));
            this.BtnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(46, 22);
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(104, 25);
            this.BtnPesquisa.Text = "Pesquisar";
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // GridDados
            // 
            this.GridDados.BackgroundColor = System.Drawing.Color.LightGray;
            this.GridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.GridDados.Location = new System.Drawing.Point(0, 50);
            this.GridDados.Name = "GridDados";
            this.GridDados.Size = new System.Drawing.Size(1082, 581);
            this.GridDados.TabIndex = 2;
            this.GridDados.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellEndEdit);
            // 
            // ConcessionáriaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 631);
            this.Controls.Add(this.GridDados);
            this.Controls.Add(this.BtnAções);
            this.Controls.Add(this.BtnTipos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConcessionáriaProgram";
            this.Text = "Concessionária GHO";
            this.Load += new System.EventHandler(this.ConcessionáriaProgram_Load);
            this.BtnTipos.ResumeLayout(false);
            this.BtnTipos.PerformLayout();
            this.BtnAções.ResumeLayout(false);
            this.BtnAções.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BtnTipos;
        private System.Windows.Forms.ToolStrip BtnAções;
        public System.Windows.Forms.ToolStripButton BtnVeículos;
        public System.Windows.Forms.ToolStripButton BtnCliente;
        public System.Windows.Forms.ToolStripButton BtnVenda;
        public System.Windows.Forms.ToolStripButton BtnRelCompra;
        public System.Windows.Forms.ToolStripButton BtnRelVenda;
        public System.Windows.Forms.ToolStripButton BtnRelGeral;
        public System.Windows.Forms.ToolStripButton BtnAdicionar;
        public System.Windows.Forms.ToolStripButton BtnExcluir;
        public System.Windows.Forms.ToolStripButton BtnAlterar;
        public System.Windows.Forms.ToolStripTextBox BtnPesquisa;
        public System.Windows.Forms.DataGridView GridDados;
    }
}