namespace GUI
{
    partial class frmConsultaPlanoProducao
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
            this.dgvConsPlpProducao = new System.Windows.Forms.DataGridView();
            this.lblPlpDescricaoProd = new System.Windows.Forms.Label();
            this.btnIppLocProd = new System.Windows.Forms.Button();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsPlpProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(756, 68);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPlpDescricaoProd);
            this.panel2.Controls.Add(this.btnIppLocProd);
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Controls.SetChildIndex(this.lblConsNome, 0);
            this.panel2.Controls.SetChildIndex(this.txbConsNome, 0);
            this.panel2.Controls.SetChildIndex(this.btnIppLocProd, 0);
            this.panel2.Controls.SetChildIndex(this.lblPlpDescricaoProd, 0);
            // 
            // txbConsNome
            // 
            this.txbConsNome.Location = new System.Drawing.Point(21, 30);
            this.txbConsNome.Size = new System.Drawing.Size(85, 20);
            this.txbConsNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbConsNome.Enter += new System.EventHandler(this.txbConsNome_Enter);
            this.txbConsNome.Leave += new System.EventHandler(this.txbConsNome_Leave);
            // 
            // lblConsNome
            // 
            this.lblConsNome.Location = new System.Drawing.Point(18, 14);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(681, 0);
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
            // dgvConsPlpProducao
            // 
            this.dgvConsPlpProducao.AllowUserToAddRows = false;
            this.dgvConsPlpProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsPlpProducao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsPlpProducao.Location = new System.Drawing.Point(12, 230);
            this.dgvConsPlpProducao.Name = "dgvConsPlpProducao";
            this.dgvConsPlpProducao.RowTemplate.Height = 16;
            this.dgvConsPlpProducao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsPlpProducao.Size = new System.Drawing.Size(732, 342);
            this.dgvConsPlpProducao.TabIndex = 5;
            this.dgvConsPlpProducao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsPlpProducao_CellDoubleClick);
            // 
            // lblPlpDescricaoProd
            // 
            this.lblPlpDescricaoProd.AutoSize = true;
            this.lblPlpDescricaoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlpDescricaoProd.Location = new System.Drawing.Point(18, 64);
            this.lblPlpDescricaoProd.Name = "lblPlpDescricaoProd";
            this.lblPlpDescricaoProd.Size = new System.Drawing.Size(215, 16);
            this.lblPlpDescricaoProd.TabIndex = 5;
            this.lblPlpDescricaoProd.Text = "Informe o código da matéria prima.";
            // 
            // btnIppLocProd
            // 
            this.btnIppLocProd.BackColor = System.Drawing.Color.Gray;
            this.btnIppLocProd.FlatAppearance.BorderSize = 0;
            this.btnIppLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIppLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIppLocProd.Location = new System.Drawing.Point(112, 30);
            this.btnIppLocProd.Name = "btnIppLocProd";
            this.btnIppLocProd.Size = new System.Drawing.Size(20, 20);
            this.btnIppLocProd.TabIndex = 4;
            this.btnIppLocProd.TabStop = false;
            this.btnIppLocProd.UseVisualStyleBackColor = false;
            this.btnIppLocProd.Click += new System.EventHandler(this.btnIppLocProd_Click);
            // 
            // frmConsultaPlanoProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(756, 584);
            this.Controls.Add(this.dgvConsPlpProducao);
            this.Name = "frmConsultaPlanoProducao";
            this.Text = "Consulta Plano de produção";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsPlpProducao, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsPlpProducao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsPlpProducao;
        private System.Windows.Forms.Label lblPlpDescricaoProd;
        private System.Windows.Forms.Button btnIppLocProd;
    }
}
