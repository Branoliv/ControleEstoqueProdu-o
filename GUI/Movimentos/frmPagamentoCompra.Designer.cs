namespace GUI
{
    partial class frmPagamentoCompra
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
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnPgtoCompraLocalizar = new System.Windows.Forms.Button();
            this.lblComCod = new System.Windows.Forms.Label();
            this.lblPgtoComNomeForn = new System.Windows.Forms.Label();
            this.txbPgtoComCod = new System.Windows.Forms.TextBox();
            this.lblComFornecedor = new System.Windows.Forms.Label();
            this.txbPgtoComNf = new System.Windows.Forms.TextBox();
            this.txbPgtoComCodForn = new System.Windows.Forms.TextBox();
            this.lblComNf = new System.Windows.Forms.Label();
            this.dtpkDtCompra = new System.Windows.Forms.DateTimePicker();
            this.lblDtCompra = new System.Windows.Forms.Label();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblPagtoCompraAviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkDtPagtoCompra = new System.Windows.Forms.DateTimePicker();
            this.dgvPgtoComParcelas = new System.Windows.Forms.DataGridView();
            this.pco_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_Dtpagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_Dtvecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPgtoComParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.SlateGray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnEstornar);
            this.pnlBotao.Controls.Add(this.btnCancelar);
            this.pnlBotao.Controls.Add(this.btnSalvar);
            this.pnlBotao.Controls.Add(this.btnPagar);
            this.pnlBotao.Controls.Add(this.btnPgtoCompraLocalizar);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 0);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(769, 68);
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
            this.btnSair.Location = new System.Drawing.Point(694, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 68);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEstornar
            // 
            this.btnEstornar.BackColor = System.Drawing.Color.Transparent;
            this.btnEstornar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstornar.FlatAppearance.BorderSize = 0;
            this.btnEstornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEstornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstornar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstornar.Image = global::GUI.Properties.Resources.Lixoflat40x40;
            this.btnEstornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEstornar.Location = new System.Drawing.Point(300, 0);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(75, 68);
            this.btnEstornar.TabIndex = 5;
            this.btnEstornar.Text = "Estorno";
            this.btnEstornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstornar.UseVisualStyleBackColor = false;
            this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(225, 0);
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
            this.btnSalvar.Location = new System.Drawing.Point(150, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 68);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Transparent;
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagar.Image = global::GUI.Properties.Resources.inserirflat40x40;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagar.Location = new System.Drawing.Point(75, 0);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 68);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnPgtoCompraLocalizar
            // 
            this.btnPgtoCompraLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnPgtoCompraLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPgtoCompraLocalizar.FlatAppearance.BorderSize = 0;
            this.btnPgtoCompraLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPgtoCompraLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPgtoCompraLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPgtoCompraLocalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPgtoCompraLocalizar.Image = global::GUI.Properties.Resources.localizarflat40x40;
            this.btnPgtoCompraLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPgtoCompraLocalizar.Location = new System.Drawing.Point(0, 0);
            this.btnPgtoCompraLocalizar.Name = "btnPgtoCompraLocalizar";
            this.btnPgtoCompraLocalizar.Size = new System.Drawing.Size(75, 68);
            this.btnPgtoCompraLocalizar.TabIndex = 1;
            this.btnPgtoCompraLocalizar.Text = "Localizar";
            this.btnPgtoCompraLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPgtoCompraLocalizar.UseVisualStyleBackColor = false;
            this.btnPgtoCompraLocalizar.Click += new System.EventHandler(this.btnPgtoCompraLocalizar_Click);
            // 
            // lblComCod
            // 
            this.lblComCod.AutoSize = true;
            this.lblComCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComCod.Location = new System.Drawing.Point(14, 10);
            this.lblComCod.Name = "lblComCod";
            this.lblComCod.Size = new System.Drawing.Size(46, 13);
            this.lblComCod.TabIndex = 0;
            this.lblComCod.Text = "Código";
            // 
            // lblPgtoComNomeForn
            // 
            this.lblPgtoComNomeForn.AutoSize = true;
            this.lblPgtoComNomeForn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPgtoComNomeForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPgtoComNomeForn.Location = new System.Drawing.Point(233, 72);
            this.lblPgtoComNomeForn.Name = "lblPgtoComNomeForn";
            this.lblPgtoComNomeForn.Size = new System.Drawing.Size(198, 16);
            this.lblPgtoComNomeForn.TabIndex = 9;
            this.lblPgtoComNomeForn.Text = "Informe o código do fornecedor.";
            // 
            // txbPgtoComCod
            // 
            this.txbPgtoComCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPgtoComCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPgtoComCod.Enabled = false;
            this.txbPgtoComCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPgtoComCod.Location = new System.Drawing.Point(17, 26);
            this.txbPgtoComCod.Name = "txbPgtoComCod";
            this.txbPgtoComCod.Size = new System.Drawing.Size(85, 20);
            this.txbPgtoComCod.TabIndex = 1;
            this.txbPgtoComCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblComFornecedor
            // 
            this.lblComFornecedor.AutoSize = true;
            this.lblComFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComFornecedor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComFornecedor.Location = new System.Drawing.Point(112, 55);
            this.lblComFornecedor.Name = "lblComFornecedor";
            this.lblComFornecedor.Size = new System.Drawing.Size(101, 13);
            this.lblComFornecedor.TabIndex = 8;
            this.lblComFornecedor.Text = "Cód. Fornecedor";
            // 
            // txbPgtoComNf
            // 
            this.txbPgtoComNf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPgtoComNf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPgtoComNf.Enabled = false;
            this.txbPgtoComNf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPgtoComNf.Location = new System.Drawing.Point(17, 71);
            this.txbPgtoComNf.Name = "txbPgtoComNf";
            this.txbPgtoComNf.Size = new System.Drawing.Size(85, 20);
            this.txbPgtoComNf.TabIndex = 3;
            this.txbPgtoComNf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbPgtoComCodForn
            // 
            this.txbPgtoComCodForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPgtoComCodForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPgtoComCodForn.Enabled = false;
            this.txbPgtoComCodForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPgtoComCodForn.Location = new System.Drawing.Point(115, 71);
            this.txbPgtoComCodForn.Name = "txbPgtoComCodForn";
            this.txbPgtoComCodForn.Size = new System.Drawing.Size(98, 20);
            this.txbPgtoComCodForn.TabIndex = 9;
            this.txbPgtoComCodForn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblComNf
            // 
            this.lblComNf.AutoSize = true;
            this.lblComNf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComNf.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblComNf.Location = new System.Drawing.Point(14, 55);
            this.lblComNf.Name = "lblComNf";
            this.lblComNf.Size = new System.Drawing.Size(73, 13);
            this.lblComNf.TabIndex = 2;
            this.lblComNf.Text = "Nota Físcal";
            // 
            // dtpkDtCompra
            // 
            this.dtpkDtCompra.Enabled = false;
            this.dtpkDtCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDtCompra.Location = new System.Drawing.Point(115, 26);
            this.dtpkDtCompra.Name = "dtpkDtCompra";
            this.dtpkDtCompra.Size = new System.Drawing.Size(98, 20);
            this.dtpkDtCompra.TabIndex = 7;
            // 
            // lblDtCompra
            // 
            this.lblDtCompra.AutoSize = true;
            this.lblDtCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCompra.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDtCompra.Location = new System.Drawing.Point(112, 10);
            this.lblDtCompra.Name = "lblDtCompra";
            this.lblDtCompra.Size = new System.Drawing.Size(80, 13);
            this.lblDtCompra.TabIndex = 6;
            this.lblDtCompra.Text = "Data Compra";
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlDados.Controls.Add(this.lblPagtoCompraAviso);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.dtpkDtPagtoCompra);
            this.pnlDados.Controls.Add(this.lblComCod);
            this.pnlDados.Controls.Add(this.txbPgtoComCod);
            this.pnlDados.Controls.Add(this.lblPgtoComNomeForn);
            this.pnlDados.Controls.Add(this.lblDtCompra);
            this.pnlDados.Controls.Add(this.dtpkDtCompra);
            this.pnlDados.Controls.Add(this.lblComNf);
            this.pnlDados.Controls.Add(this.lblComFornecedor);
            this.pnlDados.Controls.Add(this.txbPgtoComCodForn);
            this.pnlDados.Controls.Add(this.txbPgtoComNf);
            this.pnlDados.Location = new System.Drawing.Point(12, 80);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(745, 150);
            this.pnlDados.TabIndex = 4;
            // 
            // lblPagtoCompraAviso
            // 
            this.lblPagtoCompraAviso.AutoSize = true;
            this.lblPagtoCompraAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagtoCompraAviso.ForeColor = System.Drawing.Color.Red;
            this.lblPagtoCompraAviso.Location = new System.Drawing.Point(233, 26);
            this.lblPagtoCompraAviso.Name = "lblPagtoCompraAviso";
            this.lblPagtoCompraAviso.Size = new System.Drawing.Size(124, 15);
            this.lblPagtoCompraAviso.TabIndex = 13;
            this.lblPagtoCompraAviso.Text = "lblPagtoCompraAviso";
            this.lblPagtoCompraAviso.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dt. Pagamento";
            // 
            // dtpkDtPagtoCompra
            // 
            this.dtpkDtPagtoCompra.Enabled = false;
            this.dtpkDtPagtoCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDtPagtoCompra.Location = new System.Drawing.Point(17, 118);
            this.dtpkDtPagtoCompra.Name = "dtpkDtPagtoCompra";
            this.dtpkDtPagtoCompra.Size = new System.Drawing.Size(98, 20);
            this.dtpkDtPagtoCompra.TabIndex = 12;
            // 
            // dgvPgtoComParcelas
            // 
            this.dgvPgtoComParcelas.AllowUserToAddRows = false;
            this.dgvPgtoComParcelas.AllowUserToDeleteRows = false;
            this.dgvPgtoComParcelas.AllowUserToResizeColumns = false;
            this.dgvPgtoComParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPgtoComParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPgtoComParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPgtoComParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_Status,
            this.pco_Parcela,
            this.pco_Valor,
            this.pco_Dtpagto,
            this.pco_Dtvecto});
            this.dgvPgtoComParcelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPgtoComParcelas.Location = new System.Drawing.Point(12, 243);
            this.dgvPgtoComParcelas.MultiSelect = false;
            this.dgvPgtoComParcelas.Name = "dgvPgtoComParcelas";
            this.dgvPgtoComParcelas.RowHeadersVisible = false;
            this.dgvPgtoComParcelas.RowTemplate.Height = 18;
            this.dgvPgtoComParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPgtoComParcelas.Size = new System.Drawing.Size(745, 345);
            this.dgvPgtoComParcelas.TabIndex = 5;
            this.dgvPgtoComParcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPgtoComParcelas_CellClick);
            // 
            // pco_Status
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pco_Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.pco_Status.HeaderText = "St.";
            this.pco_Status.Name = "pco_Status";
            this.pco_Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pco_Status.Width = 30;
            // 
            // pco_Parcela
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pco_Parcela.DefaultCellStyle = dataGridViewCellStyle3;
            this.pco_Parcela.HeaderText = "Parcela";
            this.pco_Parcela.Name = "pco_Parcela";
            this.pco_Parcela.Width = 60;
            // 
            // pco_Valor
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pco_Valor.DefaultCellStyle = dataGridViewCellStyle4;
            this.pco_Valor.HeaderText = "Vl. Parcela";
            this.pco_Valor.Name = "pco_Valor";
            this.pco_Valor.ReadOnly = true;
            // 
            // pco_Dtpagto
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.pco_Dtpagto.DefaultCellStyle = dataGridViewCellStyle5;
            this.pco_Dtpagto.HeaderText = "Dt. Pagamento";
            this.pco_Dtpagto.Name = "pco_Dtpagto";
            this.pco_Dtpagto.Width = 110;
            // 
            // pco_Dtvecto
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pco_Dtvecto.DefaultCellStyle = dataGridViewCellStyle6;
            this.pco_Dtvecto.HeaderText = "Dt. Vencimento";
            this.pco_Dtvecto.Name = "pco_Dtvecto";
            this.pco_Dtvecto.ReadOnly = true;
            this.pco_Dtvecto.Width = 110;
            // 
            // frmPagamentoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(769, 601);
            this.ControlBox = false;
            this.Controls.Add(this.dgvPgtoComParcelas);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlBotao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagamentoCompra";
            this.Text = "Pagamento Compra";
            this.Load += new System.EventHandler(this.frmPagamentoCompra_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPgtoComParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlBotao;
        private System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnEstornar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Button btnPgtoCompraLocalizar;
        private System.Windows.Forms.Label lblComCod;
        private System.Windows.Forms.Label lblPgtoComNomeForn;
        private System.Windows.Forms.TextBox txbPgtoComCod;
        private System.Windows.Forms.Label lblComFornecedor;
        private System.Windows.Forms.TextBox txbPgtoComNf;
        private System.Windows.Forms.TextBox txbPgtoComCodForn;
        private System.Windows.Forms.Label lblComNf;
        private System.Windows.Forms.DateTimePicker dtpkDtCompra;
        private System.Windows.Forms.Label lblDtCompra;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.DataGridView dgvPgtoComParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkDtPagtoCompra;
        protected System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_Dtpagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_Dtvecto;
        private System.Windows.Forms.Label lblPagtoCompraAviso;
    }
}