namespace GUI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.grupoMaterailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDepósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitoPorProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoquePorMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 636);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.LblTituloPrincipal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 38);
            this.panel2.TabIndex = 4;
            // 
            // LblTituloPrincipal
            // 
            this.LblTituloPrincipal.AutoSize = true;
            this.LblTituloPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTituloPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPrincipal.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTituloPrincipal.Location = new System.Drawing.Point(0, 0);
            this.LblTituloPrincipal.Name = "LblTituloPrincipal";
            this.LblTituloPrincipal.Size = new System.Drawing.Size(82, 33);
            this.LblTituloPrincipal.TabIndex = 1;
            this.LblTituloPrincipal.Text = "CMP";
            this.LblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTituloPrincipal.Click += new System.EventHandler(this.LblTituloPrincipal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.produçãoToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.toolStripSeparator1,
            this.grupoMaterailToolStripMenuItem,
            this.subCategoriaToolStripMenuItem,
            this.unidMedidaToolStripMenuItem,
            this.tipoPagamentoToolStripMenuItem,
            this.depósitoToolStripMenuItem,
            this.tipoProdutoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // grupoMaterailToolStripMenuItem
            // 
            this.grupoMaterailToolStripMenuItem.Name = "grupoMaterailToolStripMenuItem";
            this.grupoMaterailToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.grupoMaterailToolStripMenuItem.Text = "Grupo Material";
            this.grupoMaterailToolStripMenuItem.Click += new System.EventHandler(this.grupoMaterailToolStripMenuItem_Click);
            // 
            // subCategoriaToolStripMenuItem
            // 
            this.subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            this.subCategoriaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.subCategoriaToolStripMenuItem.Text = "SubGrupo Material";
            this.subCategoriaToolStripMenuItem.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem_Click);
            // 
            // unidMedidaToolStripMenuItem
            // 
            this.unidMedidaToolStripMenuItem.Name = "unidMedidaToolStripMenuItem";
            this.unidMedidaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.unidMedidaToolStripMenuItem.Text = "Unid. Medida";
            this.unidMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidMedidaToolStripMenuItem_Click);
            // 
            // tipoPagamentoToolStripMenuItem
            // 
            this.tipoPagamentoToolStripMenuItem.Name = "tipoPagamentoToolStripMenuItem";
            this.tipoPagamentoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tipoPagamentoToolStripMenuItem.Text = "Tipo Pagamento";
            this.tipoPagamentoToolStripMenuItem.Click += new System.EventHandler(this.tipoPagamentoToolStripMenuItem_Click);
            // 
            // depósitoToolStripMenuItem
            // 
            this.depósitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDepósitoToolStripMenuItem,
            this.depósitoPorProdutoToolStripMenuItem});
            this.depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            this.depósitoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.depósitoToolStripMenuItem.Text = "Depósito";
            // 
            // cadastroDepósitoToolStripMenuItem
            // 
            this.cadastroDepósitoToolStripMenuItem.Name = "cadastroDepósitoToolStripMenuItem";
            this.cadastroDepósitoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDepósitoToolStripMenuItem.Text = "Cadastro Depósito";
            this.cadastroDepósitoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDepósitoToolStripMenuItem_Click);
            // 
            // depósitoPorProdutoToolStripMenuItem
            // 
            this.depósitoPorProdutoToolStripMenuItem.Name = "depósitoPorProdutoToolStripMenuItem";
            this.depósitoPorProdutoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.depósitoPorProdutoToolStripMenuItem.Text = "Depósito Por Produto";
            this.depósitoPorProdutoToolStripMenuItem.Click += new System.EventHandler(this.depósitoPorProdutoToolStripMenuItem_Click);
            // 
            // tipoProdutoToolStripMenuItem
            // 
            this.tipoProdutoToolStripMenuItem.Name = "tipoProdutoToolStripMenuItem";
            this.tipoProdutoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tipoProdutoToolStripMenuItem.Text = "Tipo Produto";
            this.tipoProdutoToolStripMenuItem.Click += new System.EventHandler(this.tipoProdutoToolStripMenuItem_Click);
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planoDeProduçãoToolStripMenuItem,
            this.ordemProduçãoToolStripMenuItem});
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.produçãoToolStripMenuItem.Text = "Produção";
            // 
            // planoDeProduçãoToolStripMenuItem
            // 
            this.planoDeProduçãoToolStripMenuItem.Name = "planoDeProduçãoToolStripMenuItem";
            this.planoDeProduçãoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.planoDeProduçãoToolStripMenuItem.Text = "Plano de Produção";
            this.planoDeProduçãoToolStripMenuItem.Click += new System.EventHandler(this.planoDeProduçãoToolStripMenuItem_Click);
            // 
            // ordemProduçãoToolStripMenuItem
            // 
            this.ordemProduçãoToolStripMenuItem.Name = "ordemProduçãoToolStripMenuItem";
            this.ordemProduçãoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ordemProduçãoToolStripMenuItem.Text = "Ordem Produção";
            this.ordemProduçãoToolStripMenuItem.Click += new System.EventHandler(this.ordemProduçãoToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // entradaCompraToolStripMenuItem
            // 
            this.entradaCompraToolStripMenuItem.Name = "entradaCompraToolStripMenuItem";
            this.entradaCompraToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entradaCompraToolStripMenuItem.Text = "Entrada";
            this.entradaCompraToolStripMenuItem.Click += new System.EventHandler(this.entradaCompraToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoVendaToolStripMenuItem,
            this.finalizarVendaToolStripMenuItem});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // pedidoVendaToolStripMenuItem
            // 
            this.pedidoVendaToolStripMenuItem.Name = "pedidoVendaToolStripMenuItem";
            this.pedidoVendaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pedidoVendaToolStripMenuItem.Text = "Pedido";
            this.pedidoVendaToolStripMenuItem.Click += new System.EventHandler(this.pedidoVendaToolStripMenuItem_Click);
            // 
            // finalizarVendaToolStripMenuItem
            // 
            this.finalizarVendaToolStripMenuItem.Name = "finalizarVendaToolStripMenuItem";
            this.finalizarVendaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.finalizarVendaToolStripMenuItem.Text = "Finalizar";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagamentoComprasToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // pagamentoComprasToolStripMenuItem
            // 
            this.pagamentoComprasToolStripMenuItem.Name = "pagamentoComprasToolStripMenuItem";
            this.pagamentoComprasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pagamentoComprasToolStripMenuItem.Text = "Pagamento Compras";
            this.pagamentoComprasToolStripMenuItem.Click += new System.EventHandler(this.pagamentoComprasToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoquePorMaterialToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // estoquePorMaterialToolStripMenuItem
            // 
            this.estoquePorMaterialToolStripMenuItem.Name = "estoquePorMaterialToolStripMenuItem";
            this.estoquePorMaterialToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.estoquePorMaterialToolStripMenuItem.Text = "Estoque Por Material";
            this.estoquePorMaterialToolStripMenuItem.Click += new System.EventHandler(this.estoquePorMaterialToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.ferramentasToolStripMenuItem.Text = "Configuração";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem grupoMaterailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidMedidaToolStripMenuItem;
        public System.Windows.Forms.Label LblTituloPrincipal;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDepósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depósitoPorProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoquePorMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentoComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeProduçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemProduçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoProdutoToolStripMenuItem;
    }
}

