namespace GUI
{
    partial class frmTipoProduto
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
            this.txbTppNomeAbr = new System.Windows.Forms.TextBox();
            this.lblTppNomeAbr = new System.Windows.Forms.Label();
            this.txbTppNome = new System.Windows.Forms.TextBox();
            this.lblTppNome = new System.Windows.Forms.Label();
            this.txbTppCod = new System.Windows.Forms.TextBox();
            this.lblTppCod = new System.Windows.Forms.Label();
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
            this.pnlDados.Controls.Add(this.txbTppNomeAbr);
            this.pnlDados.Controls.Add(this.lblTppNomeAbr);
            this.pnlDados.Controls.Add(this.txbTppNome);
            this.pnlDados.Controls.Add(this.lblTppNome);
            this.pnlDados.Controls.Add(this.txbTppCod);
            this.pnlDados.Controls.Add(this.lblTppCod);
            this.pnlDados.Size = new System.Drawing.Size(745, 159);
            this.pnlDados.TabIndex = 0;
            // 
            // txbTppNomeAbr
            // 
            this.txbTppNomeAbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTppNomeAbr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbTppNomeAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTppNomeAbr.Location = new System.Drawing.Point(23, 116);
            this.txbTppNomeAbr.MaxLength = 4;
            this.txbTppNomeAbr.Name = "txbTppNomeAbr";
            this.txbTppNomeAbr.Size = new System.Drawing.Size(137, 20);
            this.txbTppNomeAbr.TabIndex = 5;
            this.txbTppNomeAbr.Enter += new System.EventHandler(this.txbTppNomeAbr_Enter);
            this.txbTppNomeAbr.Leave += new System.EventHandler(this.txbTppNomeAbr_Leave);
            // 
            // lblTppNomeAbr
            // 
            this.lblTppNomeAbr.AutoSize = true;
            this.lblTppNomeAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTppNomeAbr.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTppNomeAbr.Location = new System.Drawing.Point(20, 100);
            this.lblTppNomeAbr.Name = "lblTppNomeAbr";
            this.lblTppNomeAbr.Size = new System.Drawing.Size(96, 13);
            this.lblTppNomeAbr.TabIndex = 4;
            this.lblTppNomeAbr.Text = "Nome Reduzido";
            // 
            // txbTppNome
            // 
            this.txbTppNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTppNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbTppNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTppNome.Location = new System.Drawing.Point(23, 73);
            this.txbTppNome.MaxLength = 250;
            this.txbTppNome.Name = "txbTppNome";
            this.txbTppNome.Size = new System.Drawing.Size(407, 20);
            this.txbTppNome.TabIndex = 3;
            this.txbTppNome.Enter += new System.EventHandler(this.txbTppNome_Enter);
            this.txbTppNome.Leave += new System.EventHandler(this.txbTppNome_Leave);
            // 
            // lblTppNome
            // 
            this.lblTppNome.AutoSize = true;
            this.lblTppNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTppNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTppNome.Location = new System.Drawing.Point(20, 57);
            this.lblTppNome.Name = "lblTppNome";
            this.lblTppNome.Size = new System.Drawing.Size(39, 13);
            this.lblTppNome.TabIndex = 2;
            this.lblTppNome.Text = "Nome";
            // 
            // txbTppCod
            // 
            this.txbTppCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTppCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbTppCod.Enabled = false;
            this.txbTppCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTppCod.Location = new System.Drawing.Point(23, 32);
            this.txbTppCod.Name = "txbTppCod";
            this.txbTppCod.Size = new System.Drawing.Size(85, 20);
            this.txbTppCod.TabIndex = 1;
            this.txbTppCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTppCod.Enter += new System.EventHandler(this.txbTppCod_Enter);
            this.txbTppCod.Leave += new System.EventHandler(this.txbTppCod_Leave);
            // 
            // lblTppCod
            // 
            this.lblTppCod.AutoSize = true;
            this.lblTppCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTppCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTppCod.Location = new System.Drawing.Point(20, 16);
            this.lblTppCod.Name = "lblTppCod";
            this.lblTppCod.Size = new System.Drawing.Size(46, 13);
            this.lblTppCod.TabIndex = 0;
            this.lblTppCod.Text = "Código";
            // 
            // frmTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 600);
            this.Name = "frmTipoProduto";
            this.Text = "Tipo de Produto";
            this.Load += new System.EventHandler(this.frmTipoProduto_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbTppNomeAbr;
        private System.Windows.Forms.Label lblTppNomeAbr;
        private System.Windows.Forms.TextBox txbTppNome;
        private System.Windows.Forms.Label lblTppNome;
        private System.Windows.Forms.TextBox txbTppCod;
        private System.Windows.Forms.Label lblTppCod;
    }
}
