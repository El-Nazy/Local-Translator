namespace LocalTranslator
{
    partial class LocalTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalTranslator));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.outputText = new System.Windows.Forms.TextBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.networkNotifier = new System.Windows.Forms.Label();
            this.igboSelected = new System.Windows.Forms.PictureBox();
            this.yorubaUnselected = new System.Windows.Forms.PictureBox();
            this.hausaUnselected = new System.Windows.Forms.PictureBox();
            this.igboUnselected = new System.Windows.Forms.PictureBox();
            this.yorubaSelected = new System.Windows.Forms.PictureBox();
            this.hausaSelected = new System.Windows.Forms.PictureBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igboSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yorubaUnselected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hausaUnselected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igboUnselected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yorubaSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hausaSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.White;
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(399, 43);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(237, 127);
            this.outputText.TabIndex = 2;
            this.outputText.Tag = "ha";
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.White;
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.HideSelection = false;
            this.inputText.Location = new System.Drawing.Point(9, 42);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(237, 127);
            this.inputText.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.inputText);
            this.panel.Controls.Add(this.progressBar);
            this.panel.Controls.Add(this.networkNotifier);
            this.panel.Controls.Add(this.outputText);
            this.panel.Location = new System.Drawing.Point(19, 62);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(647, 234);
            this.panel.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(203, 214);
            this.progressBar.MarqueeAnimationSpeed = 40;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(241, 16);
            this.progressBar.Step = 0;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 0;
            this.progressBar.Visible = false;
            // 
            // networkNotifier
            // 
            this.networkNotifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.networkNotifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkNotifier.ForeColor = System.Drawing.Color.White;
            this.networkNotifier.Location = new System.Drawing.Point(10, 188);
            this.networkNotifier.Name = "networkNotifier";
            this.networkNotifier.Size = new System.Drawing.Size(627, 23);
            this.networkNotifier.TabIndex = 7;
            this.networkNotifier.Text = "Not connected to any network";
            this.networkNotifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // igboSelected
            // 
            this.igboSelected.BackColor = System.Drawing.Color.Transparent;
            this.igboSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("igboSelected.BackgroundImage")));
            this.igboSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.igboSelected.Location = new System.Drawing.Point(410, 68);
            this.igboSelected.Name = "igboSelected";
            this.igboSelected.Size = new System.Drawing.Size(87, 27);
            this.igboSelected.TabIndex = 9;
            this.igboSelected.TabStop = false;
            // 
            // yorubaUnselected
            // 
            this.yorubaUnselected.BackColor = System.Drawing.Color.Transparent;
            this.yorubaUnselected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yorubaUnselected.BackgroundImage")));
            this.yorubaUnselected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yorubaUnselected.Location = new System.Drawing.Point(576, 68);
            this.yorubaUnselected.Name = "yorubaUnselected";
            this.yorubaUnselected.Size = new System.Drawing.Size(87, 27);
            this.yorubaUnselected.TabIndex = 10;
            this.yorubaUnselected.TabStop = false;
            this.yorubaUnselected.Click += new System.EventHandler(this.yorubaUnselected_Click);
            // 
            // hausaUnselected
            // 
            this.hausaUnselected.BackColor = System.Drawing.Color.Transparent;
            this.hausaUnselected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hausaUnselected.BackgroundImage")));
            this.hausaUnselected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hausaUnselected.Location = new System.Drawing.Point(490, 68);
            this.hausaUnselected.Name = "hausaUnselected";
            this.hausaUnselected.Size = new System.Drawing.Size(87, 27);
            this.hausaUnselected.TabIndex = 11;
            this.hausaUnselected.TabStop = false;
            this.hausaUnselected.Click += new System.EventHandler(this.hausaUnselected_Click);
            // 
            // igboUnselected
            // 
            this.igboUnselected.BackColor = System.Drawing.Color.Transparent;
            this.igboUnselected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("igboUnselected.BackgroundImage")));
            this.igboUnselected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.igboUnselected.Location = new System.Drawing.Point(410, 68);
            this.igboUnselected.Name = "igboUnselected";
            this.igboUnselected.Size = new System.Drawing.Size(87, 27);
            this.igboUnselected.TabIndex = 9;
            this.igboUnselected.TabStop = false;
            this.igboUnselected.Click += new System.EventHandler(this.igboUnselected_Click);
            // 
            // yorubaSelected
            // 
            this.yorubaSelected.BackColor = System.Drawing.Color.Transparent;
            this.yorubaSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yorubaSelected.BackgroundImage")));
            this.yorubaSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yorubaSelected.Location = new System.Drawing.Point(576, 68);
            this.yorubaSelected.Name = "yorubaSelected";
            this.yorubaSelected.Size = new System.Drawing.Size(87, 27);
            this.yorubaSelected.TabIndex = 10;
            this.yorubaSelected.TabStop = false;
            // 
            // hausaSelected
            // 
            this.hausaSelected.BackColor = System.Drawing.Color.Transparent;
            this.hausaSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hausaSelected.BackgroundImage")));
            this.hausaSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hausaSelected.Location = new System.Drawing.Point(490, 68);
            this.hausaSelected.Name = "hausaSelected";
            this.hausaSelected.Size = new System.Drawing.Size(87, 27);
            this.hausaSelected.TabIndex = 11;
            this.hausaSelected.TabStop = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // LocalTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.hausaUnselected);
            this.Controls.Add(this.hausaSelected);
            this.Controls.Add(this.igboUnselected);
            this.Controls.Add(this.yorubaUnselected);
            this.Controls.Add(this.yorubaSelected);
            this.Controls.Add(this.igboSelected);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "LocalTranslator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalTranslator";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igboSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yorubaUnselected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hausaUnselected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igboUnselected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yorubaSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hausaSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox igboSelected;
        private System.Windows.Forms.PictureBox yorubaUnselected;
        private System.Windows.Forms.PictureBox hausaUnselected;
        private System.Windows.Forms.PictureBox igboUnselected;
        private System.Windows.Forms.PictureBox yorubaSelected;
        private System.Windows.Forms.PictureBox hausaSelected;
        private System.Windows.Forms.Label networkNotifier;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}