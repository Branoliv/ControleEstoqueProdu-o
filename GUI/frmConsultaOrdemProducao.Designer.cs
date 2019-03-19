namespace GUI
{
    partial class frmConsultaOrdemProducao
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
            this.pnlConsPedidoVenda = new System.Windows.Forms.Panel();
            this.btnConsLocProduto = new System.Windows.Forms.Button();
            this.txbCodPedidoVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbxCriterioConsOdProducao = new System.Windows.Forms.GroupBox();
            this.rdbConsGeral = new System.Windows.Forms.RadioButton();
            this.rdbConsPedidoVenda = new System.Windows.Forms.RadioButton();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTituloModeloConsulta = new System.Windows.Forms.Label();
            this.dgvConsOrdemProducao = new System.Windows.Forms.DataGridView();
            this.pnlConsPedidoVenda.SuspendLayout();
            this.gpbxCriterioConsOdProducao.SuspendLayout();
            this.pnlBotao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsOrdemProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConsPedidoVenda
            // 
            this.pnlConsPedidoVenda.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlConsPedidoVenda.Controls.Add(this.btnConsLocProduto);
            this.pnlConsPedidoVenda.Controls.Add(this.txbCodPedidoVenda);
            this.pnlConsPedidoVenda.Controls.Add(this.label3);
            this.pnlConsPedidoVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsPedidoVenda.Location = new System.Drawing.Point(0, 143);
            this.pnlConsPedidoVenda.Name = "pnlConsPedidoVenda";
            this.pnlConsPedidoVenda.Size = new System.Drawing.Size(800, 60);
            this.pnlConsPedidoVenda.TabIndex = 18;
            this.pnlConsPedidoVenda.Visible = false;
            // 
            // btnConsLocProduto
            // 
            this.btnConsLocProduto.BackColor = System.Drawing.Color.Gray;
            this.btnConsLocProduto.FlatAppearance.BorderSize = 0;
            this.btnConsLocProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsLocProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsLocProduto.Location = new System.Drawing.Point(89, 28);
            this.btnConsLocProduto.Name = "btnConsLocProduto";
            this.btnConsLocProduto.Size = new System.Drawing.Size(20, 20);
            this.btnConsLocProduto.TabIndex = 12;
            this.btnConsLocProduto.UseVisualStyleBackColor = false;
            // 
            // txbCodPedidoVenda
            // 
            this.txbCodPedidoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodPedidoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbCodPedidoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodPedidoVenda.Location = new System.Drawing.Point(12, 28);
            this.txbCodPedidoVenda.Name = "txbCodPedidoVenda";
            this.txbCodPedidoVenda.Size = new System.Drawing.Size(73, 20);
            this.txbCodPedidoVenda.TabIndex = 5;
            this.txbCodPedidoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbCodPedidoVenda.Enter += new System.EventHandler(this.txbCodPedidoVenda_Enter);
            this.txbCodPedidoVenda.Leave += new System.EventHandler(this.txbCodPedidoVenda_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código";
            // 
            // gpbxCriterioConsOdProducao
            // 
            this.gpbxCriterioConsOdProducao.BackColor = System.Drawing.Color.Gainsboro;
            this.gpbxCriterioConsOdProducao.Controls.Add(this.rdbConsGeral);
            this.gpbxCriterioConsOdProducao.Controls.Add(this.rdbConsPedidoVenda);
            this.gpbxCriterioConsOdProducao.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbxCriterioConsOdProducao.Location = new System.Drawing.Point(0, 102);
            this.gpbxCriterioConsOdProducao.Name = "gpbxCriterioConsOdProducao";
            this.gpbxCriterioConsOdProducao.Size = new System.Drawing.Size(800, 41);
            this.gpbxCriterioConsOdProducao.TabIndex = 13;
            this.gpbxCriterioConsOdProducao.TabStop = false;
            // 
            // rdbConsGeral
            // 
            this.rdbConsGeral.AutoSize = true;
            this.rdbConsGeral.Checked = true;
            this.rdbConsGeral.Location = new System.Drawing.Point(6, 12);
            this.rdbConsGeral.Name = "rdbConsGeral";
            this.rdbConsGeral.Size = new System.Drawing.Size(104, 17);
            this.rdbConsGeral.TabIndex = 5;
            this.rdbConsGeral.TabStop = true;
            this.rdbConsGeral.Text = "Todas as ordens";
            this.rdbConsGeral.UseVisualStyleBackColor = true;
            this.rdbConsGeral.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsPedidoVenda
            // 
            this.rdbConsPedidoVenda.AutoSize = true;
            this.rdbConsPedidoVenda.Location = new System.Drawing.Point(116, 12);
            this.rdbConsPedidoVenda.Name = "rdbConsPedidoVenda";
            this.rdbConsPedidoVenda.Size = new System.Drawing.Size(92, 17);
            this.rdbConsPedidoVenda.TabIndex = 3;
            this.rdbConsPedidoVenda.Text = "Pedido Venda";
            this.rdbConsPedidoVenda.UseVisualStyleBackColor = true;
            this.rdbConsPedidoVenda.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.SlateGray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnLimpar);
            this.pnlBotao.Controls.Add(this.btnLocalizar);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 34);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(800, 68);
            this.pnlBotao.TabIndex = 14;
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
            this.btnSair.Location = new System.Drawing.Point(725, 0);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.LblTituloModeloConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 15;
            // 
            // LblTituloModeloConsulta
            // 
            this.LblTituloModeloConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTituloModeloConsulta.AutoSize = true;
            this.LblTituloModeloConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloModeloConsulta.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTituloModeloConsulta.Location = new System.Drawing.Point(0, 0);
            this.LblTituloModeloConsulta.Name = "LblTituloModeloConsulta";
            this.LblTituloModeloConsulta.Size = new System.Drawing.Size(212, 29);
            this.LblTituloModeloConsulta.TabIndex = 2;
            this.LblTituloModeloConsulta.Text = "Ordem Produção";
            this.LblTituloModeloConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvConsOrdemProducao
            // 
            this.dgvConsOrdemProducao.AllowUserToAddRows = false;
            this.dgvConsOrdemProducao.AllowUserToDeleteRows = false;
            this.dgvConsOrdemProducao.AllowUserToResizeRows = false;
            this.dgvConsOrdemProducao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsOrdemProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsOrdemProducao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsOrdemProducao.Location = new System.Drawing.Point(16, 209);
            this.dgvConsOrdemProducao.MultiSelect = false;
            this.dgvConsOrdemProducao.Name = "dgvConsOrdemProducao";
            this.dgvConsOrdemProducao.ReadOnly = true;
            this.dgvConsOrdemProducao.RowHeadersVisible = false;
            this.dgvConsOrdemProducao.RowTemplate.Height = 16;
            this.dgvConsOrdemProducao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsOrdemProducao.Size = new System.Drawing.Size(772, 443);
            this.dgvConsOrdemProducao.TabIndex = 19;
            this.dgvConsOrdemProducao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsOrdemProducao_CellDoubleClick);
            // 
            // frmConsultaOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.ControlBox = false;
            this.Controls.Add(this.dgvConsOrdemProducao);
            this.Controls.Add(this.pnlConsPedidoVenda);
            this.Controls.Add(this.gpbxCriterioConsOdProducao);
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaOrdemProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Ordem Produção";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaOrdemProducao_KeyDown);
            this.pnlConsPedidoVenda.ResumeLayout(false);
            this.pnlConsPedidoVenda.PerformLayout();
            this.gpbxCriterioConsOdProducao.ResumeLayout(false);
            this.gpbxCriterioConsOdProducao.PerformLayout();
            this.pnlBotao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsOrdemProducao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConsPedidoVenda;
        private System.Windows.Forms.Button btnConsLocProduto;
        protected System.Windows.Forms.TextBox txbCodPedidoVenda;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbxCriterioConsOdProducao;
        private System.Windows.Forms.RadioButton rdbConsGeral;
        private System.Windows.Forms.RadioButton rdbConsPedidoVenda;
        protected System.Windows.Forms.Panel pnlBotao;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnLimpar;
        protected System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label LblTituloModeloConsulta;
        private System.Windows.Forms.DataGridView dgvConsOrdemProducao;
    }
}