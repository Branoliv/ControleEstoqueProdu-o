namespace GUI
{
    partial class frmProduto
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
            this.txbProdCodigo = new System.Windows.Forms.TextBox();
            this.lblProdCodigo = new System.Windows.Forms.Label();
            this.txbProdNome = new System.Windows.Forms.TextBox();
            this.lblProdNome = new System.Windows.Forms.Label();
            this.txbProdDescricao = new System.Windows.Forms.TextBox();
            this.lblProdDescricao = new System.Windows.Forms.Label();
            this.txbProdValorPago = new System.Windows.Forms.TextBox();
            this.lblProdValorPago = new System.Windows.Forms.Label();
            this.txbProdValorVenda = new System.Windows.Forms.TextBox();
            this.lblProdValorVenda = new System.Windows.Forms.Label();
            this.txbProdQuantidade = new System.Windows.Forms.TextBox();
            this.lblProdQuantidade = new System.Windows.Forms.Label();
            this.lblProdUnidMedida = new System.Windows.Forms.Label();
            this.lblProdGrupo = new System.Windows.Forms.Label();
            this.lblProdSubGrupo = new System.Windows.Forms.Label();
            this.pnlpcbxProd = new System.Windows.Forms.Panel();
            this.pcbxProd = new System.Windows.Forms.PictureBox();
            this.lblProdFoto = new System.Windows.Forms.Label();
            this.btnpcbxProdCarrega = new System.Windows.Forms.Button();
            this.btnpcbxProdRemover = new System.Windows.Forms.Button();
            this.cbxProdSubGrupo = new System.Windows.Forms.ComboBox();
            this.cbxProdGrupo = new System.Windows.Forms.ComboBox();
            this.cbxProdUnidMed = new System.Windows.Forms.ComboBox();
            this.txbProdCodBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProdMargem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbProdInativo = new System.Windows.Forms.CheckBox();
            this.btnProdTpProduto = new System.Windows.Forms.Button();
            this.txbProdCodTpProduto = new System.Windows.Forms.TextBox();
            this.lblProdCodTpProduto = new System.Windows.Forms.Label();
            this.txbProdTipoProduto = new System.Windows.Forms.TextBox();
            this.lblProdTipoProduto = new System.Windows.Forms.Label();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.pnlpcbxProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProd)).BeginInit();
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
            this.pnlBotao.Size = new System.Drawing.Size(740, 68);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnProdTpProduto);
            this.pnlDados.Controls.Add(this.ckbProdInativo);
            this.pnlDados.Controls.Add(this.txbProdCodTpProduto);
            this.pnlDados.Controls.Add(this.lblProdCodTpProduto);
            this.pnlDados.Controls.Add(this.txbProdMargem);
            this.pnlDados.Controls.Add(this.txbProdTipoProduto);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.lblProdTipoProduto);
            this.pnlDados.Controls.Add(this.txbProdCodBarras);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.cbxProdUnidMed);
            this.pnlDados.Controls.Add(this.cbxProdGrupo);
            this.pnlDados.Controls.Add(this.cbxProdSubGrupo);
            this.pnlDados.Controls.Add(this.btnpcbxProdRemover);
            this.pnlDados.Controls.Add(this.btnpcbxProdCarrega);
            this.pnlDados.Controls.Add(this.lblProdFoto);
            this.pnlDados.Controls.Add(this.pnlpcbxProd);
            this.pnlDados.Controls.Add(this.lblProdSubGrupo);
            this.pnlDados.Controls.Add(this.lblProdGrupo);
            this.pnlDados.Controls.Add(this.lblProdUnidMedida);
            this.pnlDados.Controls.Add(this.txbProdQuantidade);
            this.pnlDados.Controls.Add(this.lblProdQuantidade);
            this.pnlDados.Controls.Add(this.txbProdValorVenda);
            this.pnlDados.Controls.Add(this.lblProdValorVenda);
            this.pnlDados.Controls.Add(this.txbProdValorPago);
            this.pnlDados.Controls.Add(this.lblProdValorPago);
            this.pnlDados.Controls.Add(this.txbProdDescricao);
            this.pnlDados.Controls.Add(this.lblProdDescricao);
            this.pnlDados.Controls.Add(this.txbProdNome);
            this.pnlDados.Controls.Add(this.lblProdNome);
            this.pnlDados.Controls.Add(this.txbProdCodigo);
            this.pnlDados.Controls.Add(this.lblProdCodigo);
            this.pnlDados.Size = new System.Drawing.Size(713, 508);
            this.pnlDados.TabIndex = 0;
            // 
            // txbProdCodigo
            // 
            this.txbProdCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbProdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdCodigo.Enabled = false;
            this.txbProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdCodigo.Location = new System.Drawing.Point(30, 34);
            this.txbProdCodigo.Name = "txbProdCodigo";
            this.txbProdCodigo.Size = new System.Drawing.Size(85, 20);
            this.txbProdCodigo.TabIndex = 3;
            this.txbProdCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbProdCodigo.Enter += new System.EventHandler(this.txbProdCodigo_Enter);
            this.txbProdCodigo.Leave += new System.EventHandler(this.txbProdCodigo_Leave);
            // 
            // lblProdCodigo
            // 
            this.lblProdCodigo.AutoSize = true;
            this.lblProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCodigo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdCodigo.Location = new System.Drawing.Point(27, 18);
            this.lblProdCodigo.Name = "lblProdCodigo";
            this.lblProdCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblProdCodigo.TabIndex = 2;
            this.lblProdCodigo.Text = "Código";
            // 
            // txbProdNome
            // 
            this.txbProdNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdNome.Location = new System.Drawing.Point(30, 75);
            this.txbProdNome.MaxLength = 95;
            this.txbProdNome.Name = "txbProdNome";
            this.txbProdNome.Size = new System.Drawing.Size(298, 20);
            this.txbProdNome.TabIndex = 7;
            this.txbProdNome.Enter += new System.EventHandler(this.txbProdNome_Enter);
            this.txbProdNome.Leave += new System.EventHandler(this.txbProdNome_Leave);
            // 
            // lblProdNome
            // 
            this.lblProdNome.AutoSize = true;
            this.lblProdNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdNome.Location = new System.Drawing.Point(27, 59);
            this.lblProdNome.Name = "lblProdNome";
            this.lblProdNome.Size = new System.Drawing.Size(39, 13);
            this.lblProdNome.TabIndex = 6;
            this.lblProdNome.Text = "Nome";
            // 
            // txbProdDescricao
            // 
            this.txbProdDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdDescricao.Location = new System.Drawing.Point(30, 116);
            this.txbProdDescricao.Multiline = true;
            this.txbProdDescricao.Name = "txbProdDescricao";
            this.txbProdDescricao.Size = new System.Drawing.Size(298, 126);
            this.txbProdDescricao.TabIndex = 9;
            this.txbProdDescricao.Enter += new System.EventHandler(this.txbProdDescricao_Enter);
            this.txbProdDescricao.Leave += new System.EventHandler(this.txbProdDescricao_Leave);
            // 
            // lblProdDescricao
            // 
            this.lblProdDescricao.AutoSize = true;
            this.lblProdDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDescricao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdDescricao.Location = new System.Drawing.Point(27, 100);
            this.lblProdDescricao.Name = "lblProdDescricao";
            this.lblProdDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblProdDescricao.TabIndex = 8;
            this.lblProdDescricao.Text = "Descrição";
            // 
            // txbProdValorPago
            // 
            this.txbProdValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdValorPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdValorPago.Location = new System.Drawing.Point(30, 263);
            this.txbProdValorPago.Name = "txbProdValorPago";
            this.txbProdValorPago.Size = new System.Drawing.Size(116, 20);
            this.txbProdValorPago.TabIndex = 11;
            this.txbProdValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProdValorPago.Enter += new System.EventHandler(this.txbProdValorPago_Enter);
            this.txbProdValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbProdValorPago_KeyPress);
            this.txbProdValorPago.Leave += new System.EventHandler(this.txbProdValorPago_Leave);
            // 
            // lblProdValorPago
            // 
            this.lblProdValorPago.AutoSize = true;
            this.lblProdValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdValorPago.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdValorPago.Location = new System.Drawing.Point(27, 247);
            this.lblProdValorPago.Name = "lblProdValorPago";
            this.lblProdValorPago.Size = new System.Drawing.Size(69, 13);
            this.lblProdValorPago.TabIndex = 10;
            this.lblProdValorPago.Text = "Valor Pago";
            // 
            // txbProdValorVenda
            // 
            this.txbProdValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdValorVenda.Enabled = false;
            this.txbProdValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdValorVenda.Location = new System.Drawing.Point(219, 263);
            this.txbProdValorVenda.Name = "txbProdValorVenda";
            this.txbProdValorVenda.Size = new System.Drawing.Size(109, 20);
            this.txbProdValorVenda.TabIndex = 15;
            this.txbProdValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProdValorVenda.TextChanged += new System.EventHandler(this.txbProdValorVenda_TextChanged);
            this.txbProdValorVenda.Enter += new System.EventHandler(this.txbProdValorVenda_Enter);
            this.txbProdValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbProdValorVenda_KeyPress);
            this.txbProdValorVenda.Leave += new System.EventHandler(this.txbProdValorVenda_Leave);
            // 
            // lblProdValorVenda
            // 
            this.lblProdValorVenda.AutoSize = true;
            this.lblProdValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdValorVenda.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdValorVenda.Location = new System.Drawing.Point(216, 247);
            this.lblProdValorVenda.Name = "lblProdValorVenda";
            this.lblProdValorVenda.Size = new System.Drawing.Size(76, 13);
            this.lblProdValorVenda.TabIndex = 14;
            this.lblProdValorVenda.Text = "Valor Venda";
            // 
            // txbProdQuantidade
            // 
            this.txbProdQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdQuantidade.Location = new System.Drawing.Point(30, 304);
            this.txbProdQuantidade.Name = "txbProdQuantidade";
            this.txbProdQuantidade.Size = new System.Drawing.Size(143, 20);
            this.txbProdQuantidade.TabIndex = 17;
            this.txbProdQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProdQuantidade.Enter += new System.EventHandler(this.txbProdQuantidade_Enter);
            this.txbProdQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbProdQuantidade_KeyPress);
            this.txbProdQuantidade.Leave += new System.EventHandler(this.txbProdQuantidade_Leave);
            // 
            // lblProdQuantidade
            // 
            this.lblProdQuantidade.AutoSize = true;
            this.lblProdQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdQuantidade.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdQuantidade.Location = new System.Drawing.Point(27, 288);
            this.lblProdQuantidade.Name = "lblProdQuantidade";
            this.lblProdQuantidade.Size = new System.Drawing.Size(72, 13);
            this.lblProdQuantidade.TabIndex = 16;
            this.lblProdQuantidade.Text = "Quantidade";
            // 
            // lblProdUnidMedida
            // 
            this.lblProdUnidMedida.AutoSize = true;
            this.lblProdUnidMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdUnidMedida.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdUnidMedida.Location = new System.Drawing.Point(182, 288);
            this.lblProdUnidMedida.Name = "lblProdUnidMedida";
            this.lblProdUnidMedida.Size = new System.Drawing.Size(99, 13);
            this.lblProdUnidMedida.TabIndex = 18;
            this.lblProdUnidMedida.Text = "Unidade Medida";
            // 
            // lblProdGrupo
            // 
            this.lblProdGrupo.AutoSize = true;
            this.lblProdGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdGrupo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdGrupo.Location = new System.Drawing.Point(27, 329);
            this.lblProdGrupo.Name = "lblProdGrupo";
            this.lblProdGrupo.Size = new System.Drawing.Size(41, 13);
            this.lblProdGrupo.TabIndex = 20;
            this.lblProdGrupo.Text = "Grupo";
            // 
            // lblProdSubGrupo
            // 
            this.lblProdSubGrupo.AutoSize = true;
            this.lblProdSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdSubGrupo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdSubGrupo.Location = new System.Drawing.Point(27, 370);
            this.lblProdSubGrupo.Name = "lblProdSubGrupo";
            this.lblProdSubGrupo.Size = new System.Drawing.Size(67, 13);
            this.lblProdSubGrupo.TabIndex = 22;
            this.lblProdSubGrupo.Text = "Sub Grupo";
            // 
            // pnlpcbxProd
            // 
            this.pnlpcbxProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpcbxProd.Controls.Add(this.pcbxProd);
            this.pnlpcbxProd.Location = new System.Drawing.Point(351, 34);
            this.pnlpcbxProd.Name = "pnlpcbxProd";
            this.pnlpcbxProd.Size = new System.Drawing.Size(327, 290);
            this.pnlpcbxProd.TabIndex = 20;
            // 
            // pcbxProd
            // 
            this.pcbxProd.BackColor = System.Drawing.Color.Gainsboro;
            this.pcbxProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxProd.Location = new System.Drawing.Point(0, 0);
            this.pcbxProd.Name = "pcbxProd";
            this.pcbxProd.Size = new System.Drawing.Size(325, 288);
            this.pcbxProd.TabIndex = 0;
            this.pcbxProd.TabStop = false;
            // 
            // lblProdFoto
            // 
            this.lblProdFoto.AutoSize = true;
            this.lblProdFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdFoto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdFoto.Location = new System.Drawing.Point(348, 18);
            this.lblProdFoto.Name = "lblProdFoto";
            this.lblProdFoto.Size = new System.Drawing.Size(32, 13);
            this.lblProdFoto.TabIndex = 21;
            this.lblProdFoto.Text = "Foto";
            // 
            // btnpcbxProdCarrega
            // 
            this.btnpcbxProdCarrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnpcbxProdCarrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpcbxProdCarrega.Location = new System.Drawing.Point(351, 331);
            this.btnpcbxProdCarrega.Name = "btnpcbxProdCarrega";
            this.btnpcbxProdCarrega.Size = new System.Drawing.Size(162, 76);
            this.btnpcbxProdCarrega.TabIndex = 24;
            this.btnpcbxProdCarrega.Text = "Carregar Foto";
            this.btnpcbxProdCarrega.UseVisualStyleBackColor = true;
            this.btnpcbxProdCarrega.Click += new System.EventHandler(this.btnpcbxProdCarrega_Click);
            // 
            // btnpcbxProdRemover
            // 
            this.btnpcbxProdRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpcbxProdRemover.Location = new System.Drawing.Point(516, 331);
            this.btnpcbxProdRemover.Name = "btnpcbxProdRemover";
            this.btnpcbxProdRemover.Size = new System.Drawing.Size(162, 76);
            this.btnpcbxProdRemover.TabIndex = 25;
            this.btnpcbxProdRemover.Text = "Remover Foto";
            this.btnpcbxProdRemover.UseVisualStyleBackColor = true;
            this.btnpcbxProdRemover.Click += new System.EventHandler(this.btnpcbxProdRemover_Click);
            // 
            // cbxProdSubGrupo
            // 
            this.cbxProdSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProdSubGrupo.FormattingEnabled = true;
            this.cbxProdSubGrupo.Location = new System.Drawing.Point(30, 387);
            this.cbxProdSubGrupo.Name = "cbxProdSubGrupo";
            this.cbxProdSubGrupo.Size = new System.Drawing.Size(298, 21);
            this.cbxProdSubGrupo.TabIndex = 23;
            this.cbxProdSubGrupo.Enter += new System.EventHandler(this.cbxProdSubGrupo_Enter);
            this.cbxProdSubGrupo.Leave += new System.EventHandler(this.cbxProdSubGrupo_Leave);
            // 
            // cbxProdGrupo
            // 
            this.cbxProdGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProdGrupo.FormattingEnabled = true;
            this.cbxProdGrupo.Location = new System.Drawing.Point(30, 346);
            this.cbxProdGrupo.Name = "cbxProdGrupo";
            this.cbxProdGrupo.Size = new System.Drawing.Size(298, 21);
            this.cbxProdGrupo.TabIndex = 21;
            this.cbxProdGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxProdGrupo_SelectedIndexChanged);
            this.cbxProdGrupo.Enter += new System.EventHandler(this.cbxProdGrupo_Enter);
            this.cbxProdGrupo.Leave += new System.EventHandler(this.cbxProdGrupo_Leave);
            // 
            // cbxProdUnidMed
            // 
            this.cbxProdUnidMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProdUnidMed.FormattingEnabled = true;
            this.cbxProdUnidMed.Location = new System.Drawing.Point(185, 302);
            this.cbxProdUnidMed.Name = "cbxProdUnidMed";
            this.cbxProdUnidMed.Size = new System.Drawing.Size(143, 21);
            this.cbxProdUnidMed.TabIndex = 19;
            this.cbxProdUnidMed.Enter += new System.EventHandler(this.cbxProdUnidMed_Enter);
            this.cbxProdUnidMed.Leave += new System.EventHandler(this.cbxProdUnidMed_Leave);
            // 
            // txbProdCodBarras
            // 
            this.txbProdCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdCodBarras.Location = new System.Drawing.Point(157, 34);
            this.txbProdCodBarras.MaxLength = 14;
            this.txbProdCodBarras.Name = "txbProdCodBarras";
            this.txbProdCodBarras.Size = new System.Drawing.Size(171, 20);
            this.txbProdCodBarras.TabIndex = 5;
            this.txbProdCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbProdCodBarras.Enter += new System.EventHandler(this.txbProdCodBarras_Enter);
            this.txbProdCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbProdCodBarras_KeyPress);
            this.txbProdCodBarras.Leave += new System.EventHandler(this.txbProdCodBarras_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(154, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código de Barras";
            // 
            // txbProdMargem
            // 
            this.txbProdMargem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdMargem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdMargem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdMargem.Location = new System.Drawing.Point(152, 263);
            this.txbProdMargem.Name = "txbProdMargem";
            this.txbProdMargem.Size = new System.Drawing.Size(61, 20);
            this.txbProdMargem.TabIndex = 13;
            this.txbProdMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbProdMargem.Enter += new System.EventHandler(this.txbProdMargem_Enter);
            this.txbProdMargem.Leave += new System.EventHandler(this.txbProdMargem_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(149, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Margem %";
            // 
            // ckbProdInativo
            // 
            this.ckbProdInativo.AutoSize = true;
            this.ckbProdInativo.Location = new System.Drawing.Point(30, 457);
            this.ckbProdInativo.Name = "ckbProdInativo";
            this.ckbProdInativo.Size = new System.Drawing.Size(98, 17);
            this.ckbProdInativo.TabIndex = 26;
            this.ckbProdInativo.Text = "Produto Inativo";
            this.ckbProdInativo.UseVisualStyleBackColor = true;
            // 
            // btnProdTpProduto
            // 
            this.btnProdTpProduto.BackColor = System.Drawing.Color.Gray;
            this.btnProdTpProduto.FlatAppearance.BorderSize = 0;
            this.btnProdTpProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProdTpProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdTpProduto.Location = new System.Drawing.Point(118, 431);
            this.btnProdTpProduto.Name = "btnProdTpProduto";
            this.btnProdTpProduto.Size = new System.Drawing.Size(20, 20);
            this.btnProdTpProduto.TabIndex = 31;
            this.btnProdTpProduto.TabStop = false;
            this.btnProdTpProduto.UseVisualStyleBackColor = false;
            this.btnProdTpProduto.Click += new System.EventHandler(this.btnProdTpProduto_Click);
            // 
            // txbProdCodTpProduto
            // 
            this.txbProdCodTpProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdCodTpProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdCodTpProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdCodTpProduto.Location = new System.Drawing.Point(30, 431);
            this.txbProdCodTpProduto.Name = "txbProdCodTpProduto";
            this.txbProdCodTpProduto.Size = new System.Drawing.Size(85, 20);
            this.txbProdCodTpProduto.TabIndex = 30;
            this.txbProdCodTpProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbProdCodTpProduto.Enter += new System.EventHandler(this.txbProdCodTpProduto_Enter);
            this.txbProdCodTpProduto.Leave += new System.EventHandler(this.txbProdCodTpProduto_Leave);
            // 
            // lblProdCodTpProduto
            // 
            this.lblProdCodTpProduto.AutoSize = true;
            this.lblProdCodTpProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCodTpProduto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdCodTpProduto.Location = new System.Drawing.Point(27, 415);
            this.lblProdCodTpProduto.Name = "lblProdCodTpProduto";
            this.lblProdCodTpProduto.Size = new System.Drawing.Size(90, 13);
            this.lblProdCodTpProduto.TabIndex = 29;
            this.lblProdCodTpProduto.Text = "Cód. Tp. Prod.";
            // 
            // txbProdTipoProduto
            // 
            this.txbProdTipoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdTipoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbProdTipoProduto.Enabled = false;
            this.txbProdTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdTipoProduto.Location = new System.Drawing.Point(160, 431);
            this.txbProdTipoProduto.Name = "txbProdTipoProduto";
            this.txbProdTipoProduto.Size = new System.Drawing.Size(278, 20);
            this.txbProdTipoProduto.TabIndex = 28;
            // 
            // lblProdTipoProduto
            // 
            this.lblProdTipoProduto.AutoSize = true;
            this.lblProdTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdTipoProduto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProdTipoProduto.Location = new System.Drawing.Point(157, 415);
            this.lblProdTipoProduto.Name = "lblProdTipoProduto";
            this.lblProdTipoProduto.Size = new System.Drawing.Size(97, 13);
            this.lblProdTipoProduto.TabIndex = 27;
            this.lblProdTipoProduto.Text = "Tipo de produto";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(740, 606);
            this.Name = "frmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlpcbxProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblProdSubGrupo;
        private System.Windows.Forms.Label lblProdGrupo;
        private System.Windows.Forms.Label lblProdUnidMedida;
        private System.Windows.Forms.TextBox txbProdQuantidade;
        private System.Windows.Forms.Label lblProdQuantidade;
        private System.Windows.Forms.TextBox txbProdValorVenda;
        private System.Windows.Forms.Label lblProdValorVenda;
        private System.Windows.Forms.TextBox txbProdValorPago;
        private System.Windows.Forms.Label lblProdValorPago;
        private System.Windows.Forms.TextBox txbProdDescricao;
        private System.Windows.Forms.Label lblProdDescricao;
        private System.Windows.Forms.TextBox txbProdNome;
        private System.Windows.Forms.Label lblProdNome;
        private System.Windows.Forms.TextBox txbProdCodigo;
        private System.Windows.Forms.Label lblProdCodigo;
        private System.Windows.Forms.Button btnpcbxProdRemover;
        private System.Windows.Forms.Button btnpcbxProdCarrega;
        private System.Windows.Forms.Label lblProdFoto;
        private System.Windows.Forms.Panel pnlpcbxProd;
        private System.Windows.Forms.PictureBox pcbxProd;
        private System.Windows.Forms.ComboBox cbxProdSubGrupo;
        private System.Windows.Forms.ComboBox cbxProdGrupo;
        private System.Windows.Forms.ComboBox cbxProdUnidMed;
        private System.Windows.Forms.TextBox txbProdCodBarras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProdMargem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbProdInativo;
        private System.Windows.Forms.TextBox txbProdCodTpProduto;
        private System.Windows.Forms.Label lblProdCodTpProduto;
        private System.Windows.Forms.TextBox txbProdTipoProduto;
        private System.Windows.Forms.Label lblProdTipoProduto;
        private System.Windows.Forms.Button btnProdTpProduto;
    }
}
