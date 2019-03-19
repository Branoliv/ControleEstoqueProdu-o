namespace GUI
{
    partial class frmConsultaFornecedor
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
            this.dgvConsFornecedor = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(780, 68);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Size = new System.Drawing.Size(760, 100);
            // 
            // txbConsNome
            // 
            this.txbConsNome.Size = new System.Drawing.Size(709, 20);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(705, 0);
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
            // dgvConsFornecedor
            // 
            this.dgvConsFornecedor.AllowUserToAddRows = false;
            this.dgvConsFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsFornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsFornecedor.Location = new System.Drawing.Point(12, 222);
            this.dgvConsFornecedor.Name = "dgvConsFornecedor";
            this.dgvConsFornecedor.RowTemplate.Height = 16;
            this.dgvConsFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsFornecedor.Size = new System.Drawing.Size(760, 422);
            this.dgvConsFornecedor.TabIndex = 5;
            this.dgvConsFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsFornecedor_CellDoubleClick);
            // 
            // frmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.Controls.Add(this.dgvConsFornecedor);
            this.Name = "frmConsultaFornecedor";
            this.Text = "Consulta Fornecedor";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsFornecedor, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsFornecedor;
    }
}
