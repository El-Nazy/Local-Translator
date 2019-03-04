namespace LocalTranslator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.translateProgress = new System.Windows.Forms.ProgressBar();
            this.appStatusLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.englishText = new System.Windows.Forms.TextBox();
            this.englishLabel = new System.Windows.Forms.Label();
            this.outputTabControl = new System.Windows.Forms.TabControl();
            this.yorubaTab = new System.Windows.Forms.TabPage();
            this.yorubaText = new System.Windows.Forms.TextBox();
            this.hausaTab = new System.Windows.Forms.TabPage();
            this.hausaText = new System.Windows.Forms.TextBox();
            this.igboTab = new System.Windows.Forms.TabPage();
            this.igboText = new System.Windows.Forms.TextBox();
            this.outputTabControl.SuspendLayout();
            this.yorubaTab.SuspendLayout();
            this.hausaTab.SuspendLayout();
            this.igboTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // translateProgress
            // 
            this.translateProgress.Location = new System.Drawing.Point(171, 322);
            this.translateProgress.MarqueeAnimationSpeed = 10;
            this.translateProgress.Name = "translateProgress";
            this.translateProgress.Size = new System.Drawing.Size(340, 18);
            this.translateProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.translateProgress.TabIndex = 9;
            this.translateProgress.Visible = false;
            // 
            // appStatusLabel
            // 
            this.appStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.appStatusLabel.CausesValidation = false;
            this.appStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appStatusLabel.Location = new System.Drawing.Point(-3, 297);
            this.appStatusLabel.Name = "appStatusLabel";
            this.appStatusLabel.Size = new System.Drawing.Size(689, 23);
            this.appStatusLabel.TabIndex = 10;
            this.appStatusLabel.Text = "Translator State Text";
            this.appStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appStatusLabel.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // englishText
            // 
            this.englishText.BackColor = System.Drawing.SystemColors.Window;
            this.englishText.HideSelection = false;
            this.englishText.Location = new System.Drawing.Point(25, 82);
            this.englishText.Multiline = true;
            this.englishText.Name = "englishText";
            this.englishText.Size = new System.Drawing.Size(257, 157);
            this.englishText.TabIndex = 2;
            this.englishText.TextChanged += new System.EventHandler(this.englishText_Enter);
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.BackColor = System.Drawing.Color.Transparent;
            this.englishLabel.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishLabel.Location = new System.Drawing.Point(22, 60);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(47, 15);
            this.englishLabel.TabIndex = 4;
            this.englishLabel.Text = "English";
            // 
            // outputTabControl
            // 
            this.outputTabControl.Controls.Add(this.igboTab);
            this.outputTabControl.Controls.Add(this.hausaTab);
            this.outputTabControl.Controls.Add(this.yorubaTab);
            this.outputTabControl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTabControl.Location = new System.Drawing.Point(394, 60);
            this.outputTabControl.Name = "outputTabControl";
            this.outputTabControl.SelectedIndex = 0;
            this.outputTabControl.Size = new System.Drawing.Size(266, 186);
            this.outputTabControl.TabIndex = 0;
            // 
            // yorubaTab
            // 
            this.yorubaTab.BackColor = System.Drawing.Color.Transparent;
            this.yorubaTab.Controls.Add(this.yorubaText);
            this.yorubaTab.Font = new System.Drawing.Font("Calibri", 9.5F);
            this.yorubaTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yorubaTab.Location = new System.Drawing.Point(4, 23);
            this.yorubaTab.Name = "yorubaTab";
            this.yorubaTab.Size = new System.Drawing.Size(258, 159);
            this.yorubaTab.TabIndex = 2;
            this.yorubaTab.Text = "Yoruba";
            // 
            // yorubaText
            // 
            this.yorubaText.BackColor = System.Drawing.SystemColors.Window;
            this.yorubaText.Location = new System.Drawing.Point(0, 1);
            this.yorubaText.Multiline = true;
            this.yorubaText.Name = "yorubaText";
            this.yorubaText.ReadOnly = true;
            this.yorubaText.Size = new System.Drawing.Size(257, 157);
            this.yorubaText.TabIndex = 2;
            this.yorubaText.Tag = "yoruba";
            // 
            // hausaTab
            // 
            this.hausaTab.BackColor = System.Drawing.Color.Transparent;
            this.hausaTab.Controls.Add(this.hausaText);
            this.hausaTab.Font = new System.Drawing.Font("Calibri", 9.5F);
            this.hausaTab.Location = new System.Drawing.Point(4, 23);
            this.hausaTab.Name = "hausaTab";
            this.hausaTab.Padding = new System.Windows.Forms.Padding(3);
            this.hausaTab.Size = new System.Drawing.Size(258, 159);
            this.hausaTab.TabIndex = 1;
            this.hausaTab.Text = "Hausa";
            // 
            // hausaText
            // 
            this.hausaText.BackColor = System.Drawing.SystemColors.Window;
            this.hausaText.Location = new System.Drawing.Point(0, 0);
            this.hausaText.Multiline = true;
            this.hausaText.Name = "hausaText";
            this.hausaText.ReadOnly = true;
            this.hausaText.Size = new System.Drawing.Size(257, 152);
            this.hausaText.TabIndex = 2;
            this.hausaText.Tag = "hausa";
            // 
            // igboTab
            // 
            this.igboTab.BackColor = System.Drawing.Color.Transparent;
            this.igboTab.Controls.Add(this.igboText);
            this.igboTab.Font = new System.Drawing.Font("Calibri", 9.5F);
            this.igboTab.Location = new System.Drawing.Point(4, 23);
            this.igboTab.Name = "igboTab";
            this.igboTab.Padding = new System.Windows.Forms.Padding(3);
            this.igboTab.Size = new System.Drawing.Size(258, 159);
            this.igboTab.TabIndex = 0;
            this.igboTab.Text = "Igbo";
            // 
            // igboText
            // 
            this.igboText.BackColor = System.Drawing.SystemColors.Window;
            this.igboText.Location = new System.Drawing.Point(0, 1);
            this.igboText.Multiline = true;
            this.igboText.Name = "igboText";
            this.igboText.ReadOnly = true;
            this.igboText.Size = new System.Drawing.Size(257, 157);
            this.igboText.TabIndex = 2;
            this.igboText.Tag = "igbo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.outputTabControl);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.appStatusLabel);
            this.Controls.Add(this.englishText);
            this.Controls.Add(this.translateProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.outputTabControl.ResumeLayout(false);
            this.yorubaTab.ResumeLayout(false);
            this.yorubaTab.PerformLayout();
            this.hausaTab.ResumeLayout(false);
            this.hausaTab.PerformLayout();
            this.igboTab.ResumeLayout(false);
            this.igboTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar translateProgress;
        private System.Windows.Forms.Label appStatusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox englishText;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.TabControl outputTabControl;
        private System.Windows.Forms.TabPage igboTab;
        private System.Windows.Forms.TextBox igboText;
        private System.Windows.Forms.TabPage hausaTab;
        private System.Windows.Forms.TextBox hausaText;
        private System.Windows.Forms.TabPage yorubaTab;
        private System.Windows.Forms.TextBox yorubaText;
    }
}

