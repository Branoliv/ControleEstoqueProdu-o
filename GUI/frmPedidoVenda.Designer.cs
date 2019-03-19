namespace GUI
{
    partial class frmPedidoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblComTotal = new System.Windows.Forms.Label();
            this.txbPedVenTotalCompra = new System.Windows.Forms.TextBox();
            this.lblPedVenItensCompra = new System.Windows.Forms.Label();
            this.dgvPedVenItens = new System.Windows.Forms.DataGridView();
            this.gbxPedVenProduto = new System.Windows.Forms.GroupBox();
            this.cbxPedVenDepProd = new System.Windows.Forms.ComboBox();
            this.lblPedVenDep = new System.Windows.Forms.Label();
            this.cbxPedVenUmProd = new System.Windows.Forms.ComboBox();
            this.lblPedVenUnidMed = new System.Windows.Forms.Label();
            this.btnPedVenProdIncluir = new System.Windows.Forms.Button();
            this.lblPedVenVlUnit = new System.Windows.Forms.Label();
            this.txbPedVenVlUnit = new System.Windows.Forms.TextBox();
            this.lblPedVenQuantProd = new System.Windows.Forms.Label();
            this.txbPedVenQuantProd = new System.Windows.Forms.TextBox();
            this.lblPedVenProdNome = new System.Windows.Forms.Label();
            this.btnPedVenLocProd = new System.Windows.Forms.Button();
            this.lblPedVenProduto = new System.Windows.Forms.Label();
            this.txbPedVenCodProd = new System.Windows.Forms.TextBox();
            this.gbxPedVendDadosCli = new System.Windows.Forms.GroupBox();
            this.dtpkPedVenDtEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblPedVenDtEntrega = new System.Windows.Forms.Label();
            this.lblPedVenCod = new System.Windows.Forms.Label();
            this.lblPedVenCliNome = new System.Windows.Forms.Label();
            this.txbPedVenCod = new System.Windows.Forms.TextBox();
            this.btnPedVenLocCli = new System.Windows.Forms.Button();
            this.lblPedVenCliente = new System.Windows.Forms.Label();
            this.txbPedVenCodCli = new System.Windows.Forms.TextBox();
            this.dtpkPedVenData = new System.Windows.Forms.DateTimePicker();
            this.lblPedVenData = new System.Windows.Forms.Label();
            this.itemLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodUndmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_abreviacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVlUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItnsCancelar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedVenItens)).BeginInit();
            this.gbxPedVenProduto.SuspendLayout();
            this.gbxPedVendDadosCli.SuspendLayout();
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
            this.pnlBotao.Size = new System.Drawing.Size(846, 68);
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
            this.btnSair.Location = new System.Drawing.Point(771, 0);
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.pnlDados.Controls.Add(this.lblComTotal);
            this.pnlDados.Controls.Add(this.txbPedVenTotalCompra);
            this.pnlDados.Controls.Add(this.lblPedVenItensCompra);
            this.pnlDados.Controls.Add(this.dgvPedVenItens);
            this.pnlDados.Controls.Add(this.gbxPedVenProduto);
            this.pnlDados.Controls.Add(this.gbxPedVendDadosCli);
            this.pnlDados.Location = new System.Drawing.Point(12, 74);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(813, 592);
            this.pnlDados.TabIndex = 0;
            // 
            // lblComTotal
            // 
            this.lblComTotal.AutoSize = true;
            this.lblComTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComTotal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComTotal.Location = new System.Drawing.Point(670, 539);
            this.lblComTotal.Name = "lblComTotal";
            this.lblComTotal.Size = new System.Drawing.Size(36, 13);
            this.lblComTotal.TabIndex = 42;
            this.lblComTotal.Text = "Total";
            // 
            // txbPedVenTotalCompra
            // 
            this.txbPedVenTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPedVenTotalCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPedVenTotalCompra.Enabled = false;
            this.txbPedVenTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPedVenTotalCompra.Location = new System.Drawing.Point(673, 555);
            this.txbPedVenTotalCompra.Name = "txbPedVenTotalCompra";
            this.txbPedVenTotalCompra.Size = new System.Drawing.Size(98, 20);
            this.txbPedVenTotalCompra.TabIndex = 43;
            this.txbPedVenTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPedVenItensCompra
            // 
            this.lblPedVenItensCompra.AutoSize = true;
            this.lblPedVenItensCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenItensCompra.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenItensCompra.Location = new System.Drawing.Point(10, 269);
            this.lblPedVenItensCompra.Name = "lblPedVenItensCompra";
            this.lblPedVenItensCompra.Size = new System.Drawing.Size(99, 13);
            this.lblPedVenItensCompra.TabIndex = 41;
            this.lblPedVenItensCompra.Text = "Itens da Compra";
            // 
            // dgvPedVenItens
            // 
            this.dgvPedVenItens.AllowUserToAddRows = false;
            this.dgvPedVenItens.AllowUserToDeleteRows = false;
            this.dgvPedVenItens.AllowUserToResizeColumns = false;
            this.dgvPedVenItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedVenItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedVenItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedVenItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemLista,
            this.prodCod,
            this.prodDescricao,
            this.prodQuantidade,
            this.prodUndmed,
            this.dep_abreviacao,
            this.prodVlUnit,
            this.prodVlTotal,
            this.dgvItnsCancelar});
            this.dgvPedVenItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedVenItens.Location = new System.Drawing.Point(13, 285);
            this.dgvPedVenItens.MultiSelect = false;
            this.dgvPedVenItens.Name = "dgvPedVenItens";
            this.dgvPedVenItens.RowHeadersVisible = false;
            this.dgvPedVenItens.RowTemplate.Height = 18;
            this.dgvPedVenItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedVenItens.Size = new System.Drawing.Size(786, 245);
            this.dgvPedVenItens.TabIndex = 2;
            this.dgvPedVenItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedVenItens_CellContentClick);
            // 
            // gbxPedVenProduto
            // 
            this.gbxPedVenProduto.Controls.Add(this.cbxPedVenDepProd);
            this.gbxPedVenProduto.Controls.Add(this.lblPedVenDep);
            this.gbxPedVenProduto.Controls.Add(this.cbxPedVenUmProd);
            this.gbxPedVenProduto.Controls.Add(this.lblPedVenUnidMed);
            this.gbxPedVenProduto.Controls.Add(this.btnPedVenProdIncluir);
            this.gbxPedVenProduto.Controls.Add(this.lblPedVenVlUnit);
            this.gbxPedVenProduto.Controls.Add(this.txbPedVenVlUnit);
            this.gbxPedVenProduto.Controls.Add(this.lblPedVenQuantProd);
            this.gbxPedVenProduto.Controls.Add(this.txbPedVenQuantProd);
            this.gbxPedVenProduto.Controls.Add(this.lblPedVenProdNome);
            this.gbxPedVenProduto.Controls.Add(this.btnPedVenLocProd);
            this.gbxPedVenProduto.Controls.Add(this.lblPedVenProduto);
            this.gbxPedVenProduto.Controls.Add(this.txbPedVenCodProd);
            this.gbxPedVenProduto.Location = new System.Drawing.Point(13, 135);
            this.gbxPedVenProduto.Name = "gbxPedVenProduto";
            this.gbxPedVenProduto.Size = new System.Drawing.Size(786, 118);
            this.gbxPedVenProduto.TabIndex = 1;
            this.gbxPedVenProduto.TabStop = false;
            // 
            // cbxPedVenDepProd
            // 
            this.cbxPedVenDepProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPedVenDepProd.FormattingEnabled = true;
            this.cbxPedVenDepProd.Location = new System.Drawing.Point(9, 83);
            this.cbxPedVenDepProd.Name = "cbxPedVenDepProd";
            this.cbxPedVenDepProd.Size = new System.Drawing.Size(70, 21);
            this.cbxPedVenDepProd.TabIndex = 5;
            this.cbxPedVenDepProd.Enter += new System.EventHandler(this.cbxPedVenDepProd_Enter);
            this.cbxPedVenDepProd.Leave += new System.EventHandler(this.cbxPedVenDepProd_Leave);
            // 
            // lblPedVenDep
            // 
            this.lblPedVenDep.AutoSize = true;
            this.lblPedVenDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenDep.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenDep.Location = new System.Drawing.Point(6, 67);
            this.lblPedVenDep.Name = "lblPedVenDep";
            this.lblPedVenDep.Size = new System.Drawing.Size(34, 13);
            this.lblPedVenDep.TabIndex = 4;
            this.lblPedVenDep.Text = "Dep.";
            // 
            // cbxPedVenUmProd
            // 
            this.cbxPedVenUmProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPedVenUmProd.Enabled = false;
            this.cbxPedVenUmProd.FormattingEnabled = true;
            this.cbxPedVenUmProd.Location = new System.Drawing.Point(179, 83);
            this.cbxPedVenUmProd.Name = "cbxPedVenUmProd";
            this.cbxPedVenUmProd.Size = new System.Drawing.Size(59, 21);
            this.cbxPedVenUmProd.TabIndex = 9;
            this.cbxPedVenUmProd.Enter += new System.EventHandler(this.cbxPedVenUmProd_Enter);
            this.cbxPedVenUmProd.Leave += new System.EventHandler(this.cbxPedVenUmProd_Leave);
            // 
            // lblPedVenUnidMed
            // 
            this.lblPedVenUnidMed.AutoSize = true;
            this.lblPedVenUnidMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenUnidMed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenUnidMed.Location = new System.Drawing.Point(176, 67);
            this.lblPedVenUnidMed.Name = "lblPedVenUnidMed";
            this.lblPedVenUnidMed.Size = new System.Drawing.Size(34, 13);
            this.lblPedVenUnidMed.TabIndex = 8;
            this.lblPedVenUnidMed.Text = "U.M.";
            // 
            // btnPedVenProdIncluir
            // 
            this.btnPedVenProdIncluir.BackColor = System.Drawing.Color.Gray;
            this.btnPedVenProdIncluir.FlatAppearance.BorderSize = 0;
            this.btnPedVenProdIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPedVenProdIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedVenProdIncluir.Location = new System.Drawing.Point(346, 83);
            this.btnPedVenProdIncluir.Name = "btnPedVenProdIncluir";
            this.btnPedVenProdIncluir.Size = new System.Drawing.Size(75, 20);
            this.btnPedVenProdIncluir.TabIndex = 12;
            this.btnPedVenProdIncluir.UseVisualStyleBackColor = false;
            this.btnPedVenProdIncluir.Click += new System.EventHandler(this.btnPedVenProdIncluir_Click);
            // 
            // lblPedVenVlUnit
            // 
            this.lblPedVenVlUnit.AutoSize = true;
            this.lblPedVenVlUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenVlUnit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenVlUnit.Location = new System.Drawing.Point(241, 67);
            this.lblPedVenVlUnit.Name = "lblPedVenVlUnit";
            this.lblPedVenVlUnit.Size = new System.Drawing.Size(67, 13);
            this.lblPedVenVlUnit.TabIndex = 10;
            this.lblPedVenVlUnit.Text = "Valor Unit.";
            // 
            // txbPedVenVlUnit
            // 
            this.txbPedVenVlUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPedVenVlUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPedVenVlUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPedVenVlUnit.Location = new System.Drawing.Point(244, 83);
            this.txbPedVenVlUnit.Name = "txbPedVenVlUnit";
            this.txbPedVenVlUnit.Size = new System.Drawing.Size(94, 20);
            this.txbPedVenVlUnit.TabIndex = 11;
            this.txbPedVenVlUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPedVenVlUnit.Enter += new System.EventHandler(this.txbPedVenVlUnit_Enter);
            this.txbPedVenVlUnit.Leave += new System.EventHandler(this.txbPedVenVlUnit_Leave);
            // 
            // lblPedVenQuantProd
            // 
            this.lblPedVenQuantProd.AutoSize = true;
            this.lblPedVenQuantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenQuantProd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenQuantProd.Location = new System.Drawing.Point(82, 67);
            this.lblPedVenQuantProd.Name = "lblPedVenQuantProd";
            this.lblPedVenQuantProd.Size = new System.Drawing.Size(45, 13);
            this.lblPedVenQuantProd.TabIndex = 6;
            this.lblPedVenQuantProd.Text = "Quant.";
            // 
            // txbPedVenQuantProd
            // 
            this.txbPedVenQuantProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPedVenQuantProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPedVenQuantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPedVenQuantProd.Location = new System.Drawing.Point(85, 83);
            this.txbPedVenQuantProd.Name = "txbPedVenQuantProd";
            this.txbPedVenQuantProd.Size = new System.Drawing.Size(88, 20);
            this.txbPedVenQuantProd.TabIndex = 7;
            this.txbPedVenQuantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPedVenQuantProd.Enter += new System.EventHandler(this.txbPedVenQuantProd_Enter);
            this.txbPedVenQuantProd.Leave += new System.EventHandler(this.txbPedVenQuantProd_Leave);
            // 
            // lblPedVenProdNome
            // 
            this.lblPedVenProdNome.AutoSize = true;
            this.lblPedVenProdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenProdNome.Location = new System.Drawing.Point(140, 35);
            this.lblPedVenProdNome.Name = "lblPedVenProdNome";
            this.lblPedVenProdNome.Size = new System.Drawing.Size(179, 16);
            this.lblPedVenProdNome.TabIndex = 3;
            this.lblPedVenProdNome.Text = "Informe o código do produto.";
            // 
            // btnPedVenLocProd
            // 
            this.btnPedVenLocProd.BackColor = System.Drawing.Color.Gray;
            this.btnPedVenLocProd.FlatAppearance.BorderSize = 0;
            this.btnPedVenLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPedVenLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedVenLocProd.Location = new System.Drawing.Point(109, 32);
            this.btnPedVenLocProd.Name = "btnPedVenLocProd";
            this.btnPedVenLocProd.Size = new System.Drawing.Size(20, 20);
            this.btnPedVenLocProd.TabIndex = 2;
            this.btnPedVenLocProd.TabStop = false;
            this.btnPedVenLocProd.UseVisualStyleBackColor = false;
            this.btnPedVenLocProd.Click += new System.EventHandler(this.btnPedVenLocProd_Click);
            // 
            // lblPedVenProduto
            // 
            this.lblPedVenProduto.AutoSize = true;
            this.lblPedVenProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenProduto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenProduto.Location = new System.Drawing.Point(6, 16);
            this.lblPedVenProduto.Name = "lblPedVenProduto";
            this.lblPedVenProduto.Size = new System.Drawing.Size(81, 13);
            this.lblPedVenProduto.TabIndex = 0;
            this.lblPedVenProduto.Text = "Cód. Produto";
            // 
            // txbPedVenCodProd
            // 
            this.txbPedVenCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPedVenCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPedVenCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPedVenCodProd.Location = new System.Drawing.Point(9, 32);
            this.txbPedVenCodProd.Name = "txbPedVenCodProd";
            this.txbPedVenCodProd.Size = new System.Drawing.Size(98, 20);
            this.txbPedVenCodProd.TabIndex = 1;
            this.txbPedVenCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPedVenCodProd.Enter += new System.EventHandler(this.txbPedVenCodProd_Enter);
            this.txbPedVenCodProd.Leave += new System.EventHandler(this.txbPedVenCodProd_Leave);
            // 
            // gbxPedVendDadosCli
            // 
            this.gbxPedVendDadosCli.Controls.Add(this.dtpkPedVenDtEntrega);
            this.gbxPedVendDadosCli.Controls.Add(this.lblPedVenDtEntrega);
            this.gbxPedVendDadosCli.Controls.Add(this.lblPedVenCod);
            this.gbxPedVendDadosCli.Controls.Add(this.lblPedVenCliNome);
            this.gbxPedVendDadosCli.Controls.Add(this.txbPedVenCod);
            this.gbxPedVendDadosCli.Controls.Add(this.btnPedVenLocCli);
            this.gbxPedVendDadosCli.Controls.Add(this.lblPedVenCliente);
            this.gbxPedVendDadosCli.Controls.Add(this.txbPedVenCodCli);
            this.gbxPedVendDadosCli.Controls.Add(this.dtpkPedVenData);
            this.gbxPedVendDadosCli.Controls.Add(this.lblPedVenData);
            this.gbxPedVendDadosCli.Location = new System.Drawing.Point(13, 12);
            this.gbxPedVendDadosCli.Name = "gbxPedVendDadosCli";
            this.gbxPedVendDadosCli.Size = new System.Drawing.Size(786, 117);
            this.gbxPedVendDadosCli.TabIndex = 0;
            this.gbxPedVendDadosCli.TabStop = false;
            // 
            // dtpkPedVenDtEntrega
            // 
            this.dtpkPedVenDtEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPedVenDtEntrega.Location = new System.Drawing.Point(660, 85);
            this.dtpkPedVenDtEntrega.Name = "dtpkPedVenDtEntrega";
            this.dtpkPedVenDtEntrega.Size = new System.Drawing.Size(98, 20);
            this.dtpkPedVenDtEntrega.TabIndex = 9;
            // 
            // lblPedVenDtEntrega
            // 
            this.lblPedVenDtEntrega.AutoSize = true;
            this.lblPedVenDtEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenDtEntrega.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenDtEntrega.Location = new System.Drawing.Point(657, 69);
            this.lblPedVenDtEntrega.Name = "lblPedVenDtEntrega";
            this.lblPedVenDtEntrega.Size = new System.Drawing.Size(82, 13);
            this.lblPedVenDtEntrega.TabIndex = 8;
            this.lblPedVenDtEntrega.Text = "Data Entrega";
            // 
            // lblPedVenCod
            // 
            this.lblPedVenCod.AutoSize = true;
            this.lblPedVenCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenCod.Location = new System.Drawing.Point(6, 16);
            this.lblPedVenCod.Name = "lblPedVenCod";
            this.lblPedVenCod.Size = new System.Drawing.Size(46, 13);
            this.lblPedVenCod.TabIndex = 0;
            this.lblPedVenCod.Text = "Código";
            // 
            // lblPedVenCliNome
            // 
            this.lblPedVenCliNome.AutoSize = true;
            this.lblPedVenCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenCliNome.Location = new System.Drawing.Point(140, 85);
            this.lblPedVenCliNome.Name = "lblPedVenCliNome";
            this.lblPedVenCliNome.Size = new System.Drawing.Size(172, 16);
            this.lblPedVenCliNome.TabIndex = 7;
            this.lblPedVenCliNome.Text = "Informe o código do cliente.";
            // 
            // txbPedVenCod
            // 
            this.txbPedVenCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPedVenCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPedVenCod.Enabled = false;
            this.txbPedVenCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPedVenCod.Location = new System.Drawing.Point(9, 32);
            this.txbPedVenCod.Name = "txbPedVenCod";
            this.txbPedVenCod.Size = new System.Drawing.Size(85, 20);
            this.txbPedVenCod.TabIndex = 1;
            this.txbPedVenCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPedVenCod.Enter += new System.EventHandler(this.txbPedVenCod_Enter);
            this.txbPedVenCod.Leave += new System.EventHandler(this.txbPedVenCod_Leave);
            // 
            // btnPedVenLocCli
            // 
            this.btnPedVenLocCli.BackColor = System.Drawing.Color.Gray;
            this.btnPedVenLocCli.FlatAppearance.BorderSize = 0;
            this.btnPedVenLocCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPedVenLocCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedVenLocCli.Location = new System.Drawing.Point(109, 81);
            this.btnPedVenLocCli.Name = "btnPedVenLocCli";
            this.btnPedVenLocCli.Size = new System.Drawing.Size(20, 20);
            this.btnPedVenLocCli.TabIndex = 6;
            this.btnPedVenLocCli.TabStop = false;
            this.btnPedVenLocCli.UseVisualStyleBackColor = false;
            this.btnPedVenLocCli.Click += new System.EventHandler(this.btnPedVenLocCli_Click);
            // 
            // lblPedVenCliente
            // 
            this.lblPedVenCliente.AutoSize = true;
            this.lblPedVenCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenCliente.Location = new System.Drawing.Point(6, 65);
            this.lblPedVenCliente.Name = "lblPedVenCliente";
            this.lblPedVenCliente.Size = new System.Drawing.Size(76, 13);
            this.lblPedVenCliente.TabIndex = 4;
            this.lblPedVenCliente.Text = "Cód. Cliente";
            // 
            // txbPedVenCodCli
            // 
            this.txbPedVenCodCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPedVenCodCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPedVenCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPedVenCodCli.Location = new System.Drawing.Point(9, 81);
            this.txbPedVenCodCli.Name = "txbPedVenCodCli";
            this.txbPedVenCodCli.Size = new System.Drawing.Size(98, 20);
            this.txbPedVenCodCli.TabIndex = 5;
            this.txbPedVenCodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPedVenCodCli.Enter += new System.EventHandler(this.txbPedVenCodCli_Enter);
            this.txbPedVenCodCli.Leave += new System.EventHandler(this.txbPedVenCodCli_Leave);
            // 
            // dtpkPedVenData
            // 
            this.dtpkPedVenData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkPedVenData.Location = new System.Drawing.Point(143, 32);
            this.dtpkPedVenData.Name = "dtpkPedVenData";
            this.dtpkPedVenData.Size = new System.Drawing.Size(98, 20);
            this.dtpkPedVenData.TabIndex = 3;
            // 
            // lblPedVenData
            // 
            this.lblPedVenData.AutoSize = true;
            this.lblPedVenData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedVenData.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPedVenData.Location = new System.Drawing.Point(140, 16);
            this.lblPedVenData.Name = "lblPedVenData";
            this.lblPedVenData.Size = new System.Drawing.Size(77, 13);
            this.lblPedVenData.TabIndex = 2;
            this.lblPedVenData.Text = "Data Pedido";
            // 
            // itemLista
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemLista.HeaderText = "Item";
            this.itemLista.Name = "itemLista";
            this.itemLista.ReadOnly = true;
            this.itemLista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemLista.Width = 40;
            // 
            // prodCod
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prodCod.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodCod.HeaderText = "Produto";
            this.prodCod.Name = "prodCod";
            this.prodCod.ReadOnly = true;
            this.prodCod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prodCod.Width = 60;
            // 
            // prodDescricao
            // 
            this.prodDescricao.HeaderText = "Descrição";
            this.prodDescricao.MaxInputLength = 95;
            this.prodDescricao.Name = "prodDescricao";
            this.prodDescricao.ReadOnly = true;
            this.prodDescricao.Width = 245;
            // 
            // prodQuantidade
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prodQuantidade.DefaultCellStyle = dataGridViewCellStyle4;
            this.prodQuantidade.HeaderText = "Quantidade";
            this.prodQuantidade.Name = "prodQuantidade";
            this.prodQuantidade.Width = 80;
            // 
            // prodUndmed
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prodUndmed.DefaultCellStyle = dataGridViewCellStyle5;
            this.prodUndmed.HeaderText = "U.M.";
            this.prodUndmed.Name = "prodUndmed";
            this.prodUndmed.ReadOnly = true;
            this.prodUndmed.Width = 60;
            // 
            // dep_abreviacao
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dep_abreviacao.DefaultCellStyle = dataGridViewCellStyle6;
            this.dep_abreviacao.HeaderText = "Depósito";
            this.dep_abreviacao.MaxInputLength = 4;
            this.dep_abreviacao.Name = "dep_abreviacao";
            this.dep_abreviacao.ReadOnly = true;
            this.dep_abreviacao.Width = 60;
            // 
            // prodVlUnit
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.prodVlUnit.DefaultCellStyle = dataGridViewCellStyle7;
            this.prodVlUnit.HeaderText = "Valor Unit.";
            this.prodVlUnit.Name = "prodVlUnit";
            this.prodVlUnit.ReadOnly = true;
            this.prodVlUnit.Width = 80;
            // 
            // prodVlTotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.prodVlTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.prodVlTotal.HeaderText = "Valor Total";
            this.prodVlTotal.Name = "prodVlTotal";
            this.prodVlTotal.ReadOnly = true;
            // 
            // dgvItnsCancelar
            // 
            this.dgvItnsCancelar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvItnsCancelar.FalseValue = "0";
            this.dgvItnsCancelar.HeaderText = "Cancelar";
            this.dgvItnsCancelar.IndeterminateValue = "0";
            this.dgvItnsCancelar.Name = "dgvItnsCancelar";
            this.dgvItnsCancelar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItnsCancelar.TrueValue = "1";
            this.dgvItnsCancelar.Width = 55;
            // 
            // frmPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(846, 678);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlBotao);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedido Venda";
            this.Load += new System.EventHandler(this.frmPedidoVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedidoVenda_KeyDown);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedVenItens)).EndInit();
            this.gbxPedVenProduto.ResumeLayout(false);
            this.gbxPedVenProduto.PerformLayout();
            this.gbxPedVendDadosCli.ResumeLayout(false);
            this.gbxPedVendDadosCli.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxPedVenProduto;
        private System.Windows.Forms.ComboBox cbxPedVenDepProd;
        private System.Windows.Forms.Label lblPedVenDep;
        private System.Windows.Forms.ComboBox cbxPedVenUmProd;
        private System.Windows.Forms.Label lblPedVenUnidMed;
        private System.Windows.Forms.Button btnPedVenProdIncluir;
        private System.Windows.Forms.Label lblPedVenVlUnit;
        private System.Windows.Forms.TextBox txbPedVenVlUnit;
        private System.Windows.Forms.Label lblPedVenQuantProd;
        private System.Windows.Forms.TextBox txbPedVenQuantProd;
        private System.Windows.Forms.Label lblPedVenProdNome;
        private System.Windows.Forms.Button btnPedVenLocProd;
        private System.Windows.Forms.Label lblPedVenProduto;
        private System.Windows.Forms.TextBox txbPedVenCodProd;
        private System.Windows.Forms.GroupBox gbxPedVendDadosCli;
        private System.Windows.Forms.Label lblPedVenCod;
        private System.Windows.Forms.Label lblPedVenCliNome;
        private System.Windows.Forms.TextBox txbPedVenCod;
        private System.Windows.Forms.Button btnPedVenLocCli;
        private System.Windows.Forms.Label lblPedVenCliente;
        private System.Windows.Forms.TextBox txbPedVenCodCli;
        private System.Windows.Forms.DateTimePicker dtpkPedVenData;
        private System.Windows.Forms.Label lblPedVenData;
        private System.Windows.Forms.Label lblPedVenItensCompra;
        private System.Windows.Forms.DataGridView dgvPedVenItens;
        private System.Windows.Forms.DateTimePicker dtpkPedVenDtEntrega;
        private System.Windows.Forms.Label lblPedVenDtEntrega;
        private System.Windows.Forms.Label lblComTotal;
        private System.Windows.Forms.TextBox txbPedVenTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodUndmed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_abreviacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVlUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodVlTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvItnsCancelar;
    }
}