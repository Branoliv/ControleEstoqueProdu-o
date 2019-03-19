namespace GUI
{
    partial class frmItensDeposito
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
            this.txbItDepNomeAbr = new System.Windows.Forms.TextBox();
            this.lblItDepNomeAbr = new System.Windows.Forms.Label();
            this.txbItDepCodProd = new System.Windows.Forms.TextBox();
            this.lblItDepCod = new System.Windows.Forms.Label();
            this.btnItDepLocDep = new System.Windows.Forms.Button();
            this.btntDepLocProd = new System.Windows.Forms.Button();
            this.lblItDepNomeProd = new System.Windows.Forms.Label();
            this.lblItDepNome = new System.Windows.Forms.Label();
            this.pnlBotao.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.lblItDepNome);
            this.pnlDados.Controls.Add(this.lblItDepNomeProd);
            this.pnlDados.Controls.Add(this.btntDepLocProd);
            this.pnlDados.Controls.Add(this.btnItDepLocDep);
            this.pnlDados.Controls.Add(this.txbItDepNomeAbr);
            this.pnlDados.Controls.Add(this.lblItDepNomeAbr);
            this.pnlDados.Controls.Add(this.txbItDepCodProd);
            this.pnlDados.Controls.Add(this.lblItDepCod);
            this.pnlDados.Size = new System.Drawing.Size(745, 122);
            this.pnlDados.TabIndex = 0;
            // 
            // txbItDepNomeAbr
            // 
            this.txbItDepNomeAbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbItDepNomeAbr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbItDepNomeAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbItDepNomeAbr.Location = new System.Drawing.Point(24, 75);
            this.txbItDepNomeAbr.MaxLength = 4;
            this.txbItDepNomeAbr.Name = "txbItDepNomeAbr";
            this.txbItDepNomeAbr.Size = new System.Drawing.Size(85, 20);
            this.txbItDepNomeAbr.TabIndex = 4;
            this.txbItDepNomeAbr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbItDepNomeAbr.Enter += new System.EventHandler(this.txbItDepNomeAbr_Enter);
            this.txbItDepNomeAbr.Leave += new System.EventHandler(this.txbItDepNomeAbr_Leave);
            // 
            // lblItDepNomeAbr
            // 
            this.lblItDepNomeAbr.AutoSize = true;
            this.lblItDepNomeAbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItDepNomeAbr.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblItDepNomeAbr.Location = new System.Drawing.Point(21, 59);
            this.lblItDepNomeAbr.Name = "lblItDepNomeAbr";
            this.lblItDepNomeAbr.Size = new System.Drawing.Size(57, 13);
            this.lblItDepNomeAbr.TabIndex = 3;
            this.lblItDepNomeAbr.Text = "Depósito";
            // 
            // txbItDepCodProd
            // 
            this.txbItDepCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbItDepCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbItDepCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbItDepCodProd.Location = new System.Drawing.Point(24, 32);
            this.txbItDepCodProd.Name = "txbItDepCodProd";
            this.txbItDepCodProd.Size = new System.Drawing.Size(85, 20);
            this.txbItDepCodProd.TabIndex = 1;
            this.txbItDepCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbItDepCodProd.Enter += new System.EventHandler(this.txbItDepCodProd_Enter);
            this.txbItDepCodProd.Leave += new System.EventHandler(this.txbItDepCodProd_Leave);
            // 
            // lblItDepCod
            // 
            this.lblItDepCod.AutoSize = true;
            this.lblItDepCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItDepCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblItDepCod.Location = new System.Drawing.Point(21, 16);
            this.lblItDepCod.Name = "lblItDepCod";
            this.lblItDepCod.Size = new System.Drawing.Size(51, 13);
            this.lblItDepCod.TabIndex = 0;
            this.lblItDepCod.Text = "Produto";
            // 
            // btnItDepLocDep
            // 
            this.btnItDepLocDep.BackColor = System.Drawing.Color.Gray;
            this.btnItDepLocDep.FlatAppearance.BorderSize = 0;
            this.btnItDepLocDep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnItDepLocDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItDepLocDep.Location = new System.Drawing.Point(111, 75);
            this.btnItDepLocDep.Name = "btnItDepLocDep";
            this.btnItDepLocDep.Size = new System.Drawing.Size(20, 20);
            this.btnItDepLocDep.TabIndex = 5;
            this.btnItDepLocDep.TabStop = false;
            this.btnItDepLocDep.UseVisualStyleBackColor = false;
            this.btnItDepLocDep.Click += new System.EventHandler(this.btnItDepLocDep_Click);
            // 
            // btntDepLocProd
            // 
            this.btntDepLocProd.BackColor = System.Drawing.Color.Gray;
            this.btntDepLocProd.FlatAppearance.BorderSize = 0;
            this.btntDepLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btntDepLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntDepLocProd.Location = new System.Drawing.Point(111, 32);
            this.btntDepLocProd.Name = "btntDepLocProd";
            this.btntDepLocProd.Size = new System.Drawing.Size(20, 20);
            this.btntDepLocProd.TabIndex = 2;
            this.btntDepLocProd.TabStop = false;
            this.btntDepLocProd.UseVisualStyleBackColor = false;
            this.btntDepLocProd.Click += new System.EventHandler(this.btntDepLocProd_Click);
            // 
            // lblItDepNomeProd
            // 
            this.lblItDepNomeProd.AutoSize = true;
            this.lblItDepNomeProd.Location = new System.Drawing.Point(159, 36);
            this.lblItDepNomeProd.Name = "lblItDepNomeProd";
            this.lblItDepNomeProd.Size = new System.Drawing.Size(80, 13);
            this.lblItDepNomeProd.TabIndex = 13;
            this.lblItDepNomeProd.Text = "Descrição Prod";
            // 
            // lblItDepNome
            // 
            this.lblItDepNome.AutoSize = true;
            this.lblItDepNome.Location = new System.Drawing.Point(159, 79);
            this.lblItDepNome.Name = "lblItDepNome";
            this.lblItDepNome.Size = new System.Drawing.Size(58, 13);
            this.lblItDepNome.TabIndex = 14;
            this.lblItDepNome.Text = "Nome Dep";
            // 
            // frmItensDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 600);
            this.Name = "frmItensDeposito";
            this.Text = "Cadastro depósito por material";
            this.Load += new System.EventHandler(this.frmItensDeposito_Load);
            this.pnlBotao.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbItDepNomeAbr;
        private System.Windows.Forms.Label lblItDepNomeAbr;
        private System.Windows.Forms.TextBox txbItDepCodProd;
        private System.Windows.Forms.Label lblItDepCod;
        private System.Windows.Forms.Button btnItDepLocDep;
        private System.Windows.Forms.Button btntDepLocProd;
        private System.Windows.Forms.Label lblItDepNomeProd;
        private System.Windows.Forms.Label lblItDepNome;
    }
}
