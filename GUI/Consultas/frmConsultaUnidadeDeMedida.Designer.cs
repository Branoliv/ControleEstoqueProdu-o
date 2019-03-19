namespace GUI
{
    partial class frmConsultaUnidadeDeMedida
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
            this.dgvConsUnidMedida = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsUnidMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(489, 68);
            this.pnlBotao.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 116);
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
            this.lblConsNome.Size = new System.Drawing.Size(117, 13);
            this.lblConsNome.Text = "Unidade de Medida";
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
            // dgvConsUnidMedida
            // 
            this.dgvConsUnidMedida.AllowUserToAddRows = false;
            this.dgvConsUnidMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsUnidMedida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsUnidMedida.Location = new System.Drawing.Point(12, 222);
            this.dgvConsUnidMedida.MultiSelect = false;
            this.dgvConsUnidMedida.Name = "dgvConsUnidMedida";
            this.dgvConsUnidMedida.RowTemplate.Height = 16;
            this.dgvConsUnidMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsUnidMedida.Size = new System.Drawing.Size(467, 390);
            this.dgvConsUnidMedida.TabIndex = 1;
            this.dgvConsUnidMedida.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsUnidMedida_CellMouseDoubleClick);
            // 
            // frmConsultaUnidadeDeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(489, 624);
            this.Controls.Add(this.dgvConsUnidMedida);
            this.Name = "frmConsultaUnidadeDeMedida";
            this.Text = "Consulta Unidade de Medida";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsUnidMedida, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsUnidMedida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsUnidMedida;
    }
}
