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
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroudColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            this.bewerkenToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.bewerkenToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorRed,
            this.ColorGreen,
            this.ColorBlue});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // ColorRed
            // 
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(180, 22);
            this.ColorRed.Text = "Red";
            this.ColorRed.Click += new System.EventHandler(this.ColorRed_Click);
            // 
            // ColorGreen
            // 
            this.ColorGreen.Name = "ColorGreen";
            this.ColorGreen.Size = new System.Drawing.Size(180, 22);
            this.ColorGreen.Text = "Green";
            this.ColorGreen.Click += new System.EventHandler(this.ColorGreen_Click);
            // 
            // ColorBlue
            // 
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(180, 22);
            this.ColorBlue.Text = "Blue";
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
            this.BackgroudColorRed.Size = new System.Drawing.Size(105, 22);
            this.BackgroudColorRed.Text = "Red";
            this.BackgroudColorRed.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
            // 
            // BackgroundColorGreen
            // 
            this.BackgroundColorGreen.Name = "BackgroundColorGreen";
            this.BackgroundColorGreen.Size = new System.Drawing.Size(105, 22);
            this.BackgroundColorGreen.Text = "Green";
            this.BackgroundColorGreen.Click += new System.EventHandler(this.BackgroundColorGreen_Click);
            // 
            // BackgroundColorBlue
            // 
            this.BackgroundColorBlue.Name = "BackgroundColorBlue";
            this.BackgroundColorBlue.Size = new System.Drawing.Size(105, 22);
            this.BackgroundColorBlue.Text = "Blue";
            this.BackgroundColorBlue.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallCtrlSToolStripMenuItem,
            this.normalCtrlNToolStripMenuItem,
            this.largeCtrlLToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // smallCtrlSToolStripMenuItem
            // 
            this.smallCtrlSToolStripMenuItem.Name = "smallCtrlSToolStripMenuItem";
            this.smallCtrlSToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.smallCtrlSToolStripMenuItem.Text = "Small";
            this.smallCtrlSToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // normalCtrlNToolStripMenuItem
            // 
            this.normalCtrlNToolStripMenuItem.Name = "normalCtrlNToolStripMenuItem";
            this.normalCtrlNToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalCtrlNToolStripMenuItem.Text = "Normal";
            this.normalCtrlNToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // largeCtrlLToolStripMenuItem
            // 
            this.largeCtrlLToolStripMenuItem.Name = "largeCtrlLToolStripMenuItem";
            this.largeCtrlLToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.largeCtrlLToolStripMenuItem.Text = "Large";
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
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem ColorRed;
        private ToolStripMenuItem ColorGreen;
        private ToolStripMenuItem ColorBlue;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem BackgroudColorRed;
        private ToolStripMenuItem BackgroundColorGreen;
        private ToolStripMenuItem BackgroundColorBlue;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem smallCtrlSToolStripMenuItem;
        private ToolStripMenuItem normalCtrlNToolStripMenuItem;
        private ToolStripMenuItem largeCtrlLToolStripMenuItem;
    }
}