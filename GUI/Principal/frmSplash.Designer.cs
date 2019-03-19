namespace GUI
{
    partial class frmSplash
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
            this.lblSplashVersao = new System.Windows.Forms.Label();
            this.lblSplashNomeSis = new System.Windows.Forms.Label();
            this.backgroundWorkerSplash = new System.ComponentModel.BackgroundWorker();
            this.cpgbLoading = new CircularProgressBar.CircularProgressBar();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.pnlLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSplashVersao
            // 
            this.lblSplashVersao.AutoSize = true;
            this.lblSplashVersao.Location = new System.Drawing.Point(12, 173);
            this.lblSplashVersao.Name = "lblSplashVersao";
            this.lblSplashVersao.Size = new System.Drawing.Size(43, 13);
            this.lblSplashVersao.TabIndex = 0;
            this.lblSplashVersao.Text = "Versão:";
            // 
            // lblSplashNomeSis
            // 
            this.lblSplashNomeSis.AutoSize = true;
            this.lblSplashNomeSis.Location = new System.Drawing.Point(12, 156);
            this.lblSplashNomeSis.Name = "lblSplashNomeSis";
            this.lblSplashNomeSis.Size = new System.Drawing.Size(47, 13);
            this.lblSplashNomeSis.TabIndex = 1;
            this.lblSplashNomeSis.Text = "Sistema:";
            // 
            // backgroundWorkerSplash
            // 
            this.backgroundWorkerSplash.WorkerSupportsCancellation = true;
            this.backgroundWorkerSplash.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSplash_DoWork);
            this.backgroundWorkerSplash.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSplash_RunWorkerCompleted);
            // 
            // cpgbLoading
            // 
            this.cpgbLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpgbLoading.AnimationSpeed = 500;
            this.cpgbLoading.BackColor = System.Drawing.Color.Transparent;
            this.cpgbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpgbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpgbLoading.InnerColor = System.Drawing.Color.Transparent;
            this.cpgbLoading.InnerMargin = 2;
            this.cpgbLoading.InnerWidth = -1;
            this.cpgbLoading.Location = new System.Drawing.Point(138, 12);
            this.cpgbLoading.MarqueeAnimationSpeed = 2000;
            this.cpgbLoading.Name = "cpgbLoading";
            this.cpgbLoading.OuterColor = System.Drawing.Color.Gray;
            this.cpgbLoading.OuterMargin = -16;
            this.cpgbLoading.OuterWidth = 17;
            this.cpgbLoading.ProgressColor = System.Drawing.Color.MediumAquamarine;
            this.cpgbLoading.ProgressWidth = 10;
            this.cpgbLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpgbLoading.Size = new System.Drawing.Size(129, 123);
            this.cpgbLoading.StartAngle = 270;
            this.cpgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpgbLoading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpgbLoading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpgbLoading.SubscriptText = ".23";
            this.cpgbLoading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpgbLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpgbLoading.SuperscriptText = "°C";
            this.cpgbLoading.TabIndex = 3;
            this.cpgbLoading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpgbLoading.Value = 40;
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.SlateGray;
            this.pnlLoading.Controls.Add(this.LblTituloPrincipal);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoading.Location = new System.Drawing.Point(0, 179);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(390, 22);
            this.pnlLoading.TabIndex = 2;
            // 
            // LblTituloPrincipal
            // 
            this.LblTituloPrincipal.AutoSize = true;
            this.LblTituloPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPrincipal.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTituloPrincipal.Location = new System.Drawing.Point(0, 0);
            this.LblTituloPrincipal.Name = "LblTituloPrincipal";
            this.LblTituloPrincipal.Size = new System.Drawing.Size(170, 25);
            this.LblTituloPrincipal.TabIndex = 2;
            this.LblTituloPrincipal.Text = "Processando...";
            this.LblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(390, 201);
            this.ControlBox = false;
            this.Controls.Add(this.cpgbLoading);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.lblSplashNomeSis);
            this.Controls.Add(this.lblSplashVersao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplashVersao;
        private System.Windows.Forms.Label lblSplashNomeSis;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSplash;
        public CircularProgressBar.CircularProgressBar cpgbLoading;
        private System.Windows.Forms.Panel pnlLoading;
        public System.Windows.Forms.Label LblTituloPrincipal;
    }
}