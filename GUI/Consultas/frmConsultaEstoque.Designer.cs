namespace GUI
{
    partial class frmConsultaEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.pnlConsDados = new System.Windows.Forms.Panel();
            this.btnConsLocProd = new System.Windows.Forms.Button();
            this.lblConsTpProd = new System.Windows.Forms.Label();
            this.txbConsTpProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConsUmProd = new System.Windows.Forms.Label();
            this.txbConsUmProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConsProd = new System.Windows.Forms.Label();
            this.txbConsCodProd = new System.Windows.Forms.TextBox();
            this.lblConsNome = new System.Windows.Forms.Label();
            this.dgvConsEstoque = new System.Windows.Forms.DataGridView();
            this.pnlBotao.SuspendLayout();
            this.pnlConsDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.SlateGray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnLimpar);
            this.pnlBotao.Controls.Add(this.btnLocalizar);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 0);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(635, 68);
            this.pnlBotao.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = global::GUI.Properties.Resources.sairflat40x40;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(560, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 68);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Image = global::GUI.Properties.Resources.limparflat40x40;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(75, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 68);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalizar.Image = global::GUI.Properties.Resources.localizarflat40x40;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocalizar.Location = new System.Drawing.Point(0, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 68);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // pnlConsDados
            // 
            this.pnlConsDados.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlConsDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsDados.Controls.Add(this.btnConsLocProd);
            this.pnlConsDados.Controls.Add(this.lblConsTpProd);
            this.pnlConsDados.Controls.Add(this.txbConsTpProd);
            this.pnlConsDados.Controls.Add(this.label1);
            this.pnlConsDados.Controls.Add(this.lblConsUmProd);
            this.pnlConsDados.Controls.Add(this.txbConsUmProd);
            this.pnlConsDados.Controls.Add(this.label2);
            this.pnlConsDados.Controls.Add(this.lblConsProd);
            this.pnlConsDados.Controls.Add(this.txbConsCodProd);
            this.pnlConsDados.Controls.Add(this.lblConsNome);
            this.pnlConsDados.Location = new System.Drawing.Point(12, 85);
            this.pnlConsDados.Name = "pnlConsDados";
            this.pnlConsDados.Size = new System.Drawing.Size(610, 100);
            this.pnlConsDados.TabIndex = 0;
            // 
            // btnConsLocProd
            // 
            this.btnConsLocProd.BackColor = System.Drawing.Color.Gray;
            this.btnConsLocProd.FlatAppearance.BorderSize = 0;
            this.btnConsLocProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsLocProd.Location = new System.Drawing.Point(203, 12);
            this.btnConsLocProd.Name = "btnConsLocProd";
            this.btnConsLocProd.Size = new System.Drawing.Size(20, 20);
            this.btnConsLocProd.TabIndex = 9;
            this.btnConsLocProd.UseVisualStyleBackColor = false;
            this.btnConsLocProd.Click += new System.EventHandler(this.btnConsLocProd_Click);
            // 
            // lblConsTpProd
            // 
            this.lblConsTpProd.AutoSize = true;
            this.lblConsTpProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsTpProd.Location = new System.Drawing.Point(245, 65);
            this.lblConsTpProd.Name = "lblConsTpProd";
            this.lblConsTpProd.Size = new System.Drawing.Size(0, 15);
            this.lblConsTpProd.TabIndex = 8;
            // 
            // txbConsTpProd
            // 
            this.txbConsTpProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConsTpProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbConsTpProd.Enabled = false;
            this.txbConsTpProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsTpProd.Location = new System.Drawing.Point(123, 64);
            this.txbConsTpProd.Name = "txbConsTpProd";
            this.txbConsTpProd.Size = new System.Drawing.Size(56, 20);
            this.txbConsTpProd.TabIndex = 7;
            this.txbConsTpProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo Material      ";
            // 
            // lblConsUmProd
            // 
            this.lblConsUmProd.AutoSize = true;
            this.lblConsUmProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsUmProd.Location = new System.Drawing.Point(245, 43);
            this.lblConsUmProd.Name = "lblConsUmProd";
            this.lblConsUmProd.Size = new System.Drawing.Size(0, 15);
            this.lblConsUmProd.TabIndex = 5;
            // 
            // txbConsUmProd
            // 
            this.txbConsUmProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConsUmProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbConsUmProd.Enabled = false;
            this.txbConsUmProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsUmProd.Location = new System.Drawing.Point(123, 38);
            this.txbConsUmProd.Name = "txbConsUmProd";
            this.txbConsUmProd.Size = new System.Drawing.Size(56, 20);
            this.txbConsUmProd.TabIndex = 4;
            this.txbConsUmProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbConsUmProd.Enter += new System.EventHandler(this.txbConsUmProd_Enter);
            this.txbConsUmProd.Leave += new System.EventHandler(this.txbConsUmProd_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unid. Medida      ";
            // 
            // lblConsProd
            // 
            this.lblConsProd.AutoSize = true;
            this.lblConsProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsProd.Location = new System.Drawing.Point(245, 17);
            this.lblConsProd.Name = "lblConsProd";
            this.lblConsProd.Size = new System.Drawing.Size(0, 15);
            this.lblConsProd.TabIndex = 2;
            // 
            // txbConsCodProd
            // 
            this.txbConsCodProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConsCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbConsCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsCodProd.Location = new System.Drawing.Point(123, 12);
            this.txbConsCodProd.Name = "txbConsCodProd";
            this.txbConsCodProd.Size = new System.Drawing.Size(78, 20);
            this.txbConsCodProd.TabIndex = 1;
            this.txbConsCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbConsCodProd.Enter += new System.EventHandler(this.txbConsCodProd_Enter);
            this.txbConsCodProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaEstoqu_KeyDown);
            this.txbConsCodProd.Leave += new System.EventHandler(this.txbConsCodProd_Leave);
            // 
            // lblConsNome
            // 
            this.lblConsNome.AutoSize = true;
            this.lblConsNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsNome.Location = new System.Drawing.Point(15, 19);
            this.lblConsNome.Name = "lblConsNome";
            this.lblConsNome.Size = new System.Drawing.Size(108, 13);
            this.lblConsNome.TabIndex = 0;
            this.lblConsNome.Text = "Consulta             ";
            // 
            // dgvConsEstoque
            // 
            this.dgvConsEstoque.AllowUserToAddRows = false;
            this.dgvConsEstoque.AllowUserToDeleteRows = false;
            this.dgvConsEstoque.AllowUserToResizeRows = false;
            this.dgvConsEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsEstoque.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsEstoque.Location = new System.Drawing.Point(12, 200);
            this.dgvConsEstoque.MultiSelect = false;
            this.dgvConsEstoque.Name = "dgvConsEstoque";
            this.dgvConsEstoque.ReadOnly = true;
            this.dgvConsEstoque.RowTemplate.Height = 18;
            this.dgvConsEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsEstoque.Size = new System.Drawing.Size(610, 350);
            this.dgvConsEstoque.TabIndex = 5;
            // 
            // frmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(635, 564);
            this.ControlBox = false;
            this.Controls.Add(this.dgvConsEstoque);
            this.Controls.Add(this.pnlConsDados);
            this.Controls.Add(this.pnlBotao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Estoque";
            this.Load += new System.EventHandler(this.frmConsultaEstoqu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaEstoque_KeyDown);
            this.pnlBotao.ResumeLayout(false);
            this.pnlConsDados.ResumeLayout(false);
            this.pnlConsDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlBotao;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnLimpar;
        protected System.Windows.Forms.Button btnLocalizar;
        protected System.Windows.Forms.Panel pnlConsDados;
        protected System.Windows.Forms.TextBox txbConsCodProd;
        protected System.Windows.Forms.Label lblConsNome;
        private System.Windows.Forms.DataGridView dgvConsEstoque;
        private System.Windows.Forms.Label lblConsProd;
        private System.Windows.Forms.Label lblConsUmProd;
        protected System.Windows.Forms.TextBox txbConsUmProd;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsTpProd;
        protected System.Windows.Forms.TextBox txbConsTpProd;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsLocProd;
    }
}