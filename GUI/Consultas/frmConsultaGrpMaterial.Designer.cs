namespace GUI
{
    partial class frmConsultaGrpMaterial
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
            this.dgvConsGrpMaterial = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsGrpMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(489, 68);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 117);
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
            this.lblConsNome.Size = new System.Drawing.Size(108, 13);
            this.lblConsNome.Text = "Grupo de Material";
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
            this.btnLimpar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // dgvConsGrpMaterial
            // 
            this.dgvConsGrpMaterial.AllowUserToAddRows = false;
            this.dgvConsGrpMaterial.AllowUserToDeleteRows = false;
            this.dgvConsGrpMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsGrpMaterial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsGrpMaterial.Location = new System.Drawing.Point(12, 223);
            this.dgvConsGrpMaterial.MultiSelect = false;
            this.dgvConsGrpMaterial.Name = "dgvConsGrpMaterial";
            this.dgvConsGrpMaterial.ReadOnly = true;
            this.dgvConsGrpMaterial.RowTemplate.Height = 16;
            this.dgvConsGrpMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsGrpMaterial.Size = new System.Drawing.Size(467, 389);
            this.dgvConsGrpMaterial.TabIndex = 5;
            this.dgvConsGrpMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsGrpMaterial_CellDoubleClick);
            // 
            // frmConsultaGrpMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(489, 624);
            this.Controls.Add(this.dgvConsGrpMaterial);
            this.Name = "frmConsultaGrpMaterial";
            this.Text = "Consulta Grupo Materiais";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsGrpMaterial, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsGrpMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsGrpMaterial;
    }
}
