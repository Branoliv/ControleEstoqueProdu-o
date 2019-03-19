namespace GUI
{
    partial class frmConsultaCompras
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
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTituloModeloConsulta = new System.Windows.Forms.Label();
            this.gpbxCriterioConsCompra = new System.Windows.Forms.GroupBox();
            this.rdbConsGeral = new System.Windows.Forms.RadioButton();
            this.rdbConsFornecedor = new System.Windows.Forms.RadioButton();
            this.rdbParcAberto = new System.Windows.Forms.RadioButton();
            this.rdbConsDtCompra = new System.Windows.Forms.RadioButton();
            this.dgvConsCompra = new System.Windows.Forms.DataGridView();
            this.lblConsCodFornecedor = new System.Windows.Forms.Label();
            this.txbConsCompraForn = new System.Windows.Forms.TextBox();
            this.btnConsLocForn = new System.Windows.Forms.Button();
            this.lblConsNomeFornecedor = new System.Windows.Forms.Label();
            this.pnlFornecedor = new System.Windows.Forms.Panel();
            this.pnlDtCompra = new System.Windows.Forms.Panel();
            this.dtpkConsComDtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpkConsComDtInicial = new System.Windows.Forms.DateTimePicker();
            this.lblConsComDtFinal = new System.Windows.Forms.Label();
            this.lblConsComDtIni = new System.Windows.Forms.Label();
            this.pnlParcAberto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsLocProduto = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBotao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbxCriterioConsCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsCompra)).BeginInit();
            this.pnlFornecedor.SuspendLayout();
            this.pnlDtCompra.SuspendLayout();
            this.pnlParcAberto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.Gray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnLimpar);
            this.pnlBotao.Controls.Add(this.btnLocalizar);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 34);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(796, 85);
            this.pnlBotao.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = global::GUI.Properties.Resources.sairflatEs;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(721, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 85);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Image = global::GUI.Properties.Resources.limparflat;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(75, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 85);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalizar.Image = global::GUI.Properties.Resources.localizarflat;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocalizar.Location = new System.Drawing.Point(0, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 85);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.LblTituloModeloConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 34);
            this.panel1.TabIndex = 5;
            // 
            // LblTituloModeloConsulta
            // 
            this.LblTituloModeloConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTituloModeloConsulta.AutoSize = true;
            this.LblTituloModeloConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloModeloConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTituloModeloConsulta.Location = new System.Drawing.Point(0, 0);
            this.LblTituloModeloConsulta.Name = "LblTituloModeloConsulta";
            this.LblTituloModeloConsulta.Size = new System.Drawing.Size(227, 29);
            this.LblTituloModeloConsulta.TabIndex = 2;
            this.LblTituloModeloConsulta.Text = "Consulta Compras";
            this.LblTituloModeloConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpbxCriterioConsCompra
            // 
            this.gpbxCriterioConsCompra.Controls.Add(this.rdbConsGeral);
            this.gpbxCriterioConsCompra.Controls.Add(this.rdbConsFornecedor);
            this.gpbxCriterioConsCompra.Controls.Add(this.rdbParcAberto);
            this.gpbxCriterioConsCompra.Controls.Add(this.rdbConsDtCompra);
            this.gpbxCriterioConsCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbxCriterioConsCompra.Location = new System.Drawing.Point(0, 119);
            this.gpbxCriterioConsCompra.Name = "gpbxCriterioConsCompra";
            this.gpbxCriterioConsCompra.Size = new System.Drawing.Size(796, 41);
            this.gpbxCriterioConsCompra.TabIndex = 0;
            this.gpbxCriterioConsCompra.TabStop = false;
            // 
            // rdbConsGeral
            // 
            this.rdbConsGeral.AutoSize = true;
            this.rdbConsGeral.Checked = true;
            this.rdbConsGeral.Location = new System.Drawing.Point(6, 12);
            this.rdbConsGeral.Name = "rdbConsGeral";
            this.rdbConsGeral.Size = new System.Drawing.Size(112, 17);
            this.rdbConsGeral.TabIndex = 5;
            this.rdbConsGeral.TabStop = true;
            this.rdbConsGeral.Text = "Todas as compras";
            this.rdbConsGeral.UseVisualStyleBackColor = true;
            this.rdbConsGeral.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsFornecedor
            // 
            this.rdbConsFornecedor.AutoSize = true;
            this.rdbConsFornecedor.Location = new System.Drawing.Point(124, 12);
            this.rdbConsFornecedor.Name = "rdbConsFornecedor";
            this.rdbConsFornecedor.Size = new System.Drawing.Size(79, 17);
            this.rdbConsFornecedor.TabIndex = 2;
            this.rdbConsFornecedor.Text = "Fornecedor";
            this.rdbConsFornecedor.UseVisualStyleBackColor = true;
            this.rdbConsFornecedor.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbParcAberto
            // 
            this.rdbParcAberto.AutoSize = true;
            this.rdbParcAberto.Location = new System.Drawing.Point(316, 12);
            this.rdbParcAberto.Name = "rdbParcAberto";
            this.rdbParcAberto.Size = new System.Drawing.Size(116, 17);
            this.rdbParcAberto.TabIndex = 4;
            this.rdbParcAberto.Text = "Parcelas em aberto";
            this.rdbParcAberto.UseVisualStyleBackColor = true;
            this.rdbParcAberto.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsDtCompra
            // 
            this.rdbConsDtCompra.AutoSize = true;
            this.rdbConsDtCompra.Location = new System.Drawing.Point(209, 12);
            this.rdbConsDtCompra.Name = "rdbConsDtCompra";
            this.rdbConsDtCompra.Size = new System.Drawing.Size(101, 17);
            this.rdbConsDtCompra.TabIndex = 3;
            this.rdbConsDtCompra.Text = "Data da compra";
            this.rdbConsDtCompra.UseVisualStyleBackColor = true;
            this.rdbConsDtCompra.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // dgvConsCompra
            // 
            this.dgvConsCompra.AllowUserToAddRows = false;
            this.dgvConsCompra.AllowUserToDeleteRows = false;
            this.dgvConsCompra.AllowUserToResizeRows = false;
            this.dgvConsCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsCompra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsCompra.Location = new System.Drawing.Point(12, 346);
            this.dgvConsCompra.MultiSelect = false;
            this.dgvConsCompra.Name = "dgvConsCompra";
            this.dgvConsCompra.ReadOnly = true;
            this.dgvConsCompra.RowTemplate.Height = 16;
            this.dgvConsCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsCompra.Size = new System.Drawing.Size(772, 401);
            this.dgvConsCompra.TabIndex = 8;
            this.dgvConsCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsCompra_CellDoubleClick);
            // 
            // lblConsCodFornecedor
            // 
            this.lblConsCodFornecedor.AutoSize = true;
            this.lblConsCodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCodFornecedor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsCodFornecedor.Location = new System.Drawing.Point(9, 12);
            this.lblConsCodFornecedor.Name = "lblConsCodFornecedor";
            this.lblConsCodFornecedor.Size = new System.Drawing.Size(46, 13);
            this.lblConsCodFornecedor.TabIndex = 2;
            this.lblConsCodFornecedor.Text = "Código";
            // 
            // txbConsCompraForn
            // 
            this.txbConsCompraForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConsCompraForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbConsCompraForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsCompraForn.Location = new System.Drawing.Point(12, 28);
            this.txbConsCompraForn.Name = "txbConsCompraForn";
            this.txbConsCompraForn.Size = new System.Drawing.Size(73, 20);
            this.txbConsCompraForn.TabIndex = 3;
            this.txbConsCompraForn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConsLocForn
            // 
            this.btnConsLocForn.BackColor = System.Drawing.Color.Gray;
            this.btnConsLocForn.FlatAppearance.BorderSize = 0;
            this.btnConsLocForn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsLocForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsLocForn.Location = new System.Drawing.Point(89, 28);
            this.btnConsLocForn.Name = "btnConsLocForn";
            this.btnConsLocForn.Size = new System.Drawing.Size(20, 20);
            this.btnConsLocForn.TabIndex = 10;
            this.btnConsLocForn.UseVisualStyleBackColor = false;
            this.btnConsLocForn.Click += new System.EventHandler(this.btnConsLocForn_Click);
            // 
            // lblConsNomeFornecedor
            // 
            this.lblConsNomeFornecedor.AutoSize = true;
            this.lblConsNomeFornecedor.Location = new System.Drawing.Point(135, 32);
            this.lblConsNomeFornecedor.Name = "lblConsNomeFornecedor";
            this.lblConsNomeFornecedor.Size = new System.Drawing.Size(92, 13);
            this.lblConsNomeFornecedor.TabIndex = 11;
            this.lblConsNomeFornecedor.Text = "Nome Fornecedor";
            // 
            // pnlFornecedor
            // 
            this.pnlFornecedor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlFornecedor.Controls.Add(this.lblConsNomeFornecedor);
            this.pnlFornecedor.Controls.Add(this.btnConsLocForn);
            this.pnlFornecedor.Controls.Add(this.txbConsCompraForn);
            this.pnlFornecedor.Controls.Add(this.lblConsCodFornecedor);
            this.pnlFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFornecedor.Location = new System.Drawing.Point(0, 160);
            this.pnlFornecedor.Name = "pnlFornecedor";
            this.pnlFornecedor.Size = new System.Drawing.Size(796, 60);
            this.pnlFornecedor.TabIndex = 9;
            this.pnlFornecedor.Visible = false;
            // 
            // pnlDtCompra
            // 
            this.pnlDtCompra.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlDtCompra.Controls.Add(this.dtpkConsComDtFinal);
            this.pnlDtCompra.Controls.Add(this.dtpkConsComDtInicial);
            this.pnlDtCompra.Controls.Add(this.lblConsComDtFinal);
            this.pnlDtCompra.Controls.Add(this.lblConsComDtIni);
            this.pnlDtCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDtCompra.Location = new System.Drawing.Point(0, 220);
            this.pnlDtCompra.Name = "pnlDtCompra";
            this.pnlDtCompra.Size = new System.Drawing.Size(796, 60);
            this.pnlDtCompra.TabIndex = 10;
            this.pnlDtCompra.Visible = false;
            // 
            // dtpkConsComDtFinal
            // 
            this.dtpkConsComDtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkConsComDtFinal.Location = new System.Drawing.Point(138, 24);
            this.dtpkConsComDtFinal.Name = "dtpkConsComDtFinal";
            this.dtpkConsComDtFinal.Size = new System.Drawing.Size(103, 20);
            this.dtpkConsComDtFinal.TabIndex = 9;
            this.dtpkConsComDtFinal.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // dtpkConsComDtInicial
            // 
            this.dtpkConsComDtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkConsComDtInicial.Location = new System.Drawing.Point(12, 24);
            this.dtpkConsComDtInicial.Name = "dtpkConsComDtInicial";
            this.dtpkConsComDtInicial.Size = new System.Drawing.Size(103, 20);
            this.dtpkConsComDtInicial.TabIndex = 8;
            this.dtpkConsComDtInicial.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblConsComDtFinal
            // 
            this.lblConsComDtFinal.AutoSize = true;
            this.lblConsComDtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsComDtFinal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsComDtFinal.Location = new System.Drawing.Point(135, 8);
            this.lblConsComDtFinal.Name = "lblConsComDtFinal";
            this.lblConsComDtFinal.Size = new System.Drawing.Size(55, 13);
            this.lblConsComDtFinal.TabIndex = 6;
            this.lblConsComDtFinal.Text = "Dt. Final";
            // 
            // lblConsComDtIni
            // 
            this.lblConsComDtIni.AutoSize = true;
            this.lblConsComDtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsComDtIni.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsComDtIni.Location = new System.Drawing.Point(9, 8);
            this.lblConsComDtIni.Name = "lblConsComDtIni";
            this.lblConsComDtIni.Size = new System.Drawing.Size(62, 13);
            this.lblConsComDtIni.TabIndex = 4;
            this.lblConsComDtIni.Text = "Dt. Inicial";
            // 
            // pnlParcAberto
            // 
            this.pnlParcAberto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlParcAberto.Controls.Add(this.label1);
            this.pnlParcAberto.Controls.Add(this.btnConsLocProduto);
            this.pnlParcAberto.Controls.Add(this.textBox3);
            this.pnlParcAberto.Controls.Add(this.label3);
            this.pnlParcAberto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlParcAberto.Location = new System.Drawing.Point(0, 280);
            this.pnlParcAberto.Name = "pnlParcAberto";
            this.pnlParcAberto.Size = new System.Drawing.Size(796, 60);
            this.pnlParcAberto.TabIndex = 12;
            this.pnlParcAberto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descrição Produto";
            // 
            // btnConsLocProduto
            // 
            this.btnConsLocProduto.BackColor = System.Drawing.Color.Gray;
            this.btnConsLocProduto.FlatAppearance.BorderSize = 0;
            this.btnConsLocProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsLocProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsLocProduto.Location = new System.Drawing.Point(90, 27);
            this.btnConsLocProduto.Name = "btnConsLocProduto";
            this.btnConsLocProduto.Size = new System.Drawing.Size(20, 20);
            this.btnConsLocProduto.TabIndex = 12;
            this.btnConsLocProduto.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código";
            // 
            // frmConsultaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(796, 759);
            this.ControlBox = false;
            this.Controls.Add(this.pnlParcAberto);
            this.Controls.Add(this.dgvConsCompra);
            this.Controls.Add(this.pnlDtCompra);
            this.Controls.Add(this.pnlFornecedor);
            this.Controls.Add(this.gpbxCriterioConsCompra);
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmConsultaCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta compras";
            this.Load += new System.EventHandler(this.frmConsultaCompras_Load);
            this.pnlBotao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbxCriterioConsCompra.ResumeLayout(false);
            this.gpbxCriterioConsCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsCompra)).EndInit();
            this.pnlFornecedor.ResumeLayout(false);
            this.pnlFornecedor.PerformLayout();
            this.pnlDtCompra.ResumeLayout(false);
            this.pnlDtCompra.PerformLayout();
            this.pnlParcAberto.ResumeLayout(false);
            this.pnlParcAberto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlBotao;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnLimpar;
        protected System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label LblTituloModeloConsulta;
        private System.Windows.Forms.GroupBox gpbxCriterioConsCompra;
        private System.Windows.Forms.RadioButton rdbConsGeral;
        private System.Windows.Forms.RadioButton rdbConsFornecedor;
        private System.Windows.Forms.RadioButton rdbParcAberto;
        private System.Windows.Forms.RadioButton rdbConsDtCompra;
        private System.Windows.Forms.DataGridView dgvConsCompra;
        protected System.Windows.Forms.Label lblConsCodFornecedor;
        protected System.Windows.Forms.TextBox txbConsCompraForn;
        private System.Windows.Forms.Button btnConsLocForn;
        private System.Windows.Forms.Label lblConsNomeFornecedor;
        private System.Windows.Forms.Panel pnlFornecedor;
        private System.Windows.Forms.Panel pnlDtCompra;
        private System.Windows.Forms.Panel pnlParcAberto;
        protected System.Windows.Forms.Label lblConsComDtFinal;
        protected System.Windows.Forms.Label lblConsComDtIni;
        protected System.Windows.Forms.TextBox textBox3;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkConsComDtFinal;
        private System.Windows.Forms.DateTimePicker dtpkConsComDtInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsLocProduto;
    }
}