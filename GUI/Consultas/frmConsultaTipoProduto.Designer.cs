namespace GUI
{
    partial class frmConsultaTipoProduto
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
            this.dgvConsTipoProduto = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsTipoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(736, 68);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 117);
            this.panel2.Size = new System.Drawing.Size(710, 100);
            // 
            // txbConsNome
            // 
            this.txbConsNome.Location = new System.Drawing.Point(22, 45);
            this.txbConsNome.Size = new System.Drawing.Size(664, 20);
            this.txbConsNome.Enter += new System.EventHandler(this.txbConsNome_Enter);
            this.txbConsNome.Leave += new System.EventHandler(this.txbConsNome_Leave);
            // 
            // lblConsNome
            // 
            this.lblConsNome.Location = new System.Drawing.Point(19, 29);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(661, 0);
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
            // dgvConsTipoProduto
            // 
            this.dgvConsTipoProduto.AllowUserToAddRows = false;
            this.dgvConsTipoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsTipoProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsTipoProduto.Location = new System.Drawing.Point(12, 222);
            this.dgvConsTipoProduto.Name = "dgvConsTipoProduto";
            this.dgvConsTipoProduto.RowHeadersVisible = false;
            this.dgvConsTipoProduto.RowTemplate.Height = 16;
            this.dgvConsTipoProduto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsTipoProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsTipoProduto.Size = new System.Drawing.Size(710, 342);
            this.dgvConsTipoProduto.TabIndex = 6;
            this.dgvConsTipoProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsTipoProduto_CellDoubleClick);
            // 
            // frmConsultaTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 576);
            this.Controls.Add(this.dgvConsTipoProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaTipoProduto";
            this.Text = "Consulta tipo de produto";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsTipoProduto, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsTipoProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsTipoProduto;
    }
}
