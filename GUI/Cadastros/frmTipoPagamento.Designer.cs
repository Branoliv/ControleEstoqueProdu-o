namespace GUI
{
    partial class frmTipoPagamento
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
            this.txbTpPagtoNome = new System.Windows.Forms.TextBox();
            this.lblTpPagtoNome = new System.Windows.Forms.Label();
            this.txbTpPagtoCod = new System.Windows.Forms.TextBox();
            this.lblTpPagtoCod = new System.Windows.Forms.Label();
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
            this.pnlDados.Controls.Add(this.txbTpPagtoNome);
            this.pnlDados.Controls.Add(this.lblTpPagtoNome);
            this.pnlDados.Controls.Add(this.txbTpPagtoCod);
            this.pnlDados.Controls.Add(this.lblTpPagtoCod);
            this.pnlDados.Size = new System.Drawing.Size(745, 121);
            this.pnlDados.TabIndex = 0;
            // 
            // txbTpPagtoNome
            // 
            this.txbTpPagtoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTpPagtoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbTpPagtoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTpPagtoNome.Location = new System.Drawing.Point(24, 77);
            this.txbTpPagtoNome.MaxLength = 90;
            this.txbTpPagtoNome.Name = "txbTpPagtoNome";
            this.txbTpPagtoNome.Size = new System.Drawing.Size(368, 20);
            this.txbTpPagtoNome.TabIndex = 3;
            this.txbTpPagtoNome.Enter += new System.EventHandler(this.txbTpPagtoNome_Enter);
            this.txbTpPagtoNome.Leave += new System.EventHandler(this.txbTpPagtoNome_Leave);
            // 
            // lblTpPagtoNome
            // 
            this.lblTpPagtoNome.AutoSize = true;
            this.lblTpPagtoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpPagtoNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTpPagtoNome.Location = new System.Drawing.Point(21, 61);
            this.lblTpPagtoNome.Name = "lblTpPagtoNome";
            this.lblTpPagtoNome.Size = new System.Drawing.Size(117, 13);
            this.lblTpPagtoNome.TabIndex = 2;
            this.lblTpPagtoNome.Text = "Tipo de Pagamento";
            // 
            // txbTpPagtoCod
            // 
            this.txbTpPagtoCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTpPagtoCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbTpPagtoCod.Enabled = false;
            this.txbTpPagtoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTpPagtoCod.Location = new System.Drawing.Point(24, 31);
            this.txbTpPagtoCod.Name = "txbTpPagtoCod";
            this.txbTpPagtoCod.Size = new System.Drawing.Size(63, 20);
            this.txbTpPagtoCod.TabIndex = 1;
            this.txbTpPagtoCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTpPagtoCod.Enter += new System.EventHandler(this.txbTpPagtoCod_Enter);
            this.txbTpPagtoCod.Leave += new System.EventHandler(this.TxbTpPagtoCod_Leave);
            // 
            // lblTpPagtoCod
            // 
            this.lblTpPagtoCod.AutoSize = true;
            this.lblTpPagtoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpPagtoCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTpPagtoCod.Location = new System.Drawing.Point(21, 15);
            this.lblTpPagtoCod.Name = "lblTpPagtoCod";
            this.lblTpPagtoCod.Size = new System.Drawing.Size(46, 13);
            this.lblTpPagtoCod.TabIndex = 0;
            this.lblTpPagtoCod.Text = "Código";
            // 
            // frmTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 600);
            this.Name = "frmTipoPagamento";
            this.Text = "Tipo de Pagamento";
            this.Load += new System.EventHandler(this.frmTipoPagamento_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbTpPagtoNome;
        private System.Windows.Forms.Label lblTpPagtoNome;
        private System.Windows.Forms.TextBox txbTpPagtoCod;
        private System.Windows.Forms.Label lblTpPagtoCod;
    }
}
