namespace GUI
{
    partial class frmConsultaTipoPagamento
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
            this.dgvConsTpPagto = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsTpPagto)).BeginInit();
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
            this.txbConsNome.Leave += new System.EventHandler(this.TxbConsNome_Leave);
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
            // dgvConsTpPagto
            // 
            this.dgvConsTpPagto.AllowUserToAddRows = false;
            this.dgvConsTpPagto.AllowUserToDeleteRows = false;
            this.dgvConsTpPagto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsTpPagto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsTpPagto.Location = new System.Drawing.Point(12, 230);
            this.dgvConsTpPagto.MultiSelect = false;
            this.dgvConsTpPagto.Name = "dgvConsTpPagto";
            this.dgvConsTpPagto.ReadOnly = true;
            this.dgvConsTpPagto.RowTemplate.Height = 16;
            this.dgvConsTpPagto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsTpPagto.Size = new System.Drawing.Size(467, 381);
            this.dgvConsTpPagto.TabIndex = 6;
            this.dgvConsTpPagto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConsTpPagto_CellMouseDoubleClick);
            // 
            // frmConsultaTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(489, 624);
            this.Controls.Add(this.dgvConsTpPagto);
            this.Name = "frmConsultaTipoPagamento";
            this.Text = "Consulta Tipo de Pagamento";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsTpPagto, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsTpPagto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsTpPagto;
    }
}
