namespace GUI
{
    partial class frmItensPedidoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTituloModeloConsulta = new System.Windows.Forms.Label();
            this.gpbxCriterioConsPedVenda = new System.Windows.Forms.GroupBox();
            this.rdbConsCancelado = new System.Windows.Forms.RadioButton();
            this.rdbConsGeral = new System.Windows.Forms.RadioButton();
            this.rdbConsSeOp = new System.Windows.Forms.RadioButton();
            this.rdbConsCoOp = new System.Windows.Forms.RadioButton();
            this.dgvConsItensPedVenda = new System.Windows.Forms.DataGridView();
            this.ped_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipv_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipv_qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipv_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipv_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipv_dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbxCriterioConsPedVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsItensPedVenda)).BeginInit();
            this.SuspendLayout();
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
            this.pnlBotao.Size = new System.Drawing.Size(804, 68);
            this.pnlBotao.TabIndex = 16;
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
            this.btnSair.Location = new System.Drawing.Point(729, 0);
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
            this.panel1.Size = new System.Drawing.Size(804, 34);
            this.panel1.TabIndex = 17;
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
            this.LblTituloModeloConsulta.Size = new System.Drawing.Size(344, 29);
            this.LblTituloModeloConsulta.TabIndex = 2;
            this.LblTituloModeloConsulta.Text = "Consulta itens pedido venda";
            this.LblTituloModeloConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpbxCriterioConsPedVenda
            // 
            this.gpbxCriterioConsPedVenda.BackColor = System.Drawing.Color.Gainsboro;
            this.gpbxCriterioConsPedVenda.Controls.Add(this.rdbConsCancelado);
            this.gpbxCriterioConsPedVenda.Controls.Add(this.rdbConsGeral);
            this.gpbxCriterioConsPedVenda.Controls.Add(this.rdbConsSeOp);
            this.gpbxCriterioConsPedVenda.Controls.Add(this.rdbConsCoOp);
            this.gpbxCriterioConsPedVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbxCriterioConsPedVenda.Location = new System.Drawing.Point(0, 102);
            this.gpbxCriterioConsPedVenda.Name = "gpbxCriterioConsPedVenda";
            this.gpbxCriterioConsPedVenda.Size = new System.Drawing.Size(804, 41);
            this.gpbxCriterioConsPedVenda.TabIndex = 18;
            this.gpbxCriterioConsPedVenda.TabStop = false;
            this.gpbxCriterioConsPedVenda.Visible = false;
            // 
            // rdbConsCancelado
            // 
            this.rdbConsCancelado.AutoSize = true;
            this.rdbConsCancelado.Location = new System.Drawing.Point(316, 12);
            this.rdbConsCancelado.Name = "rdbConsCancelado";
            this.rdbConsCancelado.Size = new System.Drawing.Size(81, 17);
            this.rdbConsCancelado.TabIndex = 6;
            this.rdbConsCancelado.Text = "Cancelados";
            this.rdbConsCancelado.UseVisualStyleBackColor = true;
            this.rdbConsCancelado.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsGeral
            // 
            this.rdbConsGeral.AutoSize = true;
            this.rdbConsGeral.Checked = true;
            this.rdbConsGeral.Location = new System.Drawing.Point(6, 12);
            this.rdbConsGeral.Name = "rdbConsGeral";
            this.rdbConsGeral.Size = new System.Drawing.Size(94, 17);
            this.rdbConsGeral.TabIndex = 5;
            this.rdbConsGeral.TabStop = true;
            this.rdbConsGeral.Text = "Todos os itens";
            this.rdbConsGeral.UseVisualStyleBackColor = true;
            this.rdbConsGeral.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsSeOp
            // 
            this.rdbConsSeOp.AutoSize = true;
            this.rdbConsSeOp.Location = new System.Drawing.Point(124, 12);
            this.rdbConsSeOp.Name = "rdbConsSeOp";
            this.rdbConsSeOp.Size = new System.Drawing.Size(78, 17);
            this.rdbConsSeOp.TabIndex = 2;
            this.rdbConsSeOp.Text = "Sem ordem";
            this.rdbConsSeOp.UseVisualStyleBackColor = true;
            this.rdbConsSeOp.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // rdbConsCoOp
            // 
            this.rdbConsCoOp.AutoSize = true;
            this.rdbConsCoOp.Location = new System.Drawing.Point(213, 12);
            this.rdbConsCoOp.Name = "rdbConsCoOp";
            this.rdbConsCoOp.Size = new System.Drawing.Size(78, 17);
            this.rdbConsCoOp.TabIndex = 3;
            this.rdbConsCoOp.Text = "Com ordem";
            this.rdbConsCoOp.UseVisualStyleBackColor = true;
            this.rdbConsCoOp.CheckedChanged += new System.EventHandler(this.rdbConsGeral_CheckedChanged);
            // 
            // dgvConsItensPedVenda
            // 
            this.dgvConsItensPedVenda.AllowUserToAddRows = false;
            this.dgvConsItensPedVenda.AllowUserToDeleteRows = false;
            this.dgvConsItensPedVenda.AllowUserToResizeRows = false;
            this.dgvConsItensPedVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConsItensPedVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsItensPedVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ped_cod,
            this.ipv_cod,
            this.pro_cod,
            this.ipv_qtde,
            this.ipv_valor,
            this.ipv_status,
            this.ipv_dep});
            this.dgvConsItensPedVenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsItensPedVenda.Location = new System.Drawing.Point(12, 159);
            this.dgvConsItensPedVenda.MultiSelect = false;
            this.dgvConsItensPedVenda.Name = "dgvConsItensPedVenda";
            this.dgvConsItensPedVenda.ReadOnly = true;
            this.dgvConsItensPedVenda.RowHeadersVisible = false;
            this.dgvConsItensPedVenda.RowTemplate.Height = 16;
            this.dgvConsItensPedVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsItensPedVenda.Size = new System.Drawing.Size(772, 394);
            this.dgvConsItensPedVenda.TabIndex = 19;
            this.dgvConsItensPedVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsItensPedVenda_CellDoubleClick);
            // 
            // ped_cod
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ped_cod.DefaultCellStyle = dataGridViewCellStyle1;
            this.ped_cod.HeaderText = "Pedido";
            this.ped_cod.Name = "ped_cod";
            this.ped_cod.ReadOnly = true;
            // 
            // ipv_cod
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ipv_cod.DefaultCellStyle = dataGridViewCellStyle2;
            this.ipv_cod.HeaderText = "Item";
            this.ipv_cod.Name = "ipv_cod";
            this.ipv_cod.ReadOnly = true;
            this.ipv_cod.Width = 40;
            // 
            // pro_cod
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pro_cod.DefaultCellStyle = dataGridViewCellStyle3;
            this.pro_cod.HeaderText = "Produto";
            this.pro_cod.Name = "pro_cod";
            this.pro_cod.ReadOnly = true;
            this.pro_cod.Width = 70;
            // 
            // ipv_qtde
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ipv_qtde.DefaultCellStyle = dataGridViewCellStyle4;
            this.ipv_qtde.HeaderText = "Quant.";
            this.ipv_qtde.Name = "ipv_qtde";
            this.ipv_qtde.ReadOnly = true;
            // 
            // ipv_valor
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ipv_valor.DefaultCellStyle = dataGridViewCellStyle5;
            this.ipv_valor.HeaderText = "Valor";
            this.ipv_valor.Name = "ipv_valor";
            this.ipv_valor.ReadOnly = true;
            // 
            // ipv_status
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ipv_status.DefaultCellStyle = dataGridViewCellStyle6;
            this.ipv_status.HeaderText = "Status";
            this.ipv_status.Name = "ipv_status";
            this.ipv_status.ReadOnly = true;
            this.ipv_status.Width = 50;
            // 
            // ipv_dep
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ipv_dep.DefaultCellStyle = dataGridViewCellStyle7;
            this.ipv_dep.HeaderText = "Depósito";
            this.ipv_dep.Name = "ipv_dep";
            this.ipv_dep.ReadOnly = true;
            this.ipv_dep.Width = 60;
            // 
            // frmItensPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 565);
            this.ControlBox = false;
            this.Controls.Add(this.dgvConsItensPedVenda);
            this.Controls.Add(this.gpbxCriterioConsPedVenda);
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItensPedidoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmItensPedidoVenda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmItensPedidoVenda_KeyDown);
            this.pnlBotao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbxCriterioConsPedVenda.ResumeLayout(false);
            this.gpbxCriterioConsPedVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsItensPedVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlBotao;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnLimpar;
        protected System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label LblTituloModeloConsulta;
        private System.Windows.Forms.GroupBox gpbxCriterioConsPedVenda;
        private System.Windows.Forms.RadioButton rdbConsGeral;
        private System.Windows.Forms.RadioButton rdbConsSeOp;
        private System.Windows.Forms.RadioButton rdbConsCoOp;
        private System.Windows.Forms.DataGridView dgvConsItensPedVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipv_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipv_qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipv_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipv_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipv_dep;
        private System.Windows.Forms.RadioButton rdbConsCancelado;
    }
}