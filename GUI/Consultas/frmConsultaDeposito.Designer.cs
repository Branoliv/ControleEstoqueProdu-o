namespace GUI
{
    partial class frmConsultaDeposito
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
            this.dgvConsDeposito = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsDeposito)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.Size = new System.Drawing.Size(491, 68);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Size = new System.Drawing.Size(467, 100);
            // 
            // txbConsNome
            // 
            this.txbConsNome.Size = new System.Drawing.Size(422, 20);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Location = new System.Drawing.Point(416, 0);
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
            // dgvConsDeposito
            // 
            this.dgvConsDeposito.AllowUserToAddRows = false;
            this.dgvConsDeposito.AllowUserToDeleteRows = false;
            this.dgvConsDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsDeposito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsDeposito.Location = new System.Drawing.Point(12, 224);
            this.dgvConsDeposito.MultiSelect = false;
            this.dgvConsDeposito.Name = "dgvConsDeposito";
            this.dgvConsDeposito.ReadOnly = true;
            this.dgvConsDeposito.RowTemplate.Height = 16;
            this.dgvConsDeposito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsDeposito.Size = new System.Drawing.Size(467, 360);
            this.dgvConsDeposito.TabIndex = 6;
            this.dgvConsDeposito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsDeposito_CellDoubleClick);
            // 
            // frmConsultaDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(491, 596);
            this.Controls.Add(this.dgvConsDeposito);
            this.Name = "frmConsultaDeposito";
            this.Controls.SetChildIndex(this.pnlBotao, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvConsDeposito, 0);
            this.pnlBotao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsDeposito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsDeposito;
    }
}
