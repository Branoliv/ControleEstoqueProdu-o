namespace GUI
{
    partial class frmCliente
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
            this.lblCliCod = new System.Windows.Forms.Label();
            this.txbCliCod = new System.Windows.Forms.TextBox();
            this.txbCliCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblCliCpfCnpj = new System.Windows.Forms.Label();
            this.txbCliRg = new System.Windows.Forms.TextBox();
            this.lbCliRg = new System.Windows.Forms.Label();
            this.txbCliRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblCliRazaoSocial = new System.Windows.Forms.Label();
            this.txbCliCep = new System.Windows.Forms.TextBox();
            this.lblCliCep = new System.Windows.Forms.Label();
            this.txbCliEndereco = new System.Windows.Forms.TextBox();
            this.lblCliEndereco = new System.Windows.Forms.Label();
            this.txbCliBairro = new System.Windows.Forms.TextBox();
            this.lblCliBairro = new System.Windows.Forms.Label();
            this.txbCliTelefone = new System.Windows.Forms.TextBox();
            this.lblCliTelefone = new System.Windows.Forms.Label();
            this.txbCliCelular = new System.Windows.Forms.TextBox();
            this.lblCliCelular = new System.Windows.Forms.Label();
            this.txbCliEmail = new System.Windows.Forms.TextBox();
            this.lblCliEmail = new System.Windows.Forms.Label();
            this.txbCliEndNumero = new System.Windows.Forms.TextBox();
            this.lblCliEndNumero = new System.Windows.Forms.Label();
            this.txbCliCidade = new System.Windows.Forms.TextBox();
            this.lblCliCidade = new System.Windows.Forms.Label();
            this.txbCliEstado = new System.Windows.Forms.TextBox();
            this.lblCliEstado = new System.Windows.Forms.Label();
            this.txbCliNome = new System.Windows.Forms.TextBox();
            this.lblCliNome = new System.Windows.Forms.Label();
            this.txbCliObservacao = new System.Windows.Forms.TextBox();
            this.lblCliObservacao = new System.Windows.Forms.Label();
            this.rbtCliTpFisica = new System.Windows.Forms.RadioButton();
            this.rbtCliTpJuridica = new System.Windows.Forms.RadioButton();
            this.gbxTpPessoa = new System.Windows.Forms.GroupBox();
            this.lblCliInvalido = new System.Windows.Forms.Label();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.gbxTpPessoa.SuspendLayout();
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
            this.pnlBotao.Size = new System.Drawing.Size(637, 68);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.lblCliInvalido);
            this.pnlDados.Controls.Add(this.gbxTpPessoa);
            this.pnlDados.Controls.Add(this.txbCliObservacao);
            this.pnlDados.Controls.Add(this.lblCliObservacao);
            this.pnlDados.Controls.Add(this.txbCliNome);
            this.pnlDados.Controls.Add(this.lblCliNome);
            this.pnlDados.Controls.Add(this.txbCliEstado);
            this.pnlDados.Controls.Add(this.lblCliEstado);
            this.pnlDados.Controls.Add(this.txbCliCidade);
            this.pnlDados.Controls.Add(this.lblCliCidade);
            this.pnlDados.Controls.Add(this.txbCliEndNumero);
            this.pnlDados.Controls.Add(this.lblCliEndNumero);
            this.pnlDados.Controls.Add(this.txbCliEmail);
            this.pnlDados.Controls.Add(this.lblCliEmail);
            this.pnlDados.Controls.Add(this.txbCliCelular);
            this.pnlDados.Controls.Add(this.lblCliCelular);
            this.pnlDados.Controls.Add(this.txbCliTelefone);
            this.pnlDados.Controls.Add(this.lblCliTelefone);
            this.pnlDados.Controls.Add(this.txbCliBairro);
            this.pnlDados.Controls.Add(this.lblCliBairro);
            this.pnlDados.Controls.Add(this.txbCliEndereco);
            this.pnlDados.Controls.Add(this.lblCliEndereco);
            this.pnlDados.Controls.Add(this.txbCliCep);
            this.pnlDados.Controls.Add(this.lblCliCep);
            this.pnlDados.Controls.Add(this.txbCliRazaoSocial);
            this.pnlDados.Controls.Add(this.lblCliRazaoSocial);
            this.pnlDados.Controls.Add(this.txbCliRg);
            this.pnlDados.Controls.Add(this.lbCliRg);
            this.pnlDados.Controls.Add(this.txbCliCpfCnpj);
            this.pnlDados.Controls.Add(this.lblCliCpfCnpj);
            this.pnlDados.Controls.Add(this.txbCliCod);
            this.pnlDados.Controls.Add(this.lblCliCod);
            this.pnlDados.Size = new System.Drawing.Size(607, 436);
            // 
            // lblCliCod
            // 
            this.lblCliCod.AutoSize = true;
            this.lblCliCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliCod.Location = new System.Drawing.Point(17, 11);
            this.lblCliCod.Name = "lblCliCod";
            this.lblCliCod.Size = new System.Drawing.Size(46, 13);
            this.lblCliCod.TabIndex = 0;
            this.lblCliCod.Text = "Código";
            // 
            // txbCliCod
            // 
            this.txbCliCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliCod.Enabled = false;
            this.txbCliCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliCod.Location = new System.Drawing.Point(20, 27);
            this.txbCliCod.Name = "txbCliCod";
            this.txbCliCod.Size = new System.Drawing.Size(85, 20);
            this.txbCliCod.TabIndex = 1;
            // 
            // txbCliCpfCnpj
            // 
            this.txbCliCpfCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliCpfCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliCpfCnpj.Location = new System.Drawing.Point(212, 151);
            this.txbCliCpfCnpj.MaxLength = 95;
            this.txbCliCpfCnpj.Name = "txbCliCpfCnpj";
            this.txbCliCpfCnpj.Size = new System.Drawing.Size(263, 20);
            this.txbCliCpfCnpj.TabIndex = 11;
            this.txbCliCpfCnpj.Enter += new System.EventHandler(this.txbCliCpfCnpj_Enter);
            this.txbCliCpfCnpj.Leave += new System.EventHandler(this.txbCliCpfCnpj_Leave);
            // 
            // lblCliCpfCnpj
            // 
            this.lblCliCpfCnpj.AutoSize = true;
            this.lblCliCpfCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCpfCnpj.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliCpfCnpj.Location = new System.Drawing.Point(209, 135);
            this.lblCliCpfCnpj.Name = "lblCliCpfCnpj";
            this.lblCliCpfCnpj.Size = new System.Drawing.Size(30, 13);
            this.lblCliCpfCnpj.TabIndex = 10;
            this.lblCliCpfCnpj.Text = "CPF";
            // 
            // txbCliRg
            // 
            this.txbCliRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliRg.Location = new System.Drawing.Point(20, 151);
            this.txbCliRg.MaxLength = 95;
            this.txbCliRg.Name = "txbCliRg";
            this.txbCliRg.Size = new System.Drawing.Size(186, 20);
            this.txbCliRg.TabIndex = 9;
            this.txbCliRg.Enter += new System.EventHandler(this.txbCliRg_Enter);
            this.txbCliRg.Leave += new System.EventHandler(this.txbCliRg_Leave);
            // 
            // lbCliRg
            // 
            this.lbCliRg.AutoSize = true;
            this.lbCliRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliRg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCliRg.Location = new System.Drawing.Point(17, 135);
            this.lbCliRg.Name = "lbCliRg";
            this.lbCliRg.Size = new System.Drawing.Size(25, 13);
            this.lbCliRg.TabIndex = 8;
            this.lbCliRg.Text = "RG";
            // 
            // txbCliRazaoSocial
            // 
            this.txbCliRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliRazaoSocial.Location = new System.Drawing.Point(20, 110);
            this.txbCliRazaoSocial.MaxLength = 95;
            this.txbCliRazaoSocial.Name = "txbCliRazaoSocial";
            this.txbCliRazaoSocial.Size = new System.Drawing.Size(568, 20);
            this.txbCliRazaoSocial.TabIndex = 7;
            this.txbCliRazaoSocial.Visible = false;
            this.txbCliRazaoSocial.Enter += new System.EventHandler(this.txbCliRazaoSocial_Enter);
            this.txbCliRazaoSocial.Leave += new System.EventHandler(this.txbCliRazaoSocial_Leave);
            // 
            // lblCliRazaoSocial
            // 
            this.lblCliRazaoSocial.AutoSize = true;
            this.lblCliRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliRazaoSocial.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliRazaoSocial.Location = new System.Drawing.Point(17, 94);
            this.lblCliRazaoSocial.Name = "lblCliRazaoSocial";
            this.lblCliRazaoSocial.Size = new System.Drawing.Size(82, 13);
            this.lblCliRazaoSocial.TabIndex = 6;
            this.lblCliRazaoSocial.Text = "Razão Social";
            this.lblCliRazaoSocial.Visible = false;
            // 
            // txbCliCep
            // 
            this.txbCliCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliCep.Location = new System.Drawing.Point(481, 151);
            this.txbCliCep.MaxLength = 20;
            this.txbCliCep.Name = "txbCliCep";
            this.txbCliCep.Size = new System.Drawing.Size(107, 20);
            this.txbCliCep.TabIndex = 13;
            this.txbCliCep.Enter += new System.EventHandler(this.txbCliCep_Enter);
            this.txbCliCep.Leave += new System.EventHandler(this.txbCliCep_Leave);
            // 
            // lblCliCep
            // 
            this.lblCliCep.AutoSize = true;
            this.lblCliCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCep.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliCep.Location = new System.Drawing.Point(478, 135);
            this.lblCliCep.Name = "lblCliCep";
            this.lblCliCep.Size = new System.Drawing.Size(29, 13);
            this.lblCliCep.TabIndex = 12;
            this.lblCliCep.Text = "Cep";
            // 
            // txbCliEndereco
            // 
            this.txbCliEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliEndereco.Location = new System.Drawing.Point(20, 192);
            this.txbCliEndereco.MaxLength = 95;
            this.txbCliEndereco.Name = "txbCliEndereco";
            this.txbCliEndereco.Size = new System.Drawing.Size(261, 20);
            this.txbCliEndereco.TabIndex = 15;
            this.txbCliEndereco.Enter += new System.EventHandler(this.txbCliEndereco_Enter);
            this.txbCliEndereco.Leave += new System.EventHandler(this.txbCliEndereco_Leave);
            // 
            // lblCliEndereco
            // 
            this.lblCliEndereco.AutoSize = true;
            this.lblCliEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEndereco.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliEndereco.Location = new System.Drawing.Point(17, 176);
            this.lblCliEndereco.Name = "lblCliEndereco";
            this.lblCliEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblCliEndereco.TabIndex = 14;
            this.lblCliEndereco.Text = "Endereço";
            // 
            // txbCliBairro
            // 
            this.txbCliBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliBairro.Location = new System.Drawing.Point(348, 192);
            this.txbCliBairro.MaxLength = 95;
            this.txbCliBairro.Name = "txbCliBairro";
            this.txbCliBairro.Size = new System.Drawing.Size(240, 20);
            this.txbCliBairro.TabIndex = 19;
            this.txbCliBairro.Enter += new System.EventHandler(this.txbCliBairro_Enter);
            this.txbCliBairro.Leave += new System.EventHandler(this.txbCliBairro_Leave);
            // 
            // lblCliBairro
            // 
            this.lblCliBairro.AutoSize = true;
            this.lblCliBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliBairro.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliBairro.Location = new System.Drawing.Point(345, 176);
            this.lblCliBairro.Name = "lblCliBairro";
            this.lblCliBairro.Size = new System.Drawing.Size(40, 13);
            this.lblCliBairro.TabIndex = 18;
            this.lblCliBairro.Text = "Bairro";
            // 
            // txbCliTelefone
            // 
            this.txbCliTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliTelefone.Location = new System.Drawing.Point(20, 274);
            this.txbCliTelefone.MaxLength = 95;
            this.txbCliTelefone.Name = "txbCliTelefone";
            this.txbCliTelefone.Size = new System.Drawing.Size(130, 20);
            this.txbCliTelefone.TabIndex = 25;
            this.txbCliTelefone.Enter += new System.EventHandler(this.txbCliTelefone_Enter);
            this.txbCliTelefone.Leave += new System.EventHandler(this.txbCliTelefone_Leave);
            // 
            // lblCliTelefone
            // 
            this.lblCliTelefone.AutoSize = true;
            this.lblCliTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliTelefone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliTelefone.Location = new System.Drawing.Point(17, 258);
            this.lblCliTelefone.Name = "lblCliTelefone";
            this.lblCliTelefone.Size = new System.Drawing.Size(57, 13);
            this.lblCliTelefone.TabIndex = 24;
            this.lblCliTelefone.Text = "Telefone";
            // 
            // txbCliCelular
            // 
            this.txbCliCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliCelular.Location = new System.Drawing.Point(156, 274);
            this.txbCliCelular.MaxLength = 95;
            this.txbCliCelular.Name = "txbCliCelular";
            this.txbCliCelular.Size = new System.Drawing.Size(130, 20);
            this.txbCliCelular.TabIndex = 27;
            this.txbCliCelular.Enter += new System.EventHandler(this.txbCliCelular_Enter);
            this.txbCliCelular.Leave += new System.EventHandler(this.txbCliCelular_Leave);
            // 
            // lblCliCelular
            // 
            this.lblCliCelular.AutoSize = true;
            this.lblCliCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCelular.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliCelular.Location = new System.Drawing.Point(153, 258);
            this.lblCliCelular.Name = "lblCliCelular";
            this.lblCliCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCliCelular.TabIndex = 26;
            this.lblCliCelular.Text = "Celular";
            // 
            // txbCliEmail
            // 
            this.txbCliEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliEmail.Location = new System.Drawing.Point(292, 274);
            this.txbCliEmail.MaxLength = 95;
            this.txbCliEmail.Name = "txbCliEmail";
            this.txbCliEmail.Size = new System.Drawing.Size(296, 20);
            this.txbCliEmail.TabIndex = 29;
            this.txbCliEmail.Enter += new System.EventHandler(this.txbCliEmail_Enter);
            this.txbCliEmail.Leave += new System.EventHandler(this.txbCliEmail_Leave);
            // 
            // lblCliEmail
            // 
            this.lblCliEmail.AutoSize = true;
            this.lblCliEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliEmail.Location = new System.Drawing.Point(289, 258);
            this.lblCliEmail.Name = "lblCliEmail";
            this.lblCliEmail.Size = new System.Drawing.Size(37, 13);
            this.lblCliEmail.TabIndex = 28;
            this.lblCliEmail.Text = "Email";
            // 
            // txbCliEndNumero
            // 
            this.txbCliEndNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliEndNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliEndNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliEndNumero.Location = new System.Drawing.Point(287, 192);
            this.txbCliEndNumero.MaxLength = 10;
            this.txbCliEndNumero.Name = "txbCliEndNumero";
            this.txbCliEndNumero.Size = new System.Drawing.Size(55, 20);
            this.txbCliEndNumero.TabIndex = 17;
            this.txbCliEndNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCliEndNumero.Enter += new System.EventHandler(this.txbCliEndNumero_Enter);
            this.txbCliEndNumero.Leave += new System.EventHandler(this.txbCliEndNumero_Leave);
            // 
            // lblCliEndNumero
            // 
            this.lblCliEndNumero.AutoSize = true;
            this.lblCliEndNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEndNumero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliEndNumero.Location = new System.Drawing.Point(284, 176);
            this.lblCliEndNumero.Name = "lblCliEndNumero";
            this.lblCliEndNumero.Size = new System.Drawing.Size(50, 13);
            this.lblCliEndNumero.TabIndex = 16;
            this.lblCliEndNumero.Text = "Número";
            // 
            // txbCliCidade
            // 
            this.txbCliCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliCidade.Location = new System.Drawing.Point(20, 233);
            this.txbCliCidade.MaxLength = 95;
            this.txbCliCidade.Name = "txbCliCidade";
            this.txbCliCidade.Size = new System.Drawing.Size(502, 20);
            this.txbCliCidade.TabIndex = 21;
            this.txbCliCidade.Enter += new System.EventHandler(this.txbCliCidade_Enter);
            this.txbCliCidade.Leave += new System.EventHandler(this.txbCliCidade_Leave);
            // 
            // lblCliCidade
            // 
            this.lblCliCidade.AutoSize = true;
            this.lblCliCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCidade.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliCidade.Location = new System.Drawing.Point(17, 217);
            this.lblCliCidade.Name = "lblCliCidade";
            this.lblCliCidade.Size = new System.Drawing.Size(46, 13);
            this.lblCliCidade.TabIndex = 20;
            this.lblCliCidade.Text = "Cidade";
            // 
            // txbCliEstado
            // 
            this.txbCliEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliEstado.Location = new System.Drawing.Point(528, 233);
            this.txbCliEstado.MaxLength = 2;
            this.txbCliEstado.Name = "txbCliEstado";
            this.txbCliEstado.Size = new System.Drawing.Size(60, 20);
            this.txbCliEstado.TabIndex = 23;
            this.txbCliEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCliEstado.Enter += new System.EventHandler(this.txbCliEstado_Enter);
            this.txbCliEstado.Leave += new System.EventHandler(this.txbCliEstado_Leave);
            // 
            // lblCliEstado
            // 
            this.lblCliEstado.AutoSize = true;
            this.lblCliEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEstado.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliEstado.Location = new System.Drawing.Point(525, 215);
            this.lblCliEstado.Name = "lblCliEstado";
            this.lblCliEstado.Size = new System.Drawing.Size(46, 13);
            this.lblCliEstado.TabIndex = 22;
            this.lblCliEstado.Text = "Estado";
            // 
            // txbCliNome
            // 
            this.txbCliNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliNome.Location = new System.Drawing.Point(19, 69);
            this.txbCliNome.MaxLength = 95;
            this.txbCliNome.Name = "txbCliNome";
            this.txbCliNome.Size = new System.Drawing.Size(569, 20);
            this.txbCliNome.TabIndex = 3;
            this.txbCliNome.Enter += new System.EventHandler(this.txbCliNome_Enter);
            this.txbCliNome.Leave += new System.EventHandler(this.txbCliNome_Leave);
            // 
            // lblCliNome
            // 
            this.lblCliNome.AutoSize = true;
            this.lblCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliNome.Location = new System.Drawing.Point(16, 53);
            this.lblCliNome.Name = "lblCliNome";
            this.lblCliNome.Size = new System.Drawing.Size(39, 13);
            this.lblCliNome.TabIndex = 2;
            this.lblCliNome.Text = "Nome";
            // 
            // txbCliObservacao
            // 
            this.txbCliObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCliObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliObservacao.Location = new System.Drawing.Point(19, 315);
            this.txbCliObservacao.MaxLength = 500;
            this.txbCliObservacao.Multiline = true;
            this.txbCliObservacao.Name = "txbCliObservacao";
            this.txbCliObservacao.Size = new System.Drawing.Size(568, 109);
            this.txbCliObservacao.TabIndex = 31;
            this.txbCliObservacao.Enter += new System.EventHandler(this.txbCliObservacao_Enter);
            this.txbCliObservacao.Leave += new System.EventHandler(this.txbCliObservacao_Leave);
            // 
            // lblCliObservacao
            // 
            this.lblCliObservacao.AutoSize = true;
            this.lblCliObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliObservacao.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCliObservacao.Location = new System.Drawing.Point(16, 299);
            this.lblCliObservacao.Name = "lblCliObservacao";
            this.lblCliObservacao.Size = new System.Drawing.Size(75, 13);
            this.lblCliObservacao.TabIndex = 30;
            this.lblCliObservacao.Text = "Observação";
            // 
            // rbtCliTpFisica
            // 
            this.rbtCliTpFisica.AutoSize = true;
            this.rbtCliTpFisica.Checked = true;
            this.rbtCliTpFisica.Location = new System.Drawing.Point(32, 19);
            this.rbtCliTpFisica.Name = "rbtCliTpFisica";
            this.rbtCliTpFisica.Size = new System.Drawing.Size(54, 17);
            this.rbtCliTpFisica.TabIndex = 32;
            this.rbtCliTpFisica.TabStop = true;
            this.rbtCliTpFisica.Text = "Física";
            this.rbtCliTpFisica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtCliTpFisica.UseVisualStyleBackColor = true;
            this.rbtCliTpFisica.CheckedChanged += new System.EventHandler(this.rbtCliTpFisica_CheckedChanged);
            // 
            // rbtCliTpJuridica
            // 
            this.rbtCliTpJuridica.AutoSize = true;
            this.rbtCliTpJuridica.Location = new System.Drawing.Point(133, 19);
            this.rbtCliTpJuridica.Name = "rbtCliTpJuridica";
            this.rbtCliTpJuridica.Size = new System.Drawing.Size(63, 17);
            this.rbtCliTpJuridica.TabIndex = 33;
            this.rbtCliTpJuridica.Text = "Jurídica";
            this.rbtCliTpJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtCliTpJuridica.UseVisualStyleBackColor = true;
            // 
            // gbxTpPessoa
            // 
            this.gbxTpPessoa.Controls.Add(this.rbtCliTpFisica);
            this.gbxTpPessoa.Controls.Add(this.rbtCliTpJuridica);
            this.gbxTpPessoa.Location = new System.Drawing.Point(138, 11);
            this.gbxTpPessoa.Name = "gbxTpPessoa";
            this.gbxTpPessoa.Size = new System.Drawing.Size(225, 48);
            this.gbxTpPessoa.TabIndex = 34;
            this.gbxTpPessoa.TabStop = false;
            this.gbxTpPessoa.Text = "Tipo de Pessoa";
            // 
            // lblCliInvalido
            // 
            this.lblCliInvalido.AutoSize = true;
            this.lblCliInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblCliInvalido.Location = new System.Drawing.Point(242, 135);
            this.lblCliInvalido.Name = "lblCliInvalido";
            this.lblCliInvalido.Size = new System.Drawing.Size(64, 13);
            this.lblCliInvalido.TabIndex = 35;
            this.lblCliInvalido.Text = "- Inválido!";
            this.lblCliInvalido.Visible = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(637, 555);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.gbxTpPessoa.ResumeLayout(false);
            this.gbxTpPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCliCod;
        private System.Windows.Forms.TextBox txbCliCod;
        private System.Windows.Forms.TextBox txbCliBairro;
        private System.Windows.Forms.Label lblCliBairro;
        private System.Windows.Forms.TextBox txbCliEndereco;
        private System.Windows.Forms.Label lblCliEndereco;
        private System.Windows.Forms.TextBox txbCliCep;
        private System.Windows.Forms.Label lblCliCep;
        private System.Windows.Forms.TextBox txbCliRazaoSocial;
        private System.Windows.Forms.Label lblCliRazaoSocial;
        private System.Windows.Forms.TextBox txbCliRg;
        private System.Windows.Forms.Label lbCliRg;
        private System.Windows.Forms.TextBox txbCliCpfCnpj;
        private System.Windows.Forms.Label lblCliCpfCnpj;
        private System.Windows.Forms.TextBox txbCliEstado;
        private System.Windows.Forms.Label lblCliEstado;
        private System.Windows.Forms.TextBox txbCliCidade;
        private System.Windows.Forms.Label lblCliCidade;
        private System.Windows.Forms.TextBox txbCliEndNumero;
        private System.Windows.Forms.Label lblCliEndNumero;
        private System.Windows.Forms.TextBox txbCliEmail;
        private System.Windows.Forms.Label lblCliEmail;
        private System.Windows.Forms.TextBox txbCliCelular;
        private System.Windows.Forms.Label lblCliCelular;
        private System.Windows.Forms.TextBox txbCliTelefone;
        private System.Windows.Forms.Label lblCliTelefone;
        private System.Windows.Forms.TextBox txbCliNome;
        private System.Windows.Forms.Label lblCliNome;
        private System.Windows.Forms.TextBox txbCliObservacao;
        private System.Windows.Forms.Label lblCliObservacao;
        private System.Windows.Forms.RadioButton rbtCliTpJuridica;
        private System.Windows.Forms.RadioButton rbtCliTpFisica;
        private System.Windows.Forms.GroupBox gbxTpPessoa;
        private System.Windows.Forms.Label lblCliInvalido;
    }
}
