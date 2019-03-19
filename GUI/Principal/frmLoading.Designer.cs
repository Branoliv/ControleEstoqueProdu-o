namespace GUI
{
    partial class frmLoading
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
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.cpgbLoading = new CircularProgressBar.CircularProgressBar();
            this.pnlLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.SlateGray;
            this.pnlLoading.Controls.Add(this.LblTituloPrincipal);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoading.Location = new System.Drawing.Point(0, 106);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(298, 22);
            this.pnlLoading.TabIndex = 0;
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
            // cpgbLoading
            // 
            this.cpgbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpgbLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpgbLoading.AnimationSpeed = 500;
            this.cpgbLoading.BackColor = System.Drawing.Color.Transparent;
            this.cpgbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpgbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpgbLoading.InnerColor = System.Drawing.Color.Transparent;
            this.cpgbLoading.InnerMargin = 2;
            this.cpgbLoading.InnerWidth = -1;
            this.cpgbLoading.Location = new System.Drawing.Point(98, 8);
            this.cpgbLoading.MarqueeAnimationSpeed = 1000;
            this.cpgbLoading.Name = "cpgbLoading";
            this.cpgbLoading.OuterColor = System.Drawing.Color.Gray;
            this.cpgbLoading.OuterMargin = -16;
            this.cpgbLoading.OuterWidth = 17;
            this.cpgbLoading.ProgressColor = System.Drawing.Color.MediumAquamarine;
            this.cpgbLoading.ProgressWidth = 10;
            this.cpgbLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpgbLoading.Size = new System.Drawing.Size(98, 95);
            this.cpgbLoading.StartAngle = 270;
            this.cpgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpgbLoading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpgbLoading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpgbLoading.SubscriptText = ".23";
            this.cpgbLoading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpgbLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpgbLoading.SuperscriptText = "°C";
            this.cpgbLoading.TabIndex = 1;
            this.cpgbLoading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpgbLoading.Value = 30;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(298, 128);
            this.ControlBox = false;
            this.Controls.Add(this.cpgbLoading);
            this.Controls.Add(this.pnlLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoading;
        public System.Windows.Forms.Label LblTituloPrincipal;
        public CircularProgressBar.CircularProgressBar cpgbLoading;
    }
}