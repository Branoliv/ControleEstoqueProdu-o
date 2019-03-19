namespace GUI
{
    partial class frmApontamentoProducao
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
            this.pnlDados = new System.Windows.Forms.Panel();
            this.gbxIopPa = new System.Windows.Forms.GroupBox();
            this.txbApOdpDeposito = new System.Windows.Forms.TextBox();
            this.lblApOdpDeposito = new System.Windows.Forms.Label();
            this.lblApOdpCod = new System.Windows.Forms.Label();
            this.txbApOdpProCod = new System.Windows.Forms.TextBox();
            this.txbOdpQtde = new System.Windows.Forms.TextBox();
            this.cbxApOdpUnidMed = new System.Windows.Forms.ComboBox();
            this.lblOdpQtde = new System.Windows.Forms.Label();
            this.lblApOdpProCod = new System.Windows.Forms.Label();
            this.lblOdpUnidMed = new System.Windows.Forms.Label();
            this.lblApOdpDescProduto = new System.Windows.Forms.Label();
            this.txbApOdpCod = new System.Windows.Forms.TextBox();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblApOdpItemPedido = new System.Windows.Forms.Label();
            this.txbApOdpItem = new System.Windows.Forms.TextBox();
            this.pnlDados.SuspendLayout();
            this.gbxIopPa.SuspendLayout();
            this.pnlBotao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlDados.Controls.Add(this.gbxIopPa);
            this.pnlDados.Location = new System.Drawing.Point(12, 84);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(750, 151);
            this.pnlDados.TabIndex = 1;
            // 
            // gbxIopPa
            // 
            this.gbxIopPa.Controls.Add(this.lblApOdpItemPedido);
            this.gbxIopPa.Controls.Add(this.txbApOdpItem);
            this.gbxIopPa.Controls.Add(this.txbApOdpDeposito);
            this.gbxIopPa.Controls.Add(this.lblApOdpDeposito);
            this.gbxIopPa.Controls.Add(this.lblApOdpCod);
            this.gbxIopPa.Controls.Add(this.txbApOdpProCod);
            this.gbxIopPa.Controls.Add(this.txbOdpQtde);
            this.gbxIopPa.Controls.Add(this.cbxApOdpUnidMed);
            this.gbxIopPa.Controls.Add(this.lblOdpQtde);
            this.gbxIopPa.Controls.Add(this.lblApOdpProCod);
            this.gbxIopPa.Controls.Add(this.lblOdpUnidMed);
            this.gbxIopPa.Controls.Add(this.lblApOdpDescProduto);
            this.gbxIopPa.Controls.Add(this.txbApOdpCod);
            this.gbxIopPa.Location = new System.Drawing.Point(17, 16);
            this.gbxIopPa.Name = "gbxIopPa";
            this.gbxIopPa.Size = new System.Drawing.Size(711, 119);
            this.gbxIopPa.TabIndex = 1;
            this.gbxIopPa.TabStop = false;
            // 
            // txbApOdpDeposito
            // 
            this.txbApOdpDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApOdpDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbApOdpDeposito.Enabled = false;
            this.txbApOdpDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApOdpDeposito.Location = new System.Drawing.Point(9, 79);
            this.txbApOdpDeposito.Name = "txbApOdpDeposito";
            this.txbApOdpDeposito.Size = new System.Drawing.Size(69, 20);
            this.txbApOdpDeposito.TabIndex = 8;
            this.txbApOdpDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApOdpDeposito
            // 
            this.lblApOdpDeposito.AutoSize = true;
            this.lblApOdpDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApOdpDeposito.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblApOdpDeposito.Location = new System.Drawing.Point(6, 63);
            this.lblApOdpDeposito.Name = "lblApOdpDeposito";
            this.lblApOdpDeposito.Size = new System.Drawing.Size(57, 13);
            this.lblApOdpDeposito.TabIndex = 7;
            this.lblApOdpDeposito.Text = "Depósito";
            // 
            // lblApOdpCod
            // 
            this.lblApOdpCod.AutoSize = true;
            this.lblApOdpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApOdpCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblApOdpCod.Location = new System.Drawing.Point(6, 16);
            this.lblApOdpCod.Name = "lblApOdpCod";
            this.lblApOdpCod.Size = new System.Drawing.Size(46, 13);
            this.lblApOdpCod.TabIndex = 0;
            this.lblApOdpCod.Text = "Código";
            // 
            // txbApOdpProCod
            // 
            this.txbApOdpProCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApOdpProCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbApOdpProCod.Enabled = false;
            this.txbApOdpProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApOdpProCod.Location = new System.Drawing.Point(137, 32);
            this.txbApOdpProCod.Name = "txbApOdpProCod";
            this.txbApOdpProCod.Size = new System.Drawing.Size(85, 20);
            this.txbApOdpProCod.TabIndex = 5;
            this.txbApOdpProCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbOdpQtde
            // 
            this.txbOdpQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOdpQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbOdpQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOdpQtde.Location = new System.Drawing.Point(103, 79);
            this.txbOdpQtde.Name = "txbOdpQtde";
            this.txbOdpQtde.Size = new System.Drawing.Size(85, 20);
            this.txbOdpQtde.TabIndex = 10;
            this.txbOdpQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbOdpQtde.Enter += new System.EventHandler(this.txbOdpQtde_Enter);
            this.txbOdpQtde.Leave += new System.EventHandler(this.txbOdpQtde_Leave);
            // 
            // cbxApOdpUnidMed
            // 
            this.cbxApOdpUnidMed.Enabled = false;
            this.cbxApOdpUnidMed.FormattingEnabled = true;
            this.cbxApOdpUnidMed.Location = new System.Drawing.Point(194, 79);
            this.cbxApOdpUnidMed.Name = "cbxApOdpUnidMed";
            this.cbxApOdpUnidMed.Size = new System.Drawing.Size(59, 21);
            this.cbxApOdpUnidMed.TabIndex = 12;
            // 
            // lblOdpQtde
            // 
            this.lblOdpQtde.AutoSize = true;
            this.lblOdpQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpQtde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpQtde.Location = new System.Drawing.Point(100, 63);
            this.lblOdpQtde.Name = "lblOdpQtde";
            this.lblOdpQtde.Size = new System.Drawing.Size(45, 13);
            this.lblOdpQtde.TabIndex = 9;
            this.lblOdpQtde.Text = "Quant.";
            // 
            // lblApOdpProCod
            // 
            this.lblApOdpProCod.AutoSize = true;
            this.lblApOdpProCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApOdpProCod.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblApOdpProCod.Location = new System.Drawing.Point(134, 16);
            this.lblApOdpProCod.Name = "lblApOdpProCod";
            this.lblApOdpProCod.Size = new System.Drawing.Size(51, 13);
            this.lblApOdpProCod.TabIndex = 4;
            this.lblApOdpProCod.Text = "Produto";
            // 
            // lblOdpUnidMed
            // 
            this.lblOdpUnidMed.AutoSize = true;
            this.lblOdpUnidMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdpUnidMed.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOdpUnidMed.Location = new System.Drawing.Point(191, 63);
            this.lblOdpUnidMed.Name = "lblOdpUnidMed";
            this.lblOdpUnidMed.Size = new System.Drawing.Size(34, 13);
            this.lblOdpUnidMed.TabIndex = 11;
            this.lblOdpUnidMed.Text = "U.M.";
            // 
            // lblApOdpDescProduto
            // 
            this.lblApOdpDescProduto.AutoSize = true;
            this.lblApOdpDescProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblApOdpDescProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApOdpDescProduto.Location = new System.Drawing.Point(228, 32);
            this.lblApOdpDescProduto.Name = "lblApOdpDescProduto";
            this.lblApOdpDescProduto.Size = new System.Drawing.Size(237, 16);
            this.lblApOdpDescProduto.TabIndex = 6;
            this.lblApOdpDescProduto.Text = "Informe o código do produto acabado.";
            // 
            // txbApOdpCod
            // 
            this.txbApOdpCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApOdpCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbApOdpCod.Enabled = false;
            this.txbApOdpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApOdpCod.Location = new System.Drawing.Point(9, 32);
            this.txbApOdpCod.Name = "txbApOdpCod";
            this.txbApOdpCod.Size = new System.Drawing.Size(85, 20);
            this.txbApOdpCod.TabIndex = 1;
            this.txbApOdpCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.SlateGray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnSalvar);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 0);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(774, 68);
            this.pnlBotao.TabIndex = 4;
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
            this.btnSair.Location = new System.Drawing.Point(699, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 68);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Image = global::GUI.Properties.Resources.salvarflat40x40;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 68);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblApOdpItemPedido
            // 
            this.lblApOdpItemPedido.AutoSize = true;
            this.lblApOdpItemPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApOdpItemPedido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblApOdpItemPedido.Location = new System.Drawing.Point(100, 16);
            this.lblApOdpItemPedido.Name = "lblApOdpItemPedido";
            this.lblApOdpItemPedido.Size = new System.Drawing.Size(31, 13);
            this.lblApOdpItemPedido.TabIndex = 2;
            this.lblApOdpItemPedido.Text = "Item";
            // 
            // txbApOdpItem
            // 
            this.txbApOdpItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApOdpItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbApOdpItem.Enabled = false;
            this.txbApOdpItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApOdpItem.Location = new System.Drawing.Point(103, 32);
            this.txbApOdpItem.Name = "txbApOdpItem";
            this.txbApOdpItem.Size = new System.Drawing.Size(28, 20);
            this.txbApOdpItem.TabIndex = 3;
            this.txbApOdpItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmApontamentoProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(774, 251);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.pnlDados);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmApontamentoProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Apontamento Produção";
            this.Load += new System.EventHandler(this.frmApontamentoProducao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmApontamentoProducao_KeyDown);
            this.pnlDados.ResumeLayout(false);
            this.gbxIopPa.ResumeLayout(false);
            this.gbxIopPa.PerformLayout();
            this.pnlBotao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.GroupBox gbxIopPa;
        private System.Windows.Forms.TextBox txbApOdpDeposito;
        private System.Windows.Forms.Label lblApOdpDeposito;
        private System.Windows.Forms.Label lblApOdpCod;
        private System.Windows.Forms.TextBox txbApOdpProCod;
        private System.Windows.Forms.TextBox txbOdpQtde;
        private System.Windows.Forms.ComboBox cbxApOdpUnidMed;
        private System.Windows.Forms.Label lblOdpQtde;
        private System.Windows.Forms.Label lblApOdpProCod;
        private System.Windows.Forms.Label lblOdpUnidMed;
        private System.Windows.Forms.Label lblApOdpDescProduto;
        private System.Windows.Forms.TextBox txbApOdpCod;
        protected System.Windows.Forms.Panel pnlBotao;
        private System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblApOdpItemPedido;
        private System.Windows.Forms.TextBox txbApOdpItem;
    }
}