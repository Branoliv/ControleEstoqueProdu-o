namespace GUI
{
    partial class frmConsultaSpTipoProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConsSpTipoProduto = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsSpTipoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(357, 68);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(282, 0);
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
            this.panel2.Size = new System.Drawing.Size(333, 77);
            // 
            // txbConsSpNome
            // 
            this.txbConsSpNome.Size = new System.Drawing.Size(308, 20);
            // 
            // dgvConsSpTipoProduto
            // 
            this.dgvConsSpTipoProduto.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsSpTipoProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsSpTipoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsSpTipoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsSpTipoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsSpTipoProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsSpTipoProduto.Location = new System.Drawing.Point(12, 206);
            this.dgvConsSpTipoProduto.Name = "dgvConsSpTipoProduto";
            this.dgvConsSpTipoProduto.RowHeadersVisible = false;
            this.dgvConsSpTipoProduto.RowTemplate.Height = 16;
            this.dgvConsSpTipoProduto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsSpTipoProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsSpTipoProduto.Size = new System.Drawing.Size(334, 313);
            this.dgvConsSpTipoProduto.TabIndex = 8;
            this.dgvConsSpTipoProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsSpTipoProduto_CellDoubleClick);
            // 
            // frmConsultaSpTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(357, 531);
            this.ControlBox = false;
            this.Controls.Add(this.dgvConsSpTipoProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaSpTipoProduto";
            this.Text = "Consulta Sp Tipo Produto";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsSpTipoProduto, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsSpTipoProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsSpTipoProduto;
    }
}
