namespace GUI
{
    partial class frmBackupBandoDados
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
            this.btnRestauraBancoDados = new System.Windows.Forms.Button();
            this.btnBackupBandoDados = new System.Windows.Forms.Button();
            this.pnlBotao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotao
            // 
            this.pnlBotao.BackColor = System.Drawing.Color.SlateGray;
            this.pnlBotao.Controls.Add(this.btnSair);
            this.pnlBotao.Controls.Add(this.btnRestauraBancoDados);
            this.pnlBotao.Controls.Add(this.btnBackupBandoDados);
            this.pnlBotao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotao.Location = new System.Drawing.Point(0, 0);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(431, 68);
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
            this.btnSair.Location = new System.Drawing.Point(356, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 68);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRestauraBancoDados
            // 
            this.btnRestauraBancoDados.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRestauraBancoDados.FlatAppearance.BorderSize = 0;
            this.btnRestauraBancoDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRestauraBancoDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestauraBancoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestauraBancoDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestauraBancoDados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRestauraBancoDados.Location = new System.Drawing.Point(100, 0);
            this.btnRestauraBancoDados.Name = "btnRestauraBancoDados";
            this.btnRestauraBancoDados.Size = new System.Drawing.Size(100, 68);
            this.btnRestauraBancoDados.TabIndex = 1;
            this.btnRestauraBancoDados.Text = "Restaurar Banco de Dados";
            this.btnRestauraBancoDados.UseVisualStyleBackColor = true;
            this.btnRestauraBancoDados.Click += new System.EventHandler(this.btnRestauraBancoDados_Click);
            // 
            // btnBackupBandoDados
            // 
            this.btnBackupBandoDados.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackupBandoDados.FlatAppearance.BorderSize = 0;
            this.btnBackupBandoDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBackupBandoDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupBandoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupBandoDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackupBandoDados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackupBandoDados.Location = new System.Drawing.Point(0, 0);
            this.btnBackupBandoDados.Name = "btnBackupBandoDados";
            this.btnBackupBandoDados.Size = new System.Drawing.Size(100, 68);
            this.btnBackupBandoDados.TabIndex = 0;
            this.btnBackupBandoDados.Text = "Backup Bando de Dados";
            this.btnBackupBandoDados.UseVisualStyleBackColor = true;
            this.btnBackupBandoDados.Click += new System.EventHandler(this.btnBackupBandoDados_Click);
            // 
            // frmBackupBandoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 174);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBotao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBackupBandoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBackupBandoDados";
            this.pnlBotao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlBotao;
        private System.Windows.Forms.Button btnSair;
        protected System.Windows.Forms.Button btnRestauraBancoDados;
        protected System.Windows.Forms.Button btnBackupBandoDados;
    }
}