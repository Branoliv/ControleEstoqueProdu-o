namespace GUI
{
    partial class frmConsultaPedidoVenda
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
            this.dgvConsPedidoVenda = new System.Windows.Forms.DataGridView();
            this.pnlDtPedido = new System.Windows.Forms.Panel();
            this.dtpkConsPedVenDtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpkConsPedVenDtInicial = new System.Windows.Forms.DateTimePicker();
            this.lblConsPedVenDtFinal = new System.Windows.Forms.Label();
            this.lblConsPedVenDtIni = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblConsNomeCliente = new System.Windows.Forms.Label();
            this.btnConsLocCliente = new System.Windows.Forms.Button();
            this.txbConsPedVenCli = new System.Windows.Forms.TextBox();
            this.lblConsCodCliente = new System.Windows.Forms.Label();
            this.gpbxCriterioConsPedVenda = new System.Windows.Forms.GroupBox();
            this.rdbConsGeral = new System.Windows.Forms.RadioButton();
            this.rdbConsCliente = new System.Windows.Forms.RadioButton();
            this.rdbConsDtPedido = new System.Windows.Forms.RadioButton();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTituloModeloConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsPedidoVenda)).BeginInit();
            this.pnlDtPedido.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.gpbxCriterioConsPedVenda.SuspendLayout();
            this.pnlBotao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsPedidoVenda
            // 
            this.dgvConsPedidoVenda.AllowUserToAddRows = false;
            this.dgvConsPedidoVenda.AllowUserToDeleteRows = false;
            this.dgvConsPedidoVenda.AllowUserToResizeRows = false;
            this.dgvConsPedidoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsPedidoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsPedidoVenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsPedidoVenda.Location = new System.Drawing.Point(12, 343);
            this.dgvConsPedidoVenda.MultiSelect = false;
            this.dgvConsPedidoVenda.Name = "dgvConsPedidoVenda";
            this.dgvConsPedidoVenda.ReadOnly = true;
            this.dgvConsPedidoVenda.RowHeadersVisible = false;
            this.dgvConsPedidoVenda.RowTemplate.Height = 16;
            this.dgvConsPedidoVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsPedidoVenda.Size = new System.Drawing.Size(772, 309);
            this.dgvConsPedidoVenda.TabIndex = 16;
            this.dgvConsPedidoVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsPedidoVenda_CellDoubleClick);
            // 
            // pnlDtPedido
            // 
            this.pnlDtPedido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlDtPedido.Controls.Add(this.dtpkConsPedVenDtFinal);
            this.pnlDtPedido.Controls.Add(this.dtpkConsPedVenDtInicial);
            this.pnlDtPedido.Controls.Add(this.lblConsPedVenDtFinal);
            this.pnlDtPedido.Controls.Add(this.lblConsPedVenDtIni);
            this.pnlDtPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDtPedido.Location = new System.Drawing.Point(0, 203);
            this.pnlDtPedido.Name = "pnlDtPedido";
            this.pnlDtPedido.Size = new System.Drawing.Size(800, 60);
            this.pnlDtPedido.TabIndex = 18;
            this.pnlDtPedido.Visible = false;
            // 
            // dtpkConsPedVenDtFinal
            // 
            this.dtpkConsPedVenDtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkConsPedVenDtFinal.Location = new System.Drawing.Point(138, 28);
            this.dtpkConsPedVenDtFinal.Name = "dtpkConsPedVenDtFinal";
            this.dtpkConsPedVenDtFinal.Size = new System.Drawing.Size(103, 20);
            this.dtpkConsPedVenDtFinal.TabIndex = 9;
            this.dtpkConsPedVenDtFinal.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // dtpkConsPedVenDtInicial
            // 
            this.dtpkConsPedVenDtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkConsPedVenDtInicial.Location = new System.Drawing.Point(12, 28);
            this.dtpkConsPedVenDtInicial.Name = "dtpkConsPedVenDtInicial";
            this.dtpkConsPedVenDtInicial.Size = new System.Drawing.Size(103, 20);
            this.dtpkConsPedVenDtInicial.TabIndex = 8;
            this.dtpkConsPedVenDtInicial.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblConsPedVenDtFinal
            // 
            this.lblConsPedVenDtFinal.AutoSize = true;
            this.lblConsPedVenDtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsPedVenDtFinal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsPedVenDtFinal.Location = new System.Drawing.Point(135, 12);
            this.lblConsPedVenDtFinal.Name = "lblConsPedVenDtFinal";
            this.lblConsPedVenDtFinal.Size = new System.Drawing.Size(55, 13);
            this.lblConsPedVenDtFinal.TabIndex = 6;
            this.lblConsPedVenDtFinal.Text = "Dt. Final";
            // 
            // lblConsPedVenDtIni
            // 
            this.lblConsPedVenDtIni.AutoSize = true;
            this.lblConsPedVenDtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsPedVenDtIni.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsPedVenDtIni.Location = new System.Drawing.Point(9, 12);
            this.lblConsPedVenDtIni.Name = "lblConsPedVenDtIni";
            this.lblConsPedVenDtIni.Size = new System.Drawing.Size(62, 13);
            this.lblConsPedVenDtIni.TabIndex = 4;
            this.lblConsPedVenDtIni.Text = "Dt. Inicial";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlCliente.Controls.Add(this.lblConsNomeCliente);
            this.pnlCliente.Controls.Add(this.btnConsLocCliente);
            this.pnlCliente.Controls.Add(this.txbConsPedVenCli);
            this.pnlCliente.Controls.Add(this.lblConsCodCliente);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(0, 143);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(800, 60);
            this.pnlCliente.TabIndex = 17;
            this.pnlCliente.Visible = false;
            // 
            // lblConsNomeCliente
            // 
            this.lblConsNomeCliente.AutoSize = true;
            this.lblConsNomeCliente.Location = new System.Drawing.Point(135, 32);
            this.lblConsNomeCliente.Name = "lblConsNomeCliente";
            this.lblConsNomeCliente.Size = new System.Drawing.Size(70, 13);
            this.lblConsNomeCliente.TabIndex = 11;
            this.lblConsNomeCliente.Text = "Nome Cliente";
            // 
            // btnConsLocCliente
            // 
            this.btnConsLocCliente.BackColor = System.Drawing.Color.Gray;
            this.btnConsLocCliente.FlatAppearance.BorderSize = 0;
            this.btnConsLocCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsLocCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsLocCliente.Location = new System.Drawing.Point(89, 28);
            this.btnConsLocCliente.Name = "btnConsLocCliente";
            this.btnConsLocCliente.Size = new System.Drawing.Size(20, 20);
            this.btnConsLocCliente.TabIndex = 10;
            this.btnConsLocCliente.UseVisualStyleBackColor = false;
            this.btnConsLocCliente.Click += new System.EventHandler(this.btnConsLocCliente_Click);
            // 
            // txbConsPedVenCli
            // 
            this.txbConsPedVenCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConsPedVenCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbConsPedVenCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsPedVenCli.Location = new System.Drawing.Point(12, 28);
            this.txbConsPedVenCli.Name = "txbConsPedVenCli";
            this.txbConsPedVenCli.Size = new System.Drawing.Size(73, 20);
            this.txbConsPedVenCli.TabIndex = 3;
            this.txbConsPedVenCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbConsPedVenCli.Enter += new System.EventHandler(this.txbConsPedVenCli_Enter);
            this.txbConsPedVenCli.Leave += new System.EventHandler(this.txbConsPedVenCli_Leave);
            // 
            // lblConsCodCliente
            // 
            this.lblConsCodCliente.AutoSize = true;
            this.lblConsCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCodCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsCodCliente.Location = new System.Drawing.Point(9, 12);
            this.lblConsCodCliente.Name = "lblConsCodCliente";
            this.lblConsCodCliente.Size = new System.Drawing.Size(46, 13);
            this.lblConsCodCliente.TabIndex = 2;
            this.lblConsCodCliente.Text = "Código";
            // 
            // gpbxCriterioConsPedVenda
            // 
            this.gpbxCriterioConsPedVenda.BackColor = System.Drawing.Color.Gainsboro;
            this.gpbxCriterioConsPedVenda.Controls.Add(this.rdbConsGeral);
            this.gpbxCriterioConsPedVenda.Controls.Add(this.rdbConsCliente);
            this.gpbxCriterioConsPedVenda.Controls.Add(this.rdbConsDtPedido);
            this.gpbxCriterioConsPedVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbxCriterioConsPedVenda.Location = new System.Drawing.Point(0, 102);
            this.gpbxCriterioConsPedVenda.Name = "gpbxCriterioConsPedVenda";
            this.gpbxCriterioConsPedVenda.Size = new System.Drawing.Size(800, 41);
            this.gpbxCriterioConsPedVenda.TabIndex = 13;
            this.gpbxCriterioConsPedVenda.TabStop = false;
            // 
            // rdbConsGeral
            // 
            this.rdbConsGeral.AutoSize = true;
            this.rdbConsGeral.Checked = true;
            this.rdbConsGeral.Location = new System.Drawing.Point(6, 12);
            this.rdbConsGeral.Name = "rdbConsGeral";
            this.rdbConsGeral.Size = new System.Drawing.Size(109, 17);
            this.rdbConsGeral.TabIndex = 5;
            this.rdbConsGeral.TabStop = true;
            this.rdbConsGeral.Text = "Todos os pedidos";
            this.rdbConsGeral.UseVisualStyleBackColor = true;
            this.rdbConsGeral.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsCliente
            // 
            this.rdbConsCliente.AutoSize = true;
            this.rdbConsCliente.Location = new System.Drawing.Point(124, 12);
            this.rdbConsCliente.Name = "rdbConsCliente";
            this.rdbConsCliente.Size = new System.Drawing.Size(57, 17);
            this.rdbConsCliente.TabIndex = 2;
            this.rdbConsCliente.Text = "Cliente";
            this.rdbConsCliente.UseVisualStyleBackColor = true;
            this.rdbConsCliente.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsDtPedido
            // 
            this.rdbConsDtPedido.AutoSize = true;
            this.rdbConsDtPedido.Location = new System.Drawing.Point(190, 12);
            this.rdbConsDtPedido.Name = "rdbConsDtPedido";
            this.rdbConsDtPedido.Size = new System.Drawing.Size(98, 17);
            this.rdbConsDtPedido.TabIndex = 3;
            this.rdbConsDtPedido.Text = "Data do pedido";
            this.rdbConsDtPedido.UseVisualStyleBackColor = true;
            this.rdbConsDtPedido.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
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
            this.LblTituloModeloConsulta.Size = new System.Drawing.Size(287, 29);
            this.LblTituloModeloConsulta.TabIndex = 2;
            this.LblTituloModeloConsulta.Text = "Consulta Pedido Venda";
            this.LblTituloModeloConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmConsultaPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.dgvConsPedidoVenda);
            this.Controls.Add(this.pnlDtPedido);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.gpbxCriterioConsPedVenda);
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmConsultaPedidoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Pedido Venda";
            this.Load += new System.EventHandler(this.frmConsultaPedidoVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaPedidoVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsPedidoVenda)).EndInit();
            this.pnlDtPedido.ResumeLayout(false);
            this.pnlDtPedido.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.gpbxCriterioConsPedVenda.ResumeLayout(false);
            this.gpbxCriterioConsPedVenda.PerformLayout();
            this.pnlBotao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsPedidoVenda;
        private System.Windows.Forms.Panel pnlDtPedido;
        private System.Windows.Forms.DateTimePicker dtpkConsPedVenDtFinal;
        private System.Windows.Forms.DateTimePicker dtpkConsPedVenDtInicial;
        protected System.Windows.Forms.Label lblConsPedVenDtFinal;
        protected System.Windows.Forms.Label lblConsPedVenDtIni;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblConsNomeCliente;
        private System.Windows.Forms.Button btnConsLocCliente;
        protected System.Windows.Forms.TextBox txbConsPedVenCli;
        protected System.Windows.Forms.Label lblConsCodCliente;
        private System.Windows.Forms.GroupBox gpbxCriterioConsPedVenda;
        private System.Windows.Forms.RadioButton rdbConsGeral;
        private System.Windows.Forms.RadioButton rdbConsCliente;
        private System.Windows.Forms.RadioButton rdbConsDtPedido;
        protected System.Windows.Forms.Panel pnlBotao;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnLimpar;
        protected System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label LblTituloModeloConsulta;
    }
}