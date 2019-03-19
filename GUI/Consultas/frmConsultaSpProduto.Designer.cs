namespace GUI
{
    partial class frmConsultaSpProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConsSpProduto = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsSpProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(388, 68);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(313, 0);
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
            // LblTituloModeloConsultaSimples
            // 
            this.LblTituloModeloConsultaSimples.Size = new System.Drawing.Size(312, 29);
            this.LblTituloModeloConsultaSimples.Text = "Modelo Consulta Simples";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(12, 113);
            this.panel2.Size = new System.Drawing.Size(363, 77);
            // 
            // txbConsSpNome
            // 
            this.txbConsSpNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbConsSpNome.Size = new System.Drawing.Size(339, 20);
            this.txbConsSpNome.Enter += new System.EventHandler(this.txbConsSpNome_Enter);
            this.txbConsSpNome.Leave += new System.EventHandler(this.txbConsSpNome_Leave);
            // 
            // dgvConsSpProduto
            // 
            this.dgvConsSpProduto.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsSpProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsSpProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsSpProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsSpProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsSpProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsSpProduto.Location = new System.Drawing.Point(12, 203);
            this.dgvConsSpProduto.Name = "dgvConsSpProduto";
            this.dgvConsSpProduto.RowTemplate.Height = 16;
            this.dgvConsSpProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsSpProduto.Size = new System.Drawing.Size(363, 313);
            this.dgvConsSpProduto.TabIndex = 7;
            this.dgvConsSpProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsSpProduto_CellDoubleClick);
            // 
            // frmConsultaSpProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(388, 531);
            this.Controls.Add(this.dgvConsSpProduto);
            this.Name = "frmConsultaSpProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Produto";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsSpProduto, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsSpProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsSpProduto;
    }
}
