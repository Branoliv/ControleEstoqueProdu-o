namespace GUI
{
    partial class frmMovimentacaoCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbComCod = new System.Windows.Forms.TextBox();
            this.lblComCod = new System.Windows.Forms.Label();
            this.txbComCodForn = new System.Windows.Forms.TextBox();
            this.lblComFornecedor = new System.Windows.Forms.Label();
            this.dtpkDtCompra = new System.Windows.Forms.DateTimePicker();
            this.txbComTotalCompra = new System.Windows.Forms.TextBox();
            this.lblComTotal = new System.Windows.Forms.Label();
            this.lblDtCompra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkDtVencPriPar = new System.Windows.Forms.DateTimePicker();
            this.cbxComParcelas = new System.Windows.Forms.ComboBox();
            this.cbxComTpPagto = new System.Windows.Forms.ComboBox();
            this.lblComParcelas = new System.Windows.Forms.Label();
            this.lblComTpPagto = new System.Windows.Forms.Label();
            this.dgvComItens = new System.Windows.Forms.DataGridView();
            this.itcstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodUndmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_abreviacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVlUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbComNf = new System.Windows.Forms.TextBox();
            this.lblComNf = new System.Windows.Forms.Label();
            this.btnComLocForn = new System.Windows.Forms.Button();
            this.lblComForn = new System.Windows.Forms.Label();
            this.gbxComCompra = new System.Windows.Forms.GroupBox();
            this.txbComTm = new System.Windows.Forms.TextBox();
            this.lblComTm = new System.Windows.Forms.Label();
            this.gbxComProduto = new System.Windows.Forms.GroupBox();
            this.cbxComDeProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxComUmProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComProdIncluir = new System.Windows.Forms.Button();
            this.lblComVlUnit = new System.Windows.Forms.Label();
            this.txbComVlUnit = new System.Windows.Forms.TextBox();
            this.lblComQuantProd = new System.Windows.Forms.Label();
            this.txbComQuantProd = new System.Windows.Forms.TextBox();
            this.lblComProd = new System.Windows.Forms.Label();
            this.btnComLocProd = new System.Windows.Forms.Button();
            this.lblComProduto = new System.Windows.Forms.Label();
            this.txbComCodProd = new System.Windows.Forms.TextBox();
            this.gbxComVencimentos = new System.Windows.Forms.GroupBox();
            this.btnComGerarParcelas = new System.Windows.Forms.Button();
            this.lblComItensCompra = new System.Windows.Forms.Label();
            this.pnlParcelas = new System.Windows.Forms.Panel();
            this.lblComTlParcelas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComParcelas = new System.Windows.Forms.DataGridView();
            this.pcostatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPclTitulo = new System.Windows.Forms.Label();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComItens)).BeginInit();
            this.gbxComCompra.SuspendLayout();
            this.gbxComProduto.SuspendLayout();
            this.gbxComVencimentos.SuspendLayout();
            this.pnlParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComParcelas)).BeginInit();
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
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(854, 68);
            this.pnlBotao.TabIndex = 3;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.lblComItensCompra);
            this.pnlDados.Controls.Add(this.gbxComVencimentos);
            this.pnlDados.Controls.Add(this.gbxComProduto);
            this.pnlDados.Controls.Add(this.gbxComCompra);
            this.pnlDados.Controls.Add(this.dgvComItens);
            this.pnlDados.Size = new System.Drawing.Size(745, 618);
            // 
            // txbComCod
            // 
            this.txbComCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComCod.Enabled = false;
            this.txbComCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComCod.Location = new System.Drawing.Point(9, 32);
            this.txbComCod.Name = "txbComCod";
            this.txbComCod.Size = new System.Drawing.Size(85, 20);
            this.txbComCod.TabIndex = 1;
            this.txbComCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbComCod.Enter += new System.EventHandler(this.txbComCod_Enter);
            this.txbComCod.Leave += new System.EventHandler(this.txbComCod_Leave);
            // 
            // lblComCod
            // 
            this.lblComCod.AutoSize = true;
            this.lblComCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComCod.Location = new System.Drawing.Point(6, 16);
            this.lblComCod.Name = "lblComCod";
            this.lblComCod.Size = new System.Drawing.Size(46, 13);
            this.lblComCod.TabIndex = 0;
            this.lblComCod.Text = "Código";
            // 
            // txbComCodForn
            // 
            this.txbComCodForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComCodForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComCodForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComCodForn.Location = new System.Drawing.Point(9, 81);
            this.txbComCodForn.Name = "txbComCodForn";
            this.txbComCodForn.Size = new System.Drawing.Size(98, 20);
            this.txbComCodForn.TabIndex = 9;
            this.txbComCodForn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbComCodForn.Enter += new System.EventHandler(this.txbComCodForn_Enter);
            this.txbComCodForn.Leave += new System.EventHandler(this.txbComCodForn_Leave);
            // 
            // lblComFornecedor
            // 
            this.lblComFornecedor.AutoSize = true;
            this.lblComFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComFornecedor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComFornecedor.Location = new System.Drawing.Point(6, 65);
            this.lblComFornecedor.Name = "lblComFornecedor";
            this.lblComFornecedor.Size = new System.Drawing.Size(101, 13);
            this.lblComFornecedor.TabIndex = 8;
            this.lblComFornecedor.Text = "Cód. Fornecedor";
            // 
            // dtpkDtCompra
            // 
            this.dtpkDtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDtCompra.Location = new System.Drawing.Point(366, 32);
            this.dtpkDtCompra.Name = "dtpkDtCompra";
            this.dtpkDtCompra.Size = new System.Drawing.Size(98, 20);
            this.dtpkDtCompra.TabIndex = 7;
            this.dtpkDtCompra.Enter += new System.EventHandler(this.dtpkDtCompra_Enter);
            this.dtpkDtCompra.Leave += new System.EventHandler(this.dtpkDtCompra_Leave);
            // 
            // txbComTotalCompra
            // 
            this.txbComTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComTotalCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComTotalCompra.Enabled = false;
            this.txbComTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComTotalCompra.Location = new System.Drawing.Point(600, 35);
            this.txbComTotalCompra.Name = "txbComTotalCompra";
            this.txbComTotalCompra.Size = new System.Drawing.Size(98, 20);
            this.txbComTotalCompra.TabIndex = 7;
            this.txbComTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbComTotalCompra.TextChanged += new System.EventHandler(this.txbComTotalCompra_TextChanged);
            this.txbComTotalCompra.Enter += new System.EventHandler(this.txbComTotalCompra_Enter);
            this.txbComTotalCompra.Leave += new System.EventHandler(this.txbComTotalCompra_Leave);
            // 
            // lblComTotal
            // 
            this.lblComTotal.AutoSize = true;
            this.lblComTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComTotal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComTotal.Location = new System.Drawing.Point(597, 19);
            this.lblComTotal.Name = "lblComTotal";
            this.lblComTotal.Size = new System.Drawing.Size(36, 13);
            this.lblComTotal.TabIndex = 6;
            this.lblComTotal.Text = "Total";
            // 
            // lblDtCompra
            // 
            this.lblDtCompra.AutoSize = true;
            this.lblDtCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCompra.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDtCompra.Location = new System.Drawing.Point(363, 16);
            this.lblDtCompra.Name = "lblDtCompra";
            this.lblDtCompra.Size = new System.Drawing.Size(80, 13);
            this.lblDtCompra.TabIndex = 6;
            this.lblDtCompra.Text = "Data Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(295, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Venc. Primeira Parcela";
            // 
            // dtpkDtVencPriPar
            // 
            this.dtpkDtVencPriPar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDtVencPriPar.Location = new System.Drawing.Point(298, 35);
            this.dtpkDtVencPriPar.Name = "dtpkDtVencPriPar";
            this.dtpkDtVencPriPar.Size = new System.Drawing.Size(133, 20);
            this.dtpkDtVencPriPar.TabIndex = 5;
            this.dtpkDtVencPriPar.Enter += new System.EventHandler(this.dtpkDtVencPriPar_Enter);
            this.dtpkDtVencPriPar.Leave += new System.EventHandler(this.dtpkDtVencPriPar_Leave);
            // 
            // cbxComParcelas
            // 
            this.cbxComParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComParcelas.FormattingEnabled = true;
            this.cbxComParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxComParcelas.Location = new System.Drawing.Point(9, 34);
            this.cbxComParcelas.Name = "cbxComParcelas";
            this.cbxComParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbxComParcelas.TabIndex = 1;
            this.cbxComParcelas.Enter += new System.EventHandler(this.cbxComParcelas_Enter);
            this.cbxComParcelas.Leave += new System.EventHandler(this.cbxComParcelas_Leave);
            // 
            // cbxComTpPagto
            // 
            this.cbxComTpPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComTpPagto.FormattingEnabled = true;
            this.cbxComTpPagto.Location = new System.Drawing.Point(136, 34);
            this.cbxComTpPagto.Name = "cbxComTpPagto";
            this.cbxComTpPagto.Size = new System.Drawing.Size(156, 21);
            this.cbxComTpPagto.TabIndex = 3;
            this.cbxComTpPagto.Enter += new System.EventHandler(this.cbxComTpPagto_Enter);
            this.cbxComTpPagto.Leave += new System.EventHandler(this.cbxComTpPagto_Leave);
            // 
            // lblComParcelas
            // 
            this.lblComParcelas.AutoSize = true;
            this.lblComParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComParcelas.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComParcelas.Location = new System.Drawing.Point(6, 18);
            this.lblComParcelas.Name = "lblComParcelas";
            this.lblComParcelas.Size = new System.Drawing.Size(56, 13);
            this.lblComParcelas.TabIndex = 0;
            this.lblComParcelas.Text = "Parcelas";
            // 
            // lblComTpPagto
            // 
            this.lblComTpPagto.AutoSize = true;
            this.lblComTpPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComTpPagto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComTpPagto.Location = new System.Drawing.Point(133, 18);
            this.lblComTpPagto.Name = "lblComTpPagto";
            this.lblComTpPagto.Size = new System.Drawing.Size(73, 13);
            this.lblComTpPagto.TabIndex = 2;
            this.lblComTpPagto.Text = "Tipo Pagto.";
            // 
            // dgvComItens
            // 
            this.dgvComItens.AllowUserToAddRows = false;
            this.dgvComItens.AllowUserToDeleteRows = false;
            this.dgvComItens.AllowUserToResizeColumns = false;
            this.dgvComItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvComItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itcstatus,
            this.itemLista,
            this.prodCod,
            this.prodDescricao,
            this.prodQuantidade,
            this.prodUndmed,
            this.dep_abreviacao,
            this.prodVlUnit,
            this.prodVlTotal});
            this.dgvComItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComItens.Location = new System.Drawing.Point(17, 284);
            this.dgvComItens.MultiSelect = false;
            this.dgvComItens.Name = "dgvComItens";
            this.dgvComItens.RowHeadersVisible = false;
            this.dgvComItens.RowTemplate.Height = 18;
            this.dgvComItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComItens.Size = new System.Drawing.Size(711, 245);
            this.dgvComItens.TabIndex = 40;
            this.dgvComItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComItens_CellDoubleClick);
            // 
            // itcstatus
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.itcstatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.itcstatus.HeaderText = "St.";
            this.itcstatus.MaxInputLength = 2;
            this.itcstatus.Name = "itcstatus";
            this.itcstatus.Width = 30;
            // 
            // itemLista
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemLista.HeaderText = "Item";
            this.itemLista.Name = "itemLista";
            this.itemLista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemLista.Width = 40;
            // 
            // prodCod
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prodCod.DefaultCellStyle = dataGridViewCellStyle4;
            this.prodCod.HeaderText = "Produto";
            this.prodCod.Name = "prodCod";
            this.prodCod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prodCod.Width = 60;
            // 
            // prodDescricao
            // 
            this.prodDescricao.HeaderText = "Descrição";
            this.prodDescricao.MaxInputLength = 95;
            this.prodDescricao.Name = "prodDescricao";
            this.prodDescricao.Width = 245;
            // 
            // prodQuantidade
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prodQuantidade.DefaultCellStyle = dataGridViewCellStyle5;
            this.prodQuantidade.HeaderText = "Quantidade";
            this.prodQuantidade.Name = "prodQuantidade";
            this.prodQuantidade.Width = 80;
            // 
            // prodUndmed
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prodUndmed.DefaultCellStyle = dataGridViewCellStyle6;
            this.prodUndmed.HeaderText = "U.M.";
            this.prodUndmed.Name = "prodUndmed";
            this.prodUndmed.Width = 60;
            // 
            // dep_abreviacao
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dep_abreviacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.dep_abreviacao.HeaderText = "Depósito";
            this.dep_abreviacao.MaxInputLength = 4;
            this.dep_abreviacao.Name = "dep_abreviacao";
            this.dep_abreviacao.ReadOnly = true;
            this.dep_abreviacao.Width = 60;
            // 
            // prodVlUnit
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prodVlUnit.DefaultCellStyle = dataGridViewCellStyle8;
            this.prodVlUnit.HeaderText = "Valor Unit.";
            this.prodVlUnit.Name = "prodVlUnit";
            this.prodVlUnit.Width = 80;
            // 
            // prodVlTotal
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.prodVlTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.prodVlTotal.HeaderText = "Valor Total";
            this.prodVlTotal.Name = "prodVlTotal";
            // 
            // txbComNf
            // 
            this.txbComNf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComNf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComNf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComNf.Location = new System.Drawing.Point(153, 32);
            this.txbComNf.Name = "txbComNf";
            this.txbComNf.Size = new System.Drawing.Size(85, 20);
            this.txbComNf.TabIndex = 3;
            this.txbComNf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbComNf.Enter += new System.EventHandler(this.txbComNf_Enter);
            this.txbComNf.Leave += new System.EventHandler(this.txbComNf_Leave);
            // 
            // lblComNf
            // 
            this.lblComNf.AutoSize = true;
            this.lblComNf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComNf.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComNf.Location = new System.Drawing.Point(150, 16);
            this.lblComNf.Name = "lblComNf";
            this.lblComNf.Size = new System.Drawing.Size(73, 13);
            this.lblComNf.TabIndex = 2;
            this.lblComNf.Text = "Nota Físcal";
            // 
            // btnComLocForn
            // 
            this.btnComLocForn.BackColor = System.Drawing.Color.Gray;
            this.btnComLocForn.FlatAppearance.BorderSize = 0;
            this.btnComLocForn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnComLocForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComLocForn.Location = new System.Drawing.Point(109, 81);
            this.btnComLocForn.Name = "btnComLocForn";
            this.btnComLocForn.Size = new System.Drawing.Size(20, 20);
            this.btnComLocForn.TabIndex = 10;
            this.btnComLocForn.TabStop = false;
            this.btnComLocForn.UseVisualStyleBackColor = false;
            this.btnComLocForn.Click += new System.EventHandler(this.btnComLocForn_Click);
            this.btnComLocForn.Enter += new System.EventHandler(this.btnComLocForn_Enter);
            this.btnComLocForn.Leave += new System.EventHandler(this.btnComLocForn_Leave);
            // 
            // lblComForn
            // 
            this.lblComForn.AutoSize = true;
            this.lblComForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComForn.Location = new System.Drawing.Point(140, 85);
            this.lblComForn.Name = "lblComForn";
            this.lblComForn.Size = new System.Drawing.Size(198, 16);
            this.lblComForn.TabIndex = 9;
            this.lblComForn.Text = "Informe o código do fornecedor.";
            // 
            // gbxComCompra
            // 
            this.gbxComCompra.Controls.Add(this.txbComTm);
            this.gbxComCompra.Controls.Add(this.lblComTm);
            this.gbxComCompra.Controls.Add(this.lblComCod);
            this.gbxComCompra.Controls.Add(this.lblComForn);
            this.gbxComCompra.Controls.Add(this.txbComCod);
            this.gbxComCompra.Controls.Add(this.btnComLocForn);
            this.gbxComCompra.Controls.Add(this.lblComFornecedor);
            this.gbxComCompra.Controls.Add(this.txbComNf);
            this.gbxComCompra.Controls.Add(this.txbComCodForn);
            this.gbxComCompra.Controls.Add(this.lblComNf);
            this.gbxComCompra.Controls.Add(this.dtpkDtCompra);
            this.gbxComCompra.Controls.Add(this.lblDtCompra);
            this.gbxComCompra.Location = new System.Drawing.Point(17, 11);
            this.gbxComCompra.Name = "gbxComCompra";
            this.gbxComCompra.Size = new System.Drawing.Size(711, 117);
            this.gbxComCompra.TabIndex = 0;
            this.gbxComCompra.TabStop = false;
            // 
            // txbComTm
            // 
            this.txbComTm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComTm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComTm.Enabled = false;
            this.txbComTm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComTm.Location = new System.Drawing.Point(261, 32);
            this.txbComTm.Name = "txbComTm";
            this.txbComTm.Size = new System.Drawing.Size(22, 20);
            this.txbComTm.TabIndex = 5;
            this.txbComTm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbComTm.Enter += new System.EventHandler(this.txbComTm_Enter);
            this.txbComTm.Leave += new System.EventHandler(this.txbComTm_Leave);
            // 
            // lblComTm
            // 
            this.lblComTm.AutoSize = true;
            this.lblComTm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComTm.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComTm.Location = new System.Drawing.Point(258, 16);
            this.lblComTm.Name = "lblComTm";
            this.lblComTm.Size = new System.Drawing.Size(25, 13);
            this.lblComTm.TabIndex = 4;
            this.lblComTm.Text = "TM";
            // 
            // gbxComProduto
            // 
            this.gbxComProduto.Controls.Add(this.cbxComDeProd);
            this.gbxComProduto.Controls.Add(this.label3);
            this.gbxComProduto.Controls.Add(this.cbxComUmProd);
            this.gbxComProduto.Controls.Add(this.label1);
            this.gbxComProduto.Controls.Add(this.btnComProdIncluir);
            this.gbxComProduto.Controls.Add(this.lblComVlUnit);
            this.gbxComProduto.Controls.Add(this.txbComVlUnit);
            this.gbxComProduto.Controls.Add(this.lblComQuantProd);
            this.gbxComProduto.Controls.Add(this.txbComQuantProd);
            this.gbxComProduto.Controls.Add(this.lblComProd);
            this.gbxComProduto.Controls.Add(this.btnComLocProd);
            this.gbxComProduto.Controls.Add(this.lblComProduto);
            this.gbxComProduto.Controls.Add(this.txbComCodProd);
            this.gbxComProduto.Location = new System.Drawing.Point(17, 134);
            this.gbxComProduto.Name = "gbxComProduto";
            this.gbxComProduto.Size = new System.Drawing.Size(711, 118);
            this.gbxComProduto.TabIndex = 1;
            this.gbxComProduto.TabStop = false;
            // 
            // cbxComDeProd
            // 
            this.cbxComDeProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComDeProd.FormattingEnabled = true;
            this.cbxComDeProd.Location = new System.Drawing.Point(9, 83);
            this.cbxComDeProd.Name = "cbxComDeProd";
            this.cbxComDeProd.Size = new System.Drawing.Size(70, 21);
            this.cbxComDeProd.TabIndex = 5;
            this.cbxComDeProd.Enter += new System.EventHandler(this.cbxComDeProd_Enter);
            this.cbxComDeProd.Leave += new System.EventHandler(this.cbxComDeProd_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dep.";
            // 
            // cbxComUmProd
            // 
            this.cbxComUmProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComUmProd.Enabled = false;
            this.cbxComUmProd.FormattingEnabled = true;
            this.cbxComUmProd.Location = new System.Drawing.Point(179, 83);
            this.cbxComUmProd.Name = "cbxComUmProd";
            this.cbxComUmProd.Size = new System.Drawing.Size(59, 21);
            this.cbxComUmProd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(176, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "U.M.";
            // 
            // btnComProdIncluir
            // 
            this.btnComProdIncluir.BackColor = System.Drawing.Color.Gray;
            this.btnComProdIncluir.FlatAppearance.BorderSize = 0;
            this.btnComProdIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnComProdIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComProdIncluir.Location = new System.Drawing.Point(346, 83);
            this.btnComProdIncluir.Name = "btnComProdIncluir";
            this.btnComProdIncluir.Size = new System.Drawing.Size(75, 20);
            this.btnComProdIncluir.TabIndex = 12;
            this.btnComProdIncluir.UseVisualStyleBackColor = false;
            this.btnComProdIncluir.Click += new System.EventHandler(this.btnComProdIncluir_Click);
            // 
            // lblComVlUnit
            // 
            this.lblComVlUnit.AutoSize = true;
            this.lblComVlUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComVlUnit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComVlUnit.Location = new System.Drawing.Point(241, 67);
            this.lblComVlUnit.Name = "lblComVlUnit";
            this.lblComVlUnit.Size = new System.Drawing.Size(67, 13);
            this.lblComVlUnit.TabIndex = 10;
            this.lblComVlUnit.Text = "Valor Unit.";
            // 
            // txbComVlUnit
            // 
            this.txbComVlUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComVlUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComVlUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComVlUnit.Location = new System.Drawing.Point(244, 83);
            this.txbComVlUnit.Name = "txbComVlUnit";
            this.txbComVlUnit.Size = new System.Drawing.Size(94, 20);
            this.txbComVlUnit.TabIndex = 11;
            this.txbComVlUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbComVlUnit.Enter += new System.EventHandler(this.txbComVlUnit_Enter);
            this.txbComVlUnit.Leave += new System.EventHandler(this.txbComVlUnit_Leave);
            // 
            // lblComQuantProd
            // 
            this.lblComQuantProd.AutoSize = true;
            this.lblComQuantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComQuantProd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComQuantProd.Location = new System.Drawing.Point(82, 67);
            this.lblComQuantProd.Name = "lblComQuantProd";
            this.lblComQuantProd.Size = new System.Drawing.Size(45, 13);
            this.lblComQuantProd.TabIndex = 6;
            this.lblComQuantProd.Text = "Quant.";
            // 
            // txbComQuantProd
            // 
            this.txbComQuantProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComQuantProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComQuantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComQuantProd.Location = new System.Drawing.Point(85, 83);
            this.txbComQuantProd.Name = "txbComQuantProd";
            this.txbComQuantProd.Size = new System.Drawing.Size(88, 20);
            this.txbComQuantProd.TabIndex = 7;
            this.txbComQuantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbComQuantProd.Enter += new System.EventHandler(this.txbComQuantProd_Enter);
            this.txbComQuantProd.Leave += new System.EventHandler(this.txbComQuantProd_Leave);
            // 
            // lblComProd
            // 
            this.lblComProd.AutoSize = true;
            this.lblComProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComProd.Location = new System.Drawing.Point(140, 35);
            this.lblComProd.Name = "lblComProd";
            this.lblComProd.Size = new System.Drawing.Size(179, 16);
            this.lblComProd.TabIndex = 3;
            this.lblComProd.Text = "Informe o código do produto.";
            // 
            // btnComLocProd
            // 
            this.btnComLocProd.BackColor = System.Drawing.Color.Gray;
            this.btnComLocProd.FlatAppearance.BorderSize = 0;
            this.btnComLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnComLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComLocProd.Location = new System.Drawing.Point(109, 32);
            this.btnComLocProd.Name = "btnComLocProd";
            this.btnComLocProd.Size = new System.Drawing.Size(20, 20);
            this.btnComLocProd.TabIndex = 2;
            this.btnComLocProd.TabStop = false;
            this.btnComLocProd.UseVisualStyleBackColor = false;
            this.btnComLocProd.Click += new System.EventHandler(this.btnComLocProd_Click);
            this.btnComLocProd.Enter += new System.EventHandler(this.btnComLocProd_Enter);
            this.btnComLocProd.Leave += new System.EventHandler(this.btnComLocProd_Leave);
            // 
            // lblComProduto
            // 
            this.lblComProduto.AutoSize = true;
            this.lblComProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComProduto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComProduto.Location = new System.Drawing.Point(6, 16);
            this.lblComProduto.Name = "lblComProduto";
            this.lblComProduto.Size = new System.Drawing.Size(81, 13);
            this.lblComProduto.TabIndex = 0;
            this.lblComProduto.Text = "Cód. Produto";
            // 
            // txbComCodProd
            // 
            this.txbComCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbComCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbComCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComCodProd.Location = new System.Drawing.Point(9, 32);
            this.txbComCodProd.Name = "txbComCodProd";
            this.txbComCodProd.Size = new System.Drawing.Size(98, 20);
            this.txbComCodProd.TabIndex = 1;
            this.txbComCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbComCodProd.Enter += new System.EventHandler(this.txbComCodProd_Enter);
            this.txbComCodProd.Leave += new System.EventHandler(this.txbComCodProd_Leave);
            // 
            // gbxComVencimentos
            // 
            this.gbxComVencimentos.Controls.Add(this.btnComGerarParcelas);
            this.gbxComVencimentos.Controls.Add(this.lblComParcelas);
            this.gbxComVencimentos.Controls.Add(this.lblComTotal);
            this.gbxComVencimentos.Controls.Add(this.txbComTotalCompra);
            this.gbxComVencimentos.Controls.Add(this.dtpkDtVencPriPar);
            this.gbxComVencimentos.Controls.Add(this.lblComTpPagto);
            this.gbxComVencimentos.Controls.Add(this.label4);
            this.gbxComVencimentos.Controls.Add(this.cbxComParcelas);
            this.gbxComVencimentos.Controls.Add(this.cbxComTpPagto);
            this.gbxComVencimentos.Location = new System.Drawing.Point(17, 535);
            this.gbxComVencimentos.Name = "gbxComVencimentos";
            this.gbxComVencimentos.Size = new System.Drawing.Size(711, 71);
            this.gbxComVencimentos.TabIndex = 2;
            this.gbxComVencimentos.TabStop = false;
            // 
            // btnComGerarParcelas
            // 
            this.btnComGerarParcelas.BackColor = System.Drawing.Color.Gray;
            this.btnComGerarParcelas.FlatAppearance.BorderSize = 0;
            this.btnComGerarParcelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnComGerarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComGerarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComGerarParcelas.ForeColor = System.Drawing.Color.White;
            this.btnComGerarParcelas.Location = new System.Drawing.Point(441, 19);
            this.btnComGerarParcelas.Name = "btnComGerarParcelas";
            this.btnComGerarParcelas.Size = new System.Drawing.Size(111, 36);
            this.btnComGerarParcelas.TabIndex = 8;
            this.btnComGerarParcelas.Text = "Gerar Parcelas";
            this.btnComGerarParcelas.UseVisualStyleBackColor = false;
            this.btnComGerarParcelas.Click += new System.EventHandler(this.btnComGerarParcelas_Click);
            // 
            // lblComItensCompra
            // 
            this.lblComItensCompra.AutoSize = true;
            this.lblComItensCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComItensCompra.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComItensCompra.Location = new System.Drawing.Point(14, 268);
            this.lblComItensCompra.Name = "lblComItensCompra";
            this.lblComItensCompra.Size = new System.Drawing.Size(99, 13);
            this.lblComItensCompra.TabIndex = 29;
            this.lblComItensCompra.Text = "Itens da Compra";
            // 
            // pnlParcelas
            // 
            this.pnlParcelas.AutoScroll = true;
            this.pnlParcelas.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlParcelas.Controls.Add(this.lblComTlParcelas);
            this.pnlParcelas.Controls.Add(this.label2);
            this.pnlParcelas.Controls.Add(this.dgvComParcelas);
            this.pnlParcelas.Controls.Add(this.lblPclTitulo);
            this.pnlParcelas.Location = new System.Drawing.Point(12, 723);
            this.pnlParcelas.Name = "pnlParcelas";
            this.pnlParcelas.Size = new System.Drawing.Size(745, 265);
            this.pnlParcelas.TabIndex = 4;
            // 
            // lblComTlParcelas
            // 
            this.lblComTlParcelas.AutoSize = true;
            this.lblComTlParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComTlParcelas.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComTlParcelas.Location = new System.Drawing.Point(671, 238);
            this.lblComTlParcelas.Name = "lblComTlParcelas";
            this.lblComTlParcelas.Size = new System.Drawing.Size(0, 13);
            this.lblComTlParcelas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(524, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Parcelas:  R$";
            // 
            // dgvComParcelas
            // 
            this.dgvComParcelas.AllowUserToAddRows = false;
            this.dgvComParcelas.AllowUserToDeleteRows = false;
            this.dgvComParcelas.AllowUserToResizeColumns = false;
            this.dgvComParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvComParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvComParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcostatus,
            this.pco_cod,
            this.pco_valor,
            this.pco_datavecto});
            this.dgvComParcelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComParcelas.Location = new System.Drawing.Point(17, 29);
            this.dgvComParcelas.MultiSelect = false;
            this.dgvComParcelas.Name = "dgvComParcelas";
            this.dgvComParcelas.RowHeadersVisible = false;
            this.dgvComParcelas.RowTemplate.Height = 18;
            this.dgvComParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComParcelas.Size = new System.Drawing.Size(711, 196);
            this.dgvComParcelas.TabIndex = 2;
            // 
            // pcostatus
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.pcostatus.DefaultCellStyle = dataGridViewCellStyle11;
            this.pcostatus.HeaderText = "St.";
            this.pcostatus.MaxInputLength = 2;
            this.pcostatus.Name = "pcostatus";
            this.pcostatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pcostatus.Width = 30;
            // 
            // pco_cod
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pco_cod.DefaultCellStyle = dataGridViewCellStyle12;
            this.pco_cod.HeaderText = "Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pco_cod.Width = 60;
            // 
            // pco_valor
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pco_valor.DefaultCellStyle = dataGridViewCellStyle13;
            this.pco_valor.HeaderText = "Vl. Parcela";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pco_datavecto
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.pco_datavecto.DefaultCellStyle = dataGridViewCellStyle14;
            this.pco_datavecto.HeaderText = "Dt. Vencimento";
            this.pco_datavecto.Name = "pco_datavecto";
            this.pco_datavecto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pco_datavecto.Width = 110;
            // 
            // lblPclTitulo
            // 
            this.lblPclTitulo.AutoSize = true;
            this.lblPclTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPclTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPclTitulo.Location = new System.Drawing.Point(14, 13);
            this.lblPclTitulo.Name = "lblPclTitulo";
            this.lblPclTitulo.Size = new System.Drawing.Size(128, 13);
            this.lblPclTitulo.TabIndex = 1;
            this.lblPclTitulo.Text = "Dados do Pagamento";
            // 
            // frmMovimentacaoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(871, 741);
            this.Controls.Add(this.pnlParcelas);
            this.Name = "frmMovimentacaoCompra";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmMovimentacaoCompra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovimentacaoCompra_KeyDown);
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.pnlDados, 0);
            this.Controls.SetChildIndex(this.pnlParcelas, 0);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComItens)).EndInit();
            this.gbxComCompra.ResumeLayout(false);
            this.gbxComCompra.PerformLayout();
            this.gbxComProduto.ResumeLayout(false);
            this.gbxComProduto.PerformLayout();
            this.gbxComVencimentos.ResumeLayout(false);
            this.gbxComVencimentos.PerformLayout();
            this.pnlParcelas.ResumeLayout(false);
            this.pnlParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbComCod;
        private System.Windows.Forms.Label lblComCod;
        private System.Windows.Forms.DataGridView dgvComItens;
        private System.Windows.Forms.Label lblComTpPagto;
        private System.Windows.Forms.Label lblComParcelas;
        private System.Windows.Forms.ComboBox cbxComTpPagto;
        private System.Windows.Forms.ComboBox cbxComParcelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkDtVencPriPar;
        private System.Windows.Forms.Label lblDtCompra;
        private System.Windows.Forms.TextBox txbComTotalCompra;
        private System.Windows.Forms.Label lblComTotal;
        private System.Windows.Forms.DateTimePicker dtpkDtCompra;
        private System.Windows.Forms.TextBox txbComCodForn;
        private System.Windows.Forms.Label lblComFornecedor;
        private System.Windows.Forms.Label lblComForn;
        private System.Windows.Forms.Button btnComLocForn;
        private System.Windows.Forms.TextBox txbComNf;
        private System.Windows.Forms.Label lblComNf;
        private System.Windows.Forms.GroupBox gbxComCompra;
        private System.Windows.Forms.GroupBox gbxComProduto;
        private System.Windows.Forms.Label lblComProd;
        private System.Windows.Forms.Button btnComLocProd;
        private System.Windows.Forms.Label lblComProduto;
        private System.Windows.Forms.TextBox txbComCodProd;
        private System.Windows.Forms.Label lblComVlUnit;
        private System.Windows.Forms.TextBox txbComVlUnit;
        private System.Windows.Forms.Label lblComQuantProd;
        private System.Windows.Forms.TextBox txbComQuantProd;
        private System.Windows.Forms.GroupBox gbxComVencimentos;
        private System.Windows.Forms.Label lblComItensCompra;
        private System.Windows.Forms.Button btnComProdIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxComUmProd;
        private System.Windows.Forms.Panel pnlParcelas;
        private System.Windows.Forms.DataGridView dgvComParcelas;
        private System.Windows.Forms.Label lblPclTitulo;
        private System.Windows.Forms.Button btnComGerarParcelas;
        private System.Windows.Forms.Label lblComTlParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbComTm;
        private System.Windows.Forms.Label lblComTm;
        private System.Windows.Forms.ComboBox cbxComDeProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn itcstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodUndmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_abreviacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVlUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVlTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcostatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datavecto;
    }
}
