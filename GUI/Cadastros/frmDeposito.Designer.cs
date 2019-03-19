namespace GUI
{
    partial class frmDeposito
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
            this.txbDepCod = new System.Windows.Forms.TextBox();
            this.lblDepCod = new System.Windows.Forms.Label();
            this.txbDepNome = new System.Windows.Forms.TextBox();
            this.lblDepNome = new System.Windows.Forms.Label();
            this.txbDepNomeAbr = new System.Windows.Forms.TextBox();
            this.lblDepNomeAbr = new System.Windows.Forms.Label();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
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
            this.pnlDados.Controls.Add(this.txbDepNomeAbr);
            this.pnlDados.Controls.Add(this.lblDepNomeAbr);
            this.pnlDados.Controls.Add(this.txbDepNome);
            this.pnlDados.Controls.Add(this.lblDepNome);
            this.pnlDados.Controls.Add(this.txbDepCod);
            this.pnlDados.Controls.Add(this.lblDepCod);
            this.pnlDados.Size = new System.Drawing.Size(745, 168);
            this.pnlDados.TabIndex = 0;
            // 
            // txbDepCod
            // 
            this.txbDepCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDepCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDepCod.Enabled = false;
            this.txbDepCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepCod.Location = new System.Drawing.Point(31, 34);
            this.txbDepCod.Name = "txbDepCod";
            this.txbDepCod.Size = new System.Drawing.Size(85, 20);
            this.txbDepCod.TabIndex = 1;
            this.txbDepCod.Enter += new System.EventHandler(this.txbDepCod_Enter);
            this.txbDepCod.Leave += new System.EventHandler(this.txbDepCod_Leave);
            // 
            // lblDepCod
            // 
            this.lblDepCod.AutoSize = true;
            this.lblDepCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDepCod.Location = new System.Drawing.Point(28, 18);
            this.lblDepCod.Name = "lblDepCod";
            this.lblDepCod.Size = new System.Drawing.Size(46, 13);
            this.lblDepCod.TabIndex = 0;
            this.lblDepCod.Text = "Código";
            // 
            // txbDepNome
            // 
            this.txbDepNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDepNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDepNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepNome.Location = new System.Drawing.Point(31, 75);
            this.txbDepNome.MaxLength = 95;
            this.txbDepNome.Name = "txbDepNome";
            this.txbDepNome.Size = new System.Drawing.Size(407, 20);
            this.txbDepNome.TabIndex = 4;
            this.txbDepNome.Enter += new System.EventHandler(this.txbDepNome_Enter);
            this.txbDepNome.Leave += new System.EventHandler(this.txbDepNome_Leave);
            // 
            // lblDepNome
            // 
            this.lblDepNome.AutoSize = true;
            this.lblDepNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDepNome.Location = new System.Drawing.Point(28, 59);
            this.lblDepNome.Name = "lblDepNome";
            this.lblDepNome.Size = new System.Drawing.Size(39, 13);
            this.lblDepNome.TabIndex = 3;
            this.lblDepNome.Text = "Nome";
            // 
            // txbDepNomeAbr
            // 
            this.txbDepNomeAbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDepNomeAbr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDepNomeAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepNomeAbr.Location = new System.Drawing.Point(31, 118);
            this.txbDepNomeAbr.MaxLength = 4;
            this.txbDepNomeAbr.Name = "txbDepNomeAbr";
            this.txbDepNomeAbr.Size = new System.Drawing.Size(137, 20);
            this.txbDepNomeAbr.TabIndex = 6;
            this.txbDepNomeAbr.Enter += new System.EventHandler(this.txbDepNomeAbr_Enter);
            this.txbDepNomeAbr.Leave += new System.EventHandler(this.txbDepNomeAbr_Leave);
            // 
            // lblDepNomeAbr
            // 
            this.lblDepNomeAbr.AutoSize = true;
            this.lblDepNomeAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepNomeAbr.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDepNomeAbr.Location = new System.Drawing.Point(28, 102);
            this.lblDepNomeAbr.Name = "lblDepNomeAbr";
            this.lblDepNomeAbr.Size = new System.Drawing.Size(96, 13);
            this.lblDepNomeAbr.TabIndex = 5;
            this.lblDepNomeAbr.Text = "Nome Reduzido";
            // 
            // frmDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 600);
            this.Name = "frmDeposito";
            this.Text = "Depósito";
            this.Load += new System.EventHandler(this.frmDeposito_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbDepCod;
        private System.Windows.Forms.Label lblDepCod;
        private System.Windows.Forms.TextBox txbDepNomeAbr;
        private System.Windows.Forms.Label lblDepNomeAbr;
        private System.Windows.Forms.TextBox txbDepNome;
        private System.Windows.Forms.Label lblDepNome;
    }
}
