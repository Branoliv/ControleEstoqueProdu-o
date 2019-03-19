namespace GUI
{
    partial class frmPlanoDeProducao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPlpLocProd = new System.Windows.Forms.Button();
            this.cbxPlpUnidMed = new System.Windows.Forms.ComboBox();
            this.lblPlpUnidMed = new System.Windows.Forms.Label();
            this.lblPlpCod = new System.Windows.Forms.Label();
            this.txbPlpCod = new System.Windows.Forms.TextBox();
            this.lblPlpDescProduto = new System.Windows.Forms.Label();
            this.lblPlpProCod = new System.Windows.Forms.Label();
            this.lblPlpQtde = new System.Windows.Forms.Label();
            this.txbPlpQtde = new System.Windows.Forms.TextBox();
            this.txbPlpProCod = new System.Windows.Forms.TextBox();
            this.dgvPlpItens = new System.Windows.Forms.DataGridView();
            this.ipp_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipp_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umde_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ippDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItensExcluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbxIppMp = new System.Windows.Forms.GroupBox();
            this.cbxIppDepProd = new System.Windows.Forms.ComboBox();
            this.cbxIppUmProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIppIncluirMp = new System.Windows.Forms.Button();
            this.lblIppQuantProd = new System.Windows.Forms.Label();
            this.txbIppQtde = new System.Windows.Forms.TextBox();
            this.lblIppDescricaoProd = new System.Windows.Forms.Label();
            this.btnIppLocProd = new System.Windows.Forms.Button();
            this.lblIppProduto = new System.Windows.Forms.Label();
            this.txbIppProdCod = new System.Windows.Forms.TextBox();
            this.gbxIppPa = new System.Windows.Forms.GroupBox();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlpItens)).BeginInit();
            this.gbxIppMp.SuspendLayout();
            this.gbxIppPa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.gbxIppPa);
            this.pnlDados.Controls.Add(this.gbxIppMp);
            this.pnlDados.Location = new System.Drawing.Point(12, 79);
            this.pnlDados.Size = new System.Drawing.Size(745, 279);
            this.pnlDados.TabIndex = 0;
            // 
            // btnPlpLocProd
            // 
            this.btnPlpLocProd.BackColor = System.Drawing.Color.Gray;
            this.btnPlpLocProd.FlatAppearance.BorderSize = 0;
            this.btnPlpLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPlpLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlpLocProd.Location = new System.Drawing.Point(206, 32);
            this.btnPlpLocProd.Name = "btnPlpLocProd";
            this.btnPlpLocProd.Size = new System.Drawing.Size(20, 20);
            this.btnPlpLocProd.TabIndex = 26;
            this.btnPlpLocProd.TabStop = false;
            this.btnPlpLocProd.UseVisualStyleBackColor = false;
            this.btnPlpLocProd.Click += new System.EventHandler(this.btnPlpLocProd_Click);
            // 
            // cbxPlpUnidMed
            // 
            this.cbxPlpUnidMed.Enabled = false;
            this.cbxPlpUnidMed.FormattingEnabled = true;
            this.cbxPlpUnidMed.Location = new System.Drawing.Point(119, 81);
            this.cbxPlpUnidMed.Name = "cbxPlpUnidMed";
            this.cbxPlpUnidMed.Size = new System.Drawing.Size(59, 21);
            this.cbxPlpUnidMed.TabIndex = 25;
            this.cbxPlpUnidMed.Enter += new System.EventHandler(this.cbxPlpUnidMed_Enter);
            this.cbxPlpUnidMed.Leave += new System.EventHandler(this.cbxPlpUnidMed_Leave);
            // 
            // lblPlpUnidMed
            // 
            this.lblPlpUnidMed.AutoSize = true;
            this.lblPlpUnidMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlpUnidMed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPlpUnidMed.Location = new System.Drawing.Point(116, 65);
            this.lblPlpUnidMed.Name = "lblPlpUnidMed";
            this.lblPlpUnidMed.Size = new System.Drawing.Size(34, 13);
            this.lblPlpUnidMed.TabIndex = 23;
            this.lblPlpUnidMed.Text = "U.M.";
            // 
            // lblPlpCod
            // 
            this.lblPlpCod.AutoSize = true;
            this.lblPlpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlpCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPlpCod.Location = new System.Drawing.Point(6, 16);
            this.lblPlpCod.Name = "lblPlpCod";
            this.lblPlpCod.Size = new System.Drawing.Size(69, 13);
            this.lblPlpCod.TabIndex = 16;
            this.lblPlpCod.Text = "Cód. Plano";
            // 
            // txbPlpCod
            // 
            this.txbPlpCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlpCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPlpCod.Enabled = false;
            this.txbPlpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlpCod.Location = new System.Drawing.Point(9, 32);
            this.txbPlpCod.Name = "txbPlpCod";
            this.txbPlpCod.Size = new System.Drawing.Size(85, 20);
            this.txbPlpCod.TabIndex = 17;
            this.txbPlpCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPlpCod.Enter += new System.EventHandler(this.txbPlpCod_Enter);
            this.txbPlpCod.Leave += new System.EventHandler(this.txbPlpCod_Leave);
            // 
            // lblPlpDescProduto
            // 
            this.lblPlpDescProduto.AutoSize = true;
            this.lblPlpDescProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPlpDescProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlpDescProduto.Location = new System.Drawing.Point(243, 32);
            this.lblPlpDescProduto.Name = "lblPlpDescProduto";
            this.lblPlpDescProduto.Size = new System.Drawing.Size(237, 16);
            this.lblPlpDescProduto.TabIndex = 21;
            this.lblPlpDescProduto.Text = "Informe o código do produto acabado.";
            // 
            // lblPlpProCod
            // 
            this.lblPlpProCod.AutoSize = true;
            this.lblPlpProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlpProCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPlpProCod.Location = new System.Drawing.Point(116, 16);
            this.lblPlpProCod.Name = "lblPlpProCod";
            this.lblPlpProCod.Size = new System.Drawing.Size(51, 13);
            this.lblPlpProCod.TabIndex = 18;
            this.lblPlpProCod.Text = "Produto";
            // 
            // lblPlpQtde
            // 
            this.lblPlpQtde.AutoSize = true;
            this.lblPlpQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlpQtde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPlpQtde.Location = new System.Drawing.Point(6, 65);
            this.lblPlpQtde.Name = "lblPlpQtde";
            this.lblPlpQtde.Size = new System.Drawing.Size(45, 13);
            this.lblPlpQtde.TabIndex = 20;
            this.lblPlpQtde.Text = "Quant.";
            // 
            // txbPlpQtde
            // 
            this.txbPlpQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlpQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPlpQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlpQtde.Location = new System.Drawing.Point(9, 81);
            this.txbPlpQtde.Name = "txbPlpQtde";
            this.txbPlpQtde.Size = new System.Drawing.Size(85, 20);
            this.txbPlpQtde.TabIndex = 22;
            this.txbPlpQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPlpQtde.Enter += new System.EventHandler(this.txbPlpQtde_Enter);
            this.txbPlpQtde.Leave += new System.EventHandler(this.txbPlpQtde_Leave);
            // 
            // txbPlpProCod
            // 
            this.txbPlpProCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlpProCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPlpProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlpProCod.Location = new System.Drawing.Point(119, 32);
            this.txbPlpProCod.Name = "txbPlpProCod";
            this.txbPlpProCod.Size = new System.Drawing.Size(85, 20);
            this.txbPlpProCod.TabIndex = 19;
            this.txbPlpProCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPlpProCod.Enter += new System.EventHandler(this.txbPlpProCod_Enter);
            this.txbPlpProCod.Leave += new System.EventHandler(this.txbPlpProCod_Leave);
            // 
            // dgvPlpItens
            // 
            this.dgvPlpItens.AllowUserToAddRows = false;
            this.dgvPlpItens.AllowUserToDeleteRows = false;
            this.dgvPlpItens.AllowUserToResizeColumns = false;
            this.dgvPlpItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPlpItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlpItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlpItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipp_Item,
            this.pro_cod,
            this.pro_Nome,
            this.ipp_qtde,
            this.umde_cod,
            this.ippDeposito,
            this.dgvItensExcluir});
            this.dgvPlpItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlpItens.Location = new System.Drawing.Point(12, 374);
            this.dgvPlpItens.MultiSelect = false;
            this.dgvPlpItens.Name = "dgvPlpItens";
            this.dgvPlpItens.RowHeadersVisible = false;
            this.dgvPlpItens.RowTemplate.Height = 18;
            this.dgvPlpItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlpItens.Size = new System.Drawing.Size(745, 253);
            this.dgvPlpItens.TabIndex = 7;
            // 
            // ipp_Item
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d2";
            this.ipp_Item.DefaultCellStyle = dataGridViewCellStyle2;
            this.ipp_Item.HeaderText = "Item";
            this.ipp_Item.Name = "ipp_Item";
            this.ipp_Item.ReadOnly = true;
            this.ipp_Item.Width = 40;
            // 
            // pro_cod
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d6";
            this.pro_cod.DefaultCellStyle = dataGridViewCellStyle3;
            this.pro_cod.HeaderText = "Produto";
            this.pro_cod.Name = "pro_cod";
            this.pro_cod.ReadOnly = true;
            this.pro_cod.Width = 60;
            // 
            // pro_Nome
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.pro_Nome.DefaultCellStyle = dataGridViewCellStyle4;
            this.pro_Nome.HeaderText = "Descrição";
            this.pro_Nome.Name = "pro_Nome";
            this.pro_Nome.ReadOnly = true;
            this.pro_Nome.Width = 200;
            // 
            // ipp_qtde
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.ipp_qtde.DefaultCellStyle = dataGridViewCellStyle5;
            this.ipp_qtde.HeaderText = "Quant.";
            this.ipp_qtde.Name = "ipp_qtde";
            this.ipp_qtde.Width = 60;
            // 
            // umde_cod
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.umde_cod.DefaultCellStyle = dataGridViewCellStyle6;
            this.umde_cod.HeaderText = "U.M.";
            this.umde_cod.Name = "umde_cod";
            this.umde_cod.ReadOnly = true;
            this.umde_cod.Width = 50;
            // 
            // ippDeposito
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ippDeposito.DefaultCellStyle = dataGridViewCellStyle7;
            this.ippDeposito.HeaderText = "Depósito";
            this.ippDeposito.Name = "ippDeposito";
            this.ippDeposito.ReadOnly = true;
            this.ippDeposito.Width = 70;
            // 
            // dgvItensExcluir
            // 
            this.dgvItensExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvItensExcluir.FalseValue = "1";
            this.dgvItensExcluir.HeaderText = "Excluir";
            this.dgvItensExcluir.Name = "dgvItensExcluir";
            this.dgvItensExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItensExcluir.TrueValue = "2";
            this.dgvItensExcluir.Width = 44;
            // 
            // gbxIppMp
            // 
            this.gbxIppMp.Controls.Add(this.cbxIppDepProd);
            this.gbxIppMp.Controls.Add(this.cbxIppUmProd);
            this.gbxIppMp.Controls.Add(this.label1);
            this.gbxIppMp.Controls.Add(this.btnIppIncluirMp);
            this.gbxIppMp.Controls.Add(this.lblIppQuantProd);
            this.gbxIppMp.Controls.Add(this.txbIppQtde);
            this.gbxIppMp.Controls.Add(this.lblIppDescricaoProd);
            this.gbxIppMp.Controls.Add(this.btnIppLocProd);
            this.gbxIppMp.Controls.Add(this.lblIppProduto);
            this.gbxIppMp.Controls.Add(this.txbIppProdCod);
            this.gbxIppMp.Location = new System.Drawing.Point(17, 143);
            this.gbxIppMp.Name = "gbxIppMp";
            this.gbxIppMp.Size = new System.Drawing.Size(711, 118);
            this.gbxIppMp.TabIndex = 27;
            this.gbxIppMp.TabStop = false;
            // 
            // cbxIppDepProd
            // 
            this.cbxIppDepProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIppDepProd.FormattingEnabled = true;
            this.cbxIppDepProd.Location = new System.Drawing.Point(168, 83);
            this.cbxIppDepProd.Name = "cbxIppDepProd";
            this.cbxIppDepProd.Size = new System.Drawing.Size(70, 21);
            this.cbxIppDepProd.TabIndex = 9;
            this.cbxIppDepProd.Enter += new System.EventHandler(this.cbxIppDepProd_Enter);
            this.cbxIppDepProd.Leave += new System.EventHandler(this.cbxIppDepProd_Leave);
            // 
            // cbxIppUmProd
            // 
            this.cbxIppUmProd.Enabled = false;
            this.cbxIppUmProd.FormattingEnabled = true;
            this.cbxIppUmProd.Location = new System.Drawing.Point(103, 83);
            this.cbxIppUmProd.Name = "cbxIppUmProd";
            this.cbxIppUmProd.Size = new System.Drawing.Size(59, 21);
            this.cbxIppUmProd.TabIndex = 9;
            this.cbxIppUmProd.Enter += new System.EventHandler(this.cbxIppUmProd_Enter);
            this.cbxIppUmProd.Leave += new System.EventHandler(this.cbxIppUmProd_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(100, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "U.M.";
            // 
            // btnIppIncluirMp
            // 
            this.btnIppIncluirMp.BackColor = System.Drawing.Color.Gray;
            this.btnIppIncluirMp.FlatAppearance.BorderSize = 0;
            this.btnIppIncluirMp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIppIncluirMp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIppIncluirMp.Location = new System.Drawing.Point(246, 84);
            this.btnIppIncluirMp.Name = "btnIppIncluirMp";
            this.btnIppIncluirMp.Size = new System.Drawing.Size(75, 20);
            this.btnIppIncluirMp.TabIndex = 12;
            this.btnIppIncluirMp.UseVisualStyleBackColor = false;
            this.btnIppIncluirMp.Click += new System.EventHandler(this.btnIppIncluirMp_Click);
            // 
            // lblIppQuantProd
            // 
            this.lblIppQuantProd.AutoSize = true;
            this.lblIppQuantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIppQuantProd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIppQuantProd.Location = new System.Drawing.Point(6, 67);
            this.lblIppQuantProd.Name = "lblIppQuantProd";
            this.lblIppQuantProd.Size = new System.Drawing.Size(45, 13);
            this.lblIppQuantProd.TabIndex = 6;
            this.lblIppQuantProd.Text = "Quant.";
            // 
            // txbIppQtde
            // 
            this.txbIppQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIppQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbIppQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIppQtde.Location = new System.Drawing.Point(9, 83);
            this.txbIppQtde.Name = "txbIppQtde";
            this.txbIppQtde.Size = new System.Drawing.Size(88, 20);
            this.txbIppQtde.TabIndex = 7;
            this.txbIppQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbIppQtde.Enter += new System.EventHandler(this.txbIppQtde_Enter);
            this.txbIppQtde.Leave += new System.EventHandler(this.txbIppQtde_Leave);
            // 
            // lblIppDescricaoProd
            // 
            this.lblIppDescricaoProd.AutoSize = true;
            this.lblIppDescricaoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIppDescricaoProd.Location = new System.Drawing.Point(140, 35);
            this.lblIppDescricaoProd.Name = "lblIppDescricaoProd";
            this.lblIppDescricaoProd.Size = new System.Drawing.Size(215, 16);
            this.lblIppDescricaoProd.TabIndex = 3;
            this.lblIppDescricaoProd.Text = "Informe o código da matéria prima.";
            // 
            // btnIppLocProd
            // 
            this.btnIppLocProd.BackColor = System.Drawing.Color.Gray;
            this.btnIppLocProd.FlatAppearance.BorderSize = 0;
            this.btnIppLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIppLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIppLocProd.Location = new System.Drawing.Point(109, 32);
            this.btnIppLocProd.Name = "btnIppLocProd";
            this.btnIppLocProd.Size = new System.Drawing.Size(20, 20);
            this.btnIppLocProd.TabIndex = 2;
            this.btnIppLocProd.TabStop = false;
            this.btnIppLocProd.UseVisualStyleBackColor = false;
            this.btnIppLocProd.Click += new System.EventHandler(this.btnIppLocProd_Click);
            // 
            // lblIppProduto
            // 
            this.lblIppProduto.AutoSize = true;
            this.lblIppProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIppProduto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIppProduto.Location = new System.Drawing.Point(6, 16);
            this.lblIppProduto.Name = "lblIppProduto";
            this.lblIppProduto.Size = new System.Drawing.Size(51, 13);
            this.lblIppProduto.TabIndex = 0;
            this.lblIppProduto.Text = "Produto";
            // 
            // txbIppProdCod
            // 
            this.txbIppProdCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIppProdCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbIppProdCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIppProdCod.Location = new System.Drawing.Point(9, 32);
            this.txbIppProdCod.Name = "txbIppProdCod";
            this.txbIppProdCod.Size = new System.Drawing.Size(98, 20);
            this.txbIppProdCod.TabIndex = 1;
            this.txbIppProdCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbIppProdCod.Enter += new System.EventHandler(this.txbIppProdCod_Enter);
            this.txbIppProdCod.Leave += new System.EventHandler(this.txbIppProdCod_Leave);
            // 
            // gbxIppPa
            // 
            this.gbxIppPa.Controls.Add(this.lblPlpCod);
            this.gbxIppPa.Controls.Add(this.txbPlpProCod);
            this.gbxIppPa.Controls.Add(this.btnPlpLocProd);
            this.gbxIppPa.Controls.Add(this.txbPlpQtde);
            this.gbxIppPa.Controls.Add(this.cbxPlpUnidMed);
            this.gbxIppPa.Controls.Add(this.lblPlpQtde);
            this.gbxIppPa.Controls.Add(this.lblPlpProCod);
            this.gbxIppPa.Controls.Add(this.lblPlpUnidMed);
            this.gbxIppPa.Controls.Add(this.lblPlpDescProduto);
            this.gbxIppPa.Controls.Add(this.txbPlpCod);
            this.gbxIppPa.Location = new System.Drawing.Point(17, 14);
            this.gbxIppPa.Name = "gbxIppPa";
            this.gbxIppPa.Size = new System.Drawing.Size(711, 119);
            this.gbxIppPa.TabIndex = 0;
            this.gbxIppPa.TabStop = false;
            // 
            // frmPlanoDeProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 641);
            this.Controls.Add(this.dgvPlpItens);
            this.Name = "frmPlanoDeProducao";
            this.Text = "Plano de Produção";
            this.Load += new System.EventHandler(this.frmPlanoDeProducao_Load);
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.pnlDados, 0);
            this.Controls.SetChildIndex(this.dgvPlpItens, 0);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlpItens)).EndInit();
            this.gbxIppMp.ResumeLayout(false);
            this.gbxIppMp.PerformLayout();
            this.gbxIppPa.ResumeLayout(false);
            this.gbxIppPa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlpLocProd;
        private System.Windows.Forms.ComboBox cbxPlpUnidMed;
        private System.Windows.Forms.Label lblPlpUnidMed;
        private System.Windows.Forms.Label lblPlpCod;
        private System.Windows.Forms.TextBox txbPlpCod;
        private System.Windows.Forms.Label lblPlpDescProduto;
        private System.Windows.Forms.Label lblPlpProCod;
        private System.Windows.Forms.Label lblPlpQtde;
        private System.Windows.Forms.TextBox txbPlpQtde;
        private System.Windows.Forms.TextBox txbPlpProCod;
        private System.Windows.Forms.DataGridView dgvPlpItens;
        private System.Windows.Forms.GroupBox gbxIppPa;
        private System.Windows.Forms.GroupBox gbxIppMp;
        private System.Windows.Forms.ComboBox cbxIppUmProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIppIncluirMp;
        private System.Windows.Forms.Label lblIppQuantProd;
        private System.Windows.Forms.TextBox txbIppQtde;
        private System.Windows.Forms.Label lblIppDescricaoProd;
        private System.Windows.Forms.Button btnIppLocProd;
        private System.Windows.Forms.Label lblIppProduto;
        private System.Windows.Forms.TextBox txbIppProdCod;
        private System.Windows.Forms.ComboBox cbxIppDepProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipp_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipp_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn umde_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ippDeposito;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvItensExcluir;
    }
}
