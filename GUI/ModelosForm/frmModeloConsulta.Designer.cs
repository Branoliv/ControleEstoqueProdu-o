namespace GUI
{
    partial class frmModeloConsulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTituloModeloConsulta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbConsNome = new System.Windows.Forms.TextBox();
            this.lblConsNome = new System.Windows.Forms.Label();
            this.pnlBotao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.Gray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnLimpar);
            this.pnlBotao.Controls.Add(this.btnLocalizar);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 34);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(756, 85);
            this.pnlBotao.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = global::GUI.Properties.Resources.sairflatEs;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(681, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 85);
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
            this.btnLimpar.Image = global::GUI.Properties.Resources.limparflat;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(75, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 85);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalizar.Image = global::GUI.Properties.Resources.localizarflat;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLocalizar.Location = new System.Drawing.Point(0, 0);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 85);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.LblTituloModeloConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 34);
            this.panel1.TabIndex = 3;
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
            this.LblTituloModeloConsulta.Size = new System.Drawing.Size(0, 29);
            this.LblTituloModeloConsulta.TabIndex = 2;
            this.LblTituloModeloConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.txbConsNome);
            this.panel2.Controls.Add(this.lblConsNome);
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 100);
            this.panel2.TabIndex = 0;
            // 
            // txbConsNome
            // 
            this.txbConsNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConsNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbConsNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsNome.Location = new System.Drawing.Point(22, 48);
            this.txbConsNome.Name = "txbConsNome";
            this.txbConsNome.Size = new System.Drawing.Size(693, 20);
            this.txbConsNome.TabIndex = 1;
            // 
            // lblConsNome
            // 
            this.lblConsNome.AutoSize = true;
            this.lblConsNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsNome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblConsNome.Location = new System.Drawing.Point(19, 32);
            this.lblConsNome.Name = "lblConsNome";
            this.lblConsNome.Size = new System.Drawing.Size(56, 13);
            this.lblConsNome.TabIndex = 0;
            this.lblConsNome.Text = "Consulta";
            // 
            // frmModeloConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(756, 633);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmModeloConsulta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modelo Consulta";
            this.Load += new System.EventHandler(this.frmModeloConsulta_Load);
            this.pnlBotao.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel pnlBotao;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.TextBox txbConsNome;
        protected System.Windows.Forms.Label lblConsNome;
        protected System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnLimpar;
        protected System.Windows.Forms.Button btnLocalizar;
        protected System.Windows.Forms.Label LblTituloModeloConsulta;
    }
}