namespace Oefening1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Color = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroudColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.FontNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.FontLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(0, 27);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(258, 142);
            this.tbText.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bewerkenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(259, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // bewerkenToolStripMenuItem
            // 
            this.bewerkenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Color,
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            this.bewerkenToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.bewerkenToolStripMenuItem.Text = "Format";
            // 
            // Color
            // 
            this.Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorRed,
            this.ColorGreen,
            this.ColorBlue});
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(180, 22);
            this.Color.Text = "Color";
            // 
            // ColorRed
            // 
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(180, 22);
            this.ColorRed.Text = "Red Ctrl+R";
            this.ColorRed.Click += new System.EventHandler(this.ColorRed_Click);
            // 
            // ColorGreen
            // 
            this.ColorGreen.Name = "ColorGreen";
            this.ColorGreen.Size = new System.Drawing.Size(180, 22);
            this.ColorGreen.Text = "Green Ctrl+G";
            this.ColorGreen.Click += new System.EventHandler(this.ColorGreen_Click);
            // 
            // ColorBlue
            // 
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(180, 22);
            this.ColorBlue.Text = "Blue Ctrl+B";
            this.ColorBlue.Click += new System.EventHandler(this.ColorBlue_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackgroudColorRed,
            this.BackgroundColorGreen,
            this.BackgroundColorBlue});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // BackgroudColorRed
            // 
            this.BackgroudColorRed.Name = "BackgroudColorRed";
            this.BackgroudColorRed.Size = new System.Drawing.Size(180, 22);
            this.BackgroudColorRed.Text = "Red";
            this.BackgroudColorRed.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
            // 
            // BackgroundColorGreen
            // 
            this.BackgroundColorGreen.Name = "BackgroundColorGreen";
            this.BackgroundColorGreen.Size = new System.Drawing.Size(180, 22);
            this.BackgroundColorGreen.Text = "Green";
            this.BackgroundColorGreen.Click += new System.EventHandler(this.BackgroundColorGreen_Click);
            // 
            // BackgroundColorBlue
            // 
            this.BackgroundColorBlue.Name = "BackgroundColorBlue";
            this.BackgroundColorBlue.Size = new System.Drawing.Size(180, 22);
            this.BackgroundColorBlue.Text = "Blue";
            this.BackgroundColorBlue.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSmall,
            this.FontNormal,
            this.FontLarge});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // FontSmall
            // 
            this.FontSmall.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontSmall.Name = "FontSmall";
            this.FontSmall.Size = new System.Drawing.Size(183, 30);
            this.FontSmall.Text = "Small Ctrl+S";
            this.FontSmall.Click += new System.EventHandler(this.FontSmall_Click_1);
            // 
            // FontNormal
            // 
            this.FontNormal.Name = "FontNormal";
            this.FontNormal.Size = new System.Drawing.Size(183, 30);
            this.FontNormal.Text = "Normal Ctrl+N";
            this.FontNormal.Click += new System.EventHandler(this.FontNormal_Click);
            // 
            // FontLarge
            // 
            this.FontLarge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontLarge.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FontLarge.Name = "FontLarge";
            this.FontLarge.Size = new System.Drawing.Size(183, 30);
            this.FontLarge.Text = "Large Ctrl+L";
            this.FontLarge.Click += new System.EventHandler(this.FontLarge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 176);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem;
        private ToolStripMenuItem Color;
        private ToolStripMenuItem ColorRed;
        private ToolStripMenuItem ColorGreen;
        private ToolStripMenuItem ColorBlue;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem BackgroudColorRed;
        private ToolStripMenuItem BackgroundColorGreen;
        private ToolStripMenuItem BackgroundColorBlue;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem FontSmall;
        private ToolStripMenuItem FontNormal;
        private ToolStripMenuItem FontLarge;
    }
}