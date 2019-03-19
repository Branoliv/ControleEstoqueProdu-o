namespace GUI
{
    partial class frmOrdemProducao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.gbxIopPa = new System.Windows.Forms.GroupBox();
            this.lblOdpCodPedido = new System.Windows.Forms.Label();
            this.txbOdpCodPedido = new System.Windows.Forms.TextBox();
            this.lblOdpCod = new System.Windows.Forms.Label();
            this.txbOdpProCod = new System.Windows.Forms.TextBox();
            this.btnOdpLocProd = new System.Windows.Forms.Button();
            this.txbOdpQtde = new System.Windows.Forms.TextBox();
            this.cbxOdpUnidMed = new System.Windows.Forms.ComboBox();
            this.lblOdpQtde = new System.Windows.Forms.Label();
            this.lblOdpProCod = new System.Windows.Forms.Label();
            this.lblOdpUnidMed = new System.Windows.Forms.Label();
            this.lblOdpDescProduto = new System.Windows.Forms.Label();
            this.txbOdpCod = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvItensOrdemProducao = new System.Windows.Forms.DataGridView();
            this.ippCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plpCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ippQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umedSimb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iopDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblOdpItemPedido = new System.Windows.Forms.Label();
            this.txbOdpItemPedido = new System.Windows.Forms.TextBox();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.gbxIopPa.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensOrdemProducao)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.SlateGray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnExcluir);
            this.pnlBotao.Controls.Add(this.btnCancelar);
            this.pnlBotao.Controls.Add(this.btnSalvar);
            this.pnlBotao.Controls.Add(this.btnAlterar);
            this.pnlBotao.Controls.Add(this.btnLocalizar);
            this.pnlBotao.Controls.Add(this.btnInserir);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 0);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(774, 68);
            this.pnlBotao.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = global::GUI.Properties.Resources.sairflat40x40;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(699, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 68);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = global::GUI.Properties.Resources.Lixoflat40x40;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(375, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 68);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Image = global::GUI.Properties.Resources.cancelarflat40x40;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(300, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 68);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Image = global::GUI.Properties.Resources.salvarflat40x40;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(225, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 68);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.Image = global::GUI.Properties.Resources.alterarflat40x40;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(150, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 68);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalizar.Image = global::GUI.Properties.Resources.localizarflat40x40;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocalizar.Location = new System.Drawing.Point(75, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 68);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Transparent;
            this.btnInserir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserir.Image = global::GUI.Properties.Resources.inserirflat40x40;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(0, 0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 68);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlDados.Controls.Add(this.gbxIopPa);
            this.pnlDados.Location = new System.Drawing.Point(12, 82);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(750, 151);
            this.pnlDados.TabIndex = 3;
            // 
            // gbxIopPa
            // 
            this.gbxIopPa.Controls.Add(this.lblOdpItemPedido);
            this.gbxIopPa.Controls.Add(this.txbOdpItemPedido);
            this.gbxIopPa.Controls.Add(this.lblOdpCodPedido);
            this.gbxIopPa.Controls.Add(this.txbOdpCodPedido);
            this.gbxIopPa.Controls.Add(this.lblOdpCod);
            this.gbxIopPa.Controls.Add(this.txbOdpProCod);
            this.gbxIopPa.Controls.Add(this.btnOdpLocProd);
            this.gbxIopPa.Controls.Add(this.txbOdpQtde);
            this.gbxIopPa.Controls.Add(this.cbxOdpUnidMed);
            this.gbxIopPa.Controls.Add(this.lblOdpQtde);
            this.gbxIopPa.Controls.Add(this.lblOdpProCod);
            this.gbxIopPa.Controls.Add(this.lblOdpUnidMed);
            this.gbxIopPa.Controls.Add(this.lblOdpDescProduto);
            this.gbxIopPa.Controls.Add(this.txbOdpCod);
            this.gbxIopPa.Location = new System.Drawing.Point(17, 16);
            this.gbxIopPa.Name = "gbxIopPa";
            this.gbxIopPa.Size = new System.Drawing.Size(711, 119);
            this.gbxIopPa.TabIndex = 1;
            this.gbxIopPa.TabStop = false;
            // 
            // lblOdpCodPedido
            // 
            this.lblOdpCodPedido.AutoSize = true;
            this.lblOdpCodPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpCodPedido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpCodPedido.Location = new System.Drawing.Point(133, 16);
            this.lblOdpCodPedido.Name = "lblOdpCodPedido";
            this.lblOdpCodPedido.Size = new System.Drawing.Size(46, 13);
            this.lblOdpCodPedido.TabIndex = 27;
            this.lblOdpCodPedido.Text = "Pedido";
            // 
            // txbOdpCodPedido
            // 
            this.txbOdpCodPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOdpCodPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbOdpCodPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOdpCodPedido.Location = new System.Drawing.Point(136, 32);
            this.txbOdpCodPedido.Name = "txbOdpCodPedido";
            this.txbOdpCodPedido.Size = new System.Drawing.Size(85, 20);
            this.txbOdpCodPedido.TabIndex = 28;
            this.txbOdpCodPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOdpCod
            // 
            this.lblOdpCod.AutoSize = true;
            this.lblOdpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpCod.Location = new System.Drawing.Point(6, 16);
            this.lblOdpCod.Name = "lblOdpCod";
            this.lblOdpCod.Size = new System.Drawing.Size(46, 13);
            this.lblOdpCod.TabIndex = 16;
            this.lblOdpCod.Text = "Código";
            // 
            // txbOdpProCod
            // 
            this.txbOdpProCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOdpProCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbOdpProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOdpProCod.Location = new System.Drawing.Point(9, 81);
            this.txbOdpProCod.Name = "txbOdpProCod";
            this.txbOdpProCod.Size = new System.Drawing.Size(85, 20);
            this.txbOdpProCod.TabIndex = 19;
            this.txbOdpProCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOdpLocProd
            // 
            this.btnOdpLocProd.BackColor = System.Drawing.Color.Gray;
            this.btnOdpLocProd.FlatAppearance.BorderSize = 0;
            this.btnOdpLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOdpLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdpLocProd.Location = new System.Drawing.Point(96, 81);
            this.btnOdpLocProd.Name = "btnOdpLocProd";
            this.btnOdpLocProd.Size = new System.Drawing.Size(20, 20);
            this.btnOdpLocProd.TabIndex = 26;
            this.btnOdpLocProd.TabStop = false;
            this.btnOdpLocProd.UseVisualStyleBackColor = false;
            // 
            // txbOdpQtde
            // 
            this.txbOdpQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOdpQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbOdpQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOdpQtde.Location = new System.Drawing.Point(495, 81);
            this.txbOdpQtde.Name = "txbOdpQtde";
            this.txbOdpQtde.Size = new System.Drawing.Size(85, 20);
            this.txbOdpQtde.TabIndex = 22;
            this.txbOdpQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxOdpUnidMed
            // 
            this.cbxOdpUnidMed.Enabled = false;
            this.cbxOdpUnidMed.FormattingEnabled = true;
            this.cbxOdpUnidMed.Location = new System.Drawing.Point(605, 81);
            this.cbxOdpUnidMed.Name = "cbxOdpUnidMed";
            this.cbxOdpUnidMed.Size = new System.Drawing.Size(59, 21);
            this.cbxOdpUnidMed.TabIndex = 25;
            // 
            // lblOdpQtde
            // 
            this.lblOdpQtde.AutoSize = true;
            this.lblOdpQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpQtde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpQtde.Location = new System.Drawing.Point(492, 65);
            this.lblOdpQtde.Name = "lblOdpQtde";
            this.lblOdpQtde.Size = new System.Drawing.Size(45, 13);
            this.lblOdpQtde.TabIndex = 20;
            this.lblOdpQtde.Text = "Quant.";
            // 
            // lblOdpProCod
            // 
            this.lblOdpProCod.AutoSize = true;
            this.lblOdpProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpProCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpProCod.Location = new System.Drawing.Point(6, 65);
            this.lblOdpProCod.Name = "lblOdpProCod";
            this.lblOdpProCod.Size = new System.Drawing.Size(51, 13);
            this.lblOdpProCod.TabIndex = 18;
            this.lblOdpProCod.Text = "Produto";
            // 
            // lblOdpUnidMed
            // 
            this.lblOdpUnidMed.AutoSize = true;
            this.lblOdpUnidMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpUnidMed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpUnidMed.Location = new System.Drawing.Point(602, 65);
            this.lblOdpUnidMed.Name = "lblOdpUnidMed";
            this.lblOdpUnidMed.Size = new System.Drawing.Size(34, 13);
            this.lblOdpUnidMed.TabIndex = 23;
            this.lblOdpUnidMed.Text = "U.M.";
            // 
            // lblOdpDescProduto
            // 
            this.lblOdpDescProduto.AutoSize = true;
            this.lblOdpDescProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOdpDescProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpDescProduto.Location = new System.Drawing.Point(133, 81);
            this.lblOdpDescProduto.Name = "lblOdpDescProduto";
            this.lblOdpDescProduto.Size = new System.Drawing.Size(237, 16);
            this.lblOdpDescProduto.TabIndex = 21;
            this.lblOdpDescProduto.Text = "Informe o código do produto acabado.";
            // 
            // txbOdpCod
            // 
            this.txbOdpCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOdpCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbOdpCod.Enabled = false;
            this.txbOdpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOdpCod.Location = new System.Drawing.Point(9, 32);
            this.txbOdpCod.Name = "txbOdpCod";
            this.txbOdpCod.Size = new System.Drawing.Size(85, 20);
            this.txbOdpCod.TabIndex = 17;
            this.txbOdpCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 247);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 296);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dgvItensOrdemProducao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quant. Mat Prima";
            // 
            // dgvItensOrdemProducao
            // 
            this.dgvItensOrdemProducao.AllowUserToAddRows = false;
            this.dgvItensOrdemProducao.AllowUserToDeleteRows = false;
            this.dgvItensOrdemProducao.AllowUserToResizeRows = false;
            this.dgvItensOrdemProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensOrdemProducao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ippCod,
            this.plpCod,
            this.proCod,
            this.proNome,
            this.ippQtde,
            this.umedSimb,
            this.iopDeposito});
            this.dgvItensOrdemProducao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItensOrdemProducao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItensOrdemProducao.Location = new System.Drawing.Point(3, 3);
            this.dgvItensOrdemProducao.MultiSelect = false;
            this.dgvItensOrdemProducao.Name = "dgvItensOrdemProducao";
            this.dgvItensOrdemProducao.RowHeadersVisible = false;
            this.dgvItensOrdemProducao.RowTemplate.Height = 18;
            this.dgvItensOrdemProducao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensOrdemProducao.Size = new System.Drawing.Size(734, 262);
            this.dgvItensOrdemProducao.TabIndex = 0;
            // 
            // ippCod
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ippCod.DefaultCellStyle = dataGridViewCellStyle15;
            this.ippCod.HeaderText = "Item";
            this.ippCod.Name = "ippCod";
            this.ippCod.ReadOnly = true;
            this.ippCod.Width = 50;
            // 
            // plpCod
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.plpCod.DefaultCellStyle = dataGridViewCellStyle16;
            this.plpCod.HeaderText = "Pl. Produção";
            this.plpCod.Name = "plpCod";
            this.plpCod.ReadOnly = true;
            // 
            // proCod
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proCod.DefaultCellStyle = dataGridViewCellStyle17;
            this.proCod.HeaderText = "Material";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 80;
            // 
            // proNome
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.proNome.DefaultCellStyle = dataGridViewCellStyle18;
            this.proNome.HeaderText = "Descrição";
            this.proNome.Name = "proNome";
            this.proNome.ReadOnly = true;
            this.proNome.Width = 300;
            // 
            // ippQtde
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ippQtde.DefaultCellStyle = dataGridViewCellStyle19;
            this.ippQtde.HeaderText = "Quant.";
            this.ippQtde.Name = "ippQtde";
            this.ippQtde.ReadOnly = true;
            this.ippQtde.Width = 90;
            // 
            // umedSimb
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.umedSimb.DefaultCellStyle = dataGridViewCellStyle20;
            this.umedSimb.HeaderText = "U.M.";
            this.umedSimb.Name = "umedSimb";
            this.umedSimb.ReadOnly = true;
            this.umedSimb.Width = 50;
            // 
            // iopDeposito
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iopDeposito.DefaultCellStyle = dataGridViewCellStyle21;
            this.iopDeposito.HeaderText = "Depósito";
            this.iopDeposito.Name = "iopDeposito";
            this.iopDeposito.ReadOnly = true;
            this.iopDeposito.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custo Ordem";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(734, 262);
            this.dataGridView2.TabIndex = 1;
            // 
            // lblOdpItemPedido
            // 
            this.lblOdpItemPedido.AutoSize = true;
            this.lblOdpItemPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpItemPedido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpItemPedido.Location = new System.Drawing.Point(224, 16);
            this.lblOdpItemPedido.Name = "lblOdpItemPedido";
            this.lblOdpItemPedido.Size = new System.Drawing.Size(31, 13);
            this.lblOdpItemPedido.TabIndex = 29;
            this.lblOdpItemPedido.Text = "Item";
            // 
            // txbOdpItemPedido
            // 
            this.txbOdpItemPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOdpItemPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbOdpItemPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOdpItemPedido.Location = new System.Drawing.Point(227, 32);
            this.txbOdpItemPedido.Name = "txbOdpItemPedido";
            this.txbOdpItemPedido.Size = new System.Drawing.Size(85, 20);
            this.txbOdpItemPedido.TabIndex = 30;
            this.txbOdpItemPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbOdpItemPedido.Enter += new System.EventHandler(this.txbOdpItemPedido_Enter);
            this.txbOdpItemPedido.Leave += new System.EventHandler(this.txbOdpItemPedido_Leave);
            // 
            // frmOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(774, 556);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlBotao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdemProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ordem Produção";
            this.Load += new System.EventHandler(this.frmOrdemProducao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOrdemProducao_KeyDown);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.gbxIopPa.ResumeLayout(false);
            this.gbxIopPa.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensOrdemProducao)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlBotao;
        private System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnAlterar;
        protected System.Windows.Forms.Button btnLocalizar;
        protected System.Windows.Forms.Button btnInserir;
        protected System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.GroupBox gbxIopPa;
        private System.Windows.Forms.Label lblOdpCod;
        private System.Windows.Forms.TextBox txbOdpProCod;
        private System.Windows.Forms.Button btnOdpLocProd;
        private System.Windows.Forms.TextBox txbOdpQtde;
        private System.Windows.Forms.ComboBox cbxOdpUnidMed;
        private System.Windows.Forms.Label lblOdpQtde;
        private System.Windows.Forms.Label lblOdpProCod;
        private System.Windows.Forms.Label lblOdpUnidMed;
        private System.Windows.Forms.Label lblOdpDescProduto;
        private System.Windows.Forms.TextBox txbOdpCod;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvItensOrdemProducao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblOdpCodPedido;
        private System.Windows.Forms.TextBox txbOdpCodPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ippCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn plpCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ippQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn umedSimb;
        private System.Windows.Forms.DataGridViewTextBoxColumn iopDeposito;
        private System.Windows.Forms.Label lblOdpItemPedido;
        private System.Windows.Forms.TextBox txbOdpItemPedido;
    }
}