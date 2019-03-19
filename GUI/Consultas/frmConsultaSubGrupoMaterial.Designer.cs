namespace GUI
{
    partial class frmConsultaSubGrupoMaterial
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
            this.dgvConsSubGrpMaterial = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsSubGrpMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(489, 68);
            this.pnlBotao.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Size = new System.Drawing.Size(467, 100);
            // 
            // txbConsNome
            // 
            this.txbConsNome.Size = new System.Drawing.Size(410, 20);
            this.txbConsNome.Enter += new System.EventHandler(this.txbConsNome_Enter);
            this.txbConsNome.Leave += new System.EventHandler(this.txbConsNome_Leave);
            // 
            // lblConsNome
            // 
            this.lblConsNome.Size = new System.Drawing.Size(83, 13);
            this.lblConsNome.Text = "SubCategoria";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(414, 0);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // LblTituloModeloConsulta
            // 
            this.LblTituloModeloConsulta.Size = new System.Drawing.Size(210, 29);
            this.LblTituloModeloConsulta.Text = "Modelo Consulta";
            // 
            // dgvConsSubGrpMaterial
            // 
            this.dgvConsSubGrpMaterial.AllowUserToAddRows = false;
            this.dgvConsSubGrpMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsSubGrpMaterial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsSubGrpMaterial.Location = new System.Drawing.Point(12, 224);
            this.dgvConsSubGrpMaterial.MultiSelect = false;
            this.dgvConsSubGrpMaterial.Name = "dgvConsSubGrpMaterial";
            this.dgvConsSubGrpMaterial.RowTemplate.Height = 16;
            this.dgvConsSubGrpMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsSubGrpMaterial.Size = new System.Drawing.Size(467, 388);
            this.dgvConsSubGrpMaterial.TabIndex = 1;
            this.dgvConsSubGrpMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsSubGrpMaterial_CellDoubleClick);
            // 
            // frmConsultaSubGrupoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(489, 624);
            this.Controls.Add(this.dgvConsSubGrpMaterial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaSubGrupoMaterial";
            this.Text = "Consulta SubGrupo Material";
            this.Controls.SetChildIndex(this.dgvConsSubGrpMaterial, 0);
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsSubGrpMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsSubGrpMaterial;
    }
}
