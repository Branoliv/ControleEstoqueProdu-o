namespace GUI
{
    partial class frmGrupoMaterial
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
            this.txbGrpMatNome = new System.Windows.Forms.TextBox();
            this.lblGrpMatNome = new System.Windows.Forms.Label();
            this.txbGrpMatCod = new System.Windows.Forms.TextBox();
            this.lblGrpMatCod = new System.Windows.Forms.Label();
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
            this.pnlDados.Controls.Add(this.txbGrpMatNome);
            this.pnlDados.Controls.Add(this.lblGrpMatNome);
            this.pnlDados.Controls.Add(this.txbGrpMatCod);
            this.pnlDados.Controls.Add(this.lblGrpMatCod);
            this.pnlDados.Size = new System.Drawing.Size(745, 121);
            this.pnlDados.TabIndex = 0;
            // 
            // txbGrpMatNome
            // 
            this.txbGrpMatNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGrpMatNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbGrpMatNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGrpMatNome.Location = new System.Drawing.Point(24, 77);
            this.txbGrpMatNome.Name = "txbGrpMatNome";
            this.txbGrpMatNome.Size = new System.Drawing.Size(368, 20);
            this.txbGrpMatNome.TabIndex = 2;
            this.txbGrpMatNome.Enter += new System.EventHandler(this.txbGrpMatNome_Enter);
            this.txbGrpMatNome.Leave += new System.EventHandler(this.txbGrpMatNome_Leave);
            // 
            // lblGrpMatNome
            // 
            this.lblGrpMatNome.AutoSize = true;
            this.lblGrpMatNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrpMatNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGrpMatNome.Location = new System.Drawing.Point(21, 61);
            this.lblGrpMatNome.Name = "lblGrpMatNome";
            this.lblGrpMatNome.Size = new System.Drawing.Size(96, 13);
            this.lblGrpMatNome.TabIndex = 10;
            this.lblGrpMatNome.Text = "Grupo Materiais";
            // 
            // txbGrpMatCod
            // 
            this.txbGrpMatCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGrpMatCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbGrpMatCod.Enabled = false;
            this.txbGrpMatCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGrpMatCod.Location = new System.Drawing.Point(24, 31);
            this.txbGrpMatCod.Name = "txbGrpMatCod";
            this.txbGrpMatCod.Size = new System.Drawing.Size(63, 20);
            this.txbGrpMatCod.TabIndex = 1;
            this.txbGrpMatCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbGrpMatCod.Enter += new System.EventHandler(this.txbGrpMatCod_Enter);
            this.txbGrpMatCod.Leave += new System.EventHandler(this.txbGrpMatCod_Leave);
            // 
            // lblGrpMatCod
            // 
            this.lblGrpMatCod.AutoSize = true;
            this.lblGrpMatCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrpMatCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGrpMatCod.Location = new System.Drawing.Point(21, 15);
            this.lblGrpMatCod.Name = "lblGrpMatCod";
            this.lblGrpMatCod.Size = new System.Drawing.Size(46, 13);
            this.lblGrpMatCod.TabIndex = 8;
            this.lblGrpMatCod.Text = "Código";
            // 
            // frmGrupoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 617);
            this.Name = "frmGrupoMaterial";
            this.Text = "Grupo de Materiais";
            this.Load += new System.EventHandler(this.frmGrupoMaterial_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbGrpMatNome;
        private System.Windows.Forms.Label lblGrpMatNome;
        private System.Windows.Forms.TextBox txbGrpMatCod;
        private System.Windows.Forms.Label lblGrpMatCod;
    }
}
