namespace GUI
{
    partial class frmUnidadeDeMedida
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
            this.txbUnidMedNome = new System.Windows.Forms.TextBox();
            this.lblUnidMedNome = new System.Windows.Forms.Label();
            this.txbUnidMedCodigo = new System.Windows.Forms.TextBox();
            this.lblUnidMedCodigo = new System.Windows.Forms.Label();
            this.txbSimbUnidMedNome = new System.Windows.Forms.TextBox();
            this.lblSimbUnidMedNome = new System.Windows.Forms.Label();
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
            this.pnlDados.Controls.Add(this.txbSimbUnidMedNome);
            this.pnlDados.Controls.Add(this.lblSimbUnidMedNome);
            this.pnlDados.Controls.Add(this.txbUnidMedNome);
            this.pnlDados.Controls.Add(this.lblUnidMedNome);
            this.pnlDados.Controls.Add(this.txbUnidMedCodigo);
            this.pnlDados.Controls.Add(this.lblUnidMedCodigo);
            this.pnlDados.Size = new System.Drawing.Size(745, 155);
            // 
            // txbUnidMedNome
            // 
            this.txbUnidMedNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUnidMedNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbUnidMedNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUnidMedNome.Location = new System.Drawing.Point(28, 75);
            this.txbUnidMedNome.Name = "txbUnidMedNome";
            this.txbUnidMedNome.Size = new System.Drawing.Size(368, 20);
            this.txbUnidMedNome.TabIndex = 12;
            this.txbUnidMedNome.Enter += new System.EventHandler(this.txbUnidMedNome_Enter);
            this.txbUnidMedNome.Leave += new System.EventHandler(this.txbUnidMedNome_Leave);
            // 
            // lblUnidMedNome
            // 
            this.lblUnidMedNome.AutoSize = true;
            this.lblUnidMedNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidMedNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUnidMedNome.Location = new System.Drawing.Point(25, 59);
            this.lblUnidMedNome.Name = "lblUnidMedNome";
            this.lblUnidMedNome.Size = new System.Drawing.Size(117, 13);
            this.lblUnidMedNome.TabIndex = 14;
            this.lblUnidMedNome.Text = "Unidade de Medida";
            // 
            // txbUnidMedCodigo
            // 
            this.txbUnidMedCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUnidMedCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbUnidMedCodigo.Enabled = false;
            this.txbUnidMedCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUnidMedCodigo.Location = new System.Drawing.Point(28, 34);
            this.txbUnidMedCodigo.Name = "txbUnidMedCodigo";
            this.txbUnidMedCodigo.Size = new System.Drawing.Size(63, 20);
            this.txbUnidMedCodigo.TabIndex = 11;
            this.txbUnidMedCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbUnidMedCodigo.Enter += new System.EventHandler(this.txbUnidMedCodigo_Enter);
            this.txbUnidMedCodigo.Leave += new System.EventHandler(this.txbUniMedCodigo_Leave);
            // 
            // lblUnidMedCodigo
            // 
            this.lblUnidMedCodigo.AutoSize = true;
            this.lblUnidMedCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidMedCodigo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUnidMedCodigo.Location = new System.Drawing.Point(25, 18);
            this.lblUnidMedCodigo.Name = "lblUnidMedCodigo";
            this.lblUnidMedCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblUnidMedCodigo.TabIndex = 13;
            this.lblUnidMedCodigo.Text = "Código";
            // 
            // txbSimbUnidMedNome
            // 
            this.txbSimbUnidMedNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSimbUnidMedNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbSimbUnidMedNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSimbUnidMedNome.Location = new System.Drawing.Point(28, 116);
            this.txbSimbUnidMedNome.Name = "txbSimbUnidMedNome";
            this.txbSimbUnidMedNome.Size = new System.Drawing.Size(129, 20);
            this.txbSimbUnidMedNome.TabIndex = 15;
            this.txbSimbUnidMedNome.Enter += new System.EventHandler(this.txbSimbUnidMedNome_Enter);
            this.txbSimbUnidMedNome.Leave += new System.EventHandler(this.txbSimbUnidMedNome_Leave);
            // 
            // lblSimbUnidMedNome
            // 
            this.lblSimbUnidMedNome.AutoSize = true;
            this.lblSimbUnidMedNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbUnidMedNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSimbUnidMedNome.Location = new System.Drawing.Point(25, 100);
            this.lblSimbUnidMedNome.Name = "lblSimbUnidMedNome";
            this.lblSimbUnidMedNome.Size = new System.Drawing.Size(132, 13);
            this.lblSimbUnidMedNome.TabIndex = 16;
            this.lblSimbUnidMedNome.Text = "Símbolo Unid. Medida";
            // 
            // frmUnidadeDeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 600);
            this.Name = "frmUnidadeDeMedida";
            this.Text = "Unidade de Medida";
            this.Load += new System.EventHandler(this.frmUnidadeDeMedida_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbUnidMedNome;
        private System.Windows.Forms.Label lblUnidMedNome;
        private System.Windows.Forms.TextBox txbUnidMedCodigo;
        private System.Windows.Forms.Label lblUnidMedCodigo;
        private System.Windows.Forms.TextBox txbSimbUnidMedNome;
        private System.Windows.Forms.Label lblSimbUnidMedNome;
    }
}
