namespace GUI
{
    partial class frmSubGrupoMaterial
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
            this.txbSubGrpMatNome = new System.Windows.Forms.TextBox();
            this.lblSubGrpMatNome = new System.Windows.Forms.Label();
            this.txbSubGrpMatCodigo = new System.Windows.Forms.TextBox();
            this.lblGrpMatCod = new System.Windows.Forms.Label();
            this.lblSubGrpGrupoMaterial = new System.Windows.Forms.Label();
            this.cbxSubGrpMatGrupoMaterial = new System.Windows.Forms.ComboBox();
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
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(770, 68);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.cbxSubGrpMatGrupoMaterial);
            this.pnlDados.Controls.Add(this.lblSubGrpGrupoMaterial);
            this.pnlDados.Controls.Add(this.txbSubGrpMatNome);
            this.pnlDados.Controls.Add(this.lblSubGrpMatNome);
            this.pnlDados.Controls.Add(this.txbSubGrpMatCodigo);
            this.pnlDados.Controls.Add(this.lblGrpMatCod);
            this.pnlDados.Size = new System.Drawing.Size(745, 170);
            this.pnlDados.TabIndex = 0;
            // 
            // txbSubGrpMatNome
            // 
            this.txbSubGrpMatNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSubGrpMatNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbSubGrpMatNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubGrpMatNome.Location = new System.Drawing.Point(20, 128);
            this.txbSubGrpMatNome.Name = "txbSubGrpMatNome";
            this.txbSubGrpMatNome.Size = new System.Drawing.Size(368, 20);
            this.txbSubGrpMatNome.TabIndex = 2;
            this.txbSubGrpMatNome.Enter += new System.EventHandler(this.txbSubGrpMatNome_Enter);
            this.txbSubGrpMatNome.Leave += new System.EventHandler(this.txbSubGrpMatNome_Leave);
            // 
            // lblSubGrpMatNome
            // 
            this.lblSubGrpMatNome.AutoSize = true;
            this.lblSubGrpMatNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGrpMatNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubGrpMatNome.Location = new System.Drawing.Point(17, 112);
            this.lblSubGrpMatNome.Name = "lblSubGrpMatNome";
            this.lblSubGrpMatNome.Size = new System.Drawing.Size(118, 13);
            this.lblSubGrpMatNome.TabIndex = 14;
            this.lblSubGrpMatNome.Text = "SubGrupo Materiais";
            // 
            // txbSubGrpMatCodigo
            // 
            this.txbSubGrpMatCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSubGrpMatCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbSubGrpMatCodigo.Enabled = false;
            this.txbSubGrpMatCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubGrpMatCodigo.Location = new System.Drawing.Point(20, 31);
            this.txbSubGrpMatCodigo.Name = "txbSubGrpMatCodigo";
            this.txbSubGrpMatCodigo.Size = new System.Drawing.Size(63, 20);
            this.txbSubGrpMatCodigo.TabIndex = 0;
            this.txbSubGrpMatCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSubGrpMatCodigo.Enter += new System.EventHandler(this.txbSubGrpMatCodigo_Enter);
            this.txbSubGrpMatCodigo.Leave += new System.EventHandler(this.txbSubGrpMatCodigo_Leave);
            // 
            // lblGrpMatCod
            // 
            this.lblGrpMatCod.AutoSize = true;
            this.lblGrpMatCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrpMatCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGrpMatCod.Location = new System.Drawing.Point(17, 15);
            this.lblGrpMatCod.Name = "lblGrpMatCod";
            this.lblGrpMatCod.Size = new System.Drawing.Size(46, 13);
            this.lblGrpMatCod.TabIndex = 13;
            this.lblGrpMatCod.Text = "Código";
            // 
            // lblSubGrpGrupoMaterial
            // 
            this.lblSubGrpGrupoMaterial.AutoSize = true;
            this.lblSubGrpGrupoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGrpGrupoMaterial.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubGrpGrupoMaterial.Location = new System.Drawing.Point(17, 63);
            this.lblSubGrpGrupoMaterial.Name = "lblSubGrpGrupoMaterial";
            this.lblSubGrpGrupoMaterial.Size = new System.Drawing.Size(96, 13);
            this.lblSubGrpGrupoMaterial.TabIndex = 15;
            this.lblSubGrpGrupoMaterial.Text = "Grupo Materiais";
            // 
            // cbxSubGrpMatGrupoMaterial
            // 
            this.cbxSubGrpMatGrupoMaterial.FormattingEnabled = true;
            this.cbxSubGrpMatGrupoMaterial.Location = new System.Drawing.Point(20, 79);
            this.cbxSubGrpMatGrupoMaterial.Name = "cbxSubGrpMatGrupoMaterial";
            this.cbxSubGrpMatGrupoMaterial.Size = new System.Drawing.Size(368, 21);
            this.cbxSubGrpMatGrupoMaterial.TabIndex = 1;
            this.cbxSubGrpMatGrupoMaterial.Enter += new System.EventHandler(this.cbxSubGrpMatGrupoMaterial_Enter);
            this.cbxSubGrpMatGrupoMaterial.Leave += new System.EventHandler(this.cbxSubGrpMatGrupoMaterial_Leave);
            // 
            // frmSubGrupoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(770, 661);
            this.Name = "frmSubGrupoMaterial";
            this.Text = "SubGrupo de Materiais";
            this.Load += new System.EventHandler(this.frmSubGrupoMaterial_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbSubGrpMatNome;
        private System.Windows.Forms.Label lblSubGrpMatNome;
        private System.Windows.Forms.TextBox txbSubGrpMatCodigo;
        private System.Windows.Forms.Label lblGrpMatCod;
        private System.Windows.Forms.Label lblSubGrpGrupoMaterial;
        private System.Windows.Forms.ComboBox cbxSubGrpMatGrupoMaterial;
    }
}
