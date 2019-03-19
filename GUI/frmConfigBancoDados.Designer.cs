namespace GUI
{
    partial class frmConfigBancoDados
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
            this.lblConfBdServidor = new System.Windows.Forms.Label();
            this.txbConfBdServidor = new System.Windows.Forms.TextBox();
            this.txbConfBdBancoDados = new System.Windows.Forms.TextBox();
            this.lblConfBdBd = new System.Windows.Forms.Label();
            this.txbConfBdUsuario = new System.Windows.Forms.TextBox();
            this.lblConfBdUsuario = new System.Windows.Forms.Label();
            this.txbConfBdSenha = new System.Windows.Forms.TextBox();
            this.lblConfBdSenha = new System.Windows.Forms.Label();
            this.btnConfBdTesteConexao = new System.Windows.Forms.Button();
            this.bkwLoading = new System.ComponentModel.BackgroundWorker();
            this.pnlDados.SuspendLayout();
            this.pnlBotao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnConfBdTesteConexao);
            this.pnlDados.Controls.Add(this.txbConfBdSenha);
            this.pnlDados.Controls.Add(this.lblConfBdSenha);
            this.pnlDados.Controls.Add(this.txbConfBdUsuario);
            this.pnlDados.Controls.Add(this.lblConfBdUsuario);
            this.pnlDados.Controls.Add(this.txbConfBdBancoDados);
            this.pnlDados.Controls.Add(this.lblConfBdBd);
            this.pnlDados.Controls.Add(this.txbConfBdServidor);
            this.pnlDados.Controls.Add(this.lblConfBdServidor);
            this.pnlDados.Size = new System.Drawing.Size(745, 261);
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.Visible = false;
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
            // lblConfBdServidor
            // 
            this.lblConfBdServidor.AutoSize = true;
            this.lblConfBdServidor.Location = new System.Drawing.Point(14, 24);
            this.lblConfBdServidor.Name = "lblConfBdServidor";
            this.lblConfBdServidor.Size = new System.Drawing.Size(46, 13);
            this.lblConfBdServidor.TabIndex = 0;
            this.lblConfBdServidor.Text = "Servidor";
            // 
            // txbConfBdServidor
            // 
            this.txbConfBdServidor.Location = new System.Drawing.Point(17, 40);
            this.txbConfBdServidor.Name = "txbConfBdServidor";
            this.txbConfBdServidor.Size = new System.Drawing.Size(711, 20);
            this.txbConfBdServidor.TabIndex = 1;
            // 
            // txbConfBdBancoDados
            // 
            this.txbConfBdBancoDados.Location = new System.Drawing.Point(17, 81);
            this.txbConfBdBancoDados.Name = "txbConfBdBancoDados";
            this.txbConfBdBancoDados.Size = new System.Drawing.Size(711, 20);
            this.txbConfBdBancoDados.TabIndex = 3;
            // 
            // lblConfBdBd
            // 
            this.lblConfBdBd.AutoSize = true;
            this.lblConfBdBd.Location = new System.Drawing.Point(14, 65);
            this.lblConfBdBd.Name = "lblConfBdBd";
            this.lblConfBdBd.Size = new System.Drawing.Size(87, 13);
            this.lblConfBdBd.TabIndex = 2;
            this.lblConfBdBd.Text = "Banco de Dados";
            // 
            // txbConfBdUsuario
            // 
            this.txbConfBdUsuario.Location = new System.Drawing.Point(17, 122);
            this.txbConfBdUsuario.Name = "txbConfBdUsuario";
            this.txbConfBdUsuario.Size = new System.Drawing.Size(711, 20);
            this.txbConfBdUsuario.TabIndex = 5;
            // 
            // lblConfBdUsuario
            // 
            this.lblConfBdUsuario.AutoSize = true;
            this.lblConfBdUsuario.Location = new System.Drawing.Point(14, 106);
            this.lblConfBdUsuario.Name = "lblConfBdUsuario";
            this.lblConfBdUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblConfBdUsuario.TabIndex = 4;
            this.lblConfBdUsuario.Text = "Usuário";
            // 
            // txbConfBdSenha
            // 
            this.txbConfBdSenha.Location = new System.Drawing.Point(17, 163);
            this.txbConfBdSenha.Name = "txbConfBdSenha";
            this.txbConfBdSenha.PasswordChar = '*';
            this.txbConfBdSenha.Size = new System.Drawing.Size(711, 20);
            this.txbConfBdSenha.TabIndex = 7;
            // 
            // lblConfBdSenha
            // 
            this.lblConfBdSenha.AutoSize = true;
            this.lblConfBdSenha.Location = new System.Drawing.Point(14, 147);
            this.lblConfBdSenha.Name = "lblConfBdSenha";
            this.lblConfBdSenha.Size = new System.Drawing.Size(38, 13);
            this.lblConfBdSenha.TabIndex = 6;
            this.lblConfBdSenha.Text = "Senha";
            // 
            // btnConfBdTesteConexao
            // 
            this.btnConfBdTesteConexao.BackColor = System.Drawing.Color.Transparent;
            this.btnConfBdTesteConexao.FlatAppearance.BorderSize = 0;
            this.btnConfBdTesteConexao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConfBdTesteConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfBdTesteConexao.Location = new System.Drawing.Point(608, 204);
            this.btnConfBdTesteConexao.Name = "btnConfBdTesteConexao";
            this.btnConfBdTesteConexao.Size = new System.Drawing.Size(120, 40);
            this.btnConfBdTesteConexao.TabIndex = 8;
            this.btnConfBdTesteConexao.Text = "Testar Conexão";
            this.btnConfBdTesteConexao.UseVisualStyleBackColor = false;
            this.btnConfBdTesteConexao.Click += new System.EventHandler(this.btnConfBdTesteConexao_Click);
            // 
            // bkwLoading
            // 
            // 
            // frmConfigBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 600);
            this.Name = "frmConfigBancoDados";
            this.Text = "Configuração Banco de Dados";
            this.Load += new System.EventHandler(this.frmConfigBancoDados_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlBotao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConfBdServidor;
        private System.Windows.Forms.TextBox txbConfBdSenha;
        private System.Windows.Forms.Label lblConfBdSenha;
        private System.Windows.Forms.TextBox txbConfBdUsuario;
        private System.Windows.Forms.Label lblConfBdUsuario;
        private System.Windows.Forms.TextBox txbConfBdBancoDados;
        private System.Windows.Forms.Label lblConfBdBd;
        private System.Windows.Forms.TextBox txbConfBdServidor;
        private System.Windows.Forms.Button btnConfBdTesteConexao;
        private System.ComponentModel.BackgroundWorker bkwLoading;
    }
}
