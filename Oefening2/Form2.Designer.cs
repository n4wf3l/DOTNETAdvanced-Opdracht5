namespace Oefening2
{
    partial class Form2
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
            this.lbGetal = new System.Windows.Forms.ListBox();
            this.btNieuwGetal = new System.Windows.Forms.Button();
            this.tbGemiddelde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGetal
            // 
            this.lbGetal.FormattingEnabled = true;
            this.lbGetal.ItemHeight = 15;
            this.lbGetal.Location = new System.Drawing.Point(34, 137);
            this.lbGetal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbGetal.Name = "lbGetal";
            this.lbGetal.Size = new System.Drawing.Size(334, 109);
            this.lbGetal.TabIndex = 0;
            this.lbGetal.SelectedIndexChanged += new System.EventHandler(this.lbGetallen_SelectedIndexChanged);
            // 
            // btNieuwGetal
            // 
            this.btNieuwGetal.Location = new System.Drawing.Point(147, 276);
            this.btNieuwGetal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btNieuwGetal.Name = "btNieuwGetal";
            this.btNieuwGetal.Size = new System.Drawing.Size(112, 42);
            this.btNieuwGetal.TabIndex = 1;
            this.btNieuwGetal.Text = "Nieuw getal";
            this.btNieuwGetal.UseVisualStyleBackColor = true;
            this.btNieuwGetal.Click += new System.EventHandler(this.btNieuwGetal_Click);
            // 
            // tbGemiddelde
            // 
            this.tbGemiddelde.Enabled = false;
            this.tbGemiddelde.Location = new System.Drawing.Point(147, 43);
            this.tbGemiddelde.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbGemiddelde.Name = "tbGemiddelde";
            this.tbGemiddelde.Size = new System.Drawing.Size(112, 23);
            this.tbGemiddelde.TabIndex = 2;
            this.tbGemiddelde.TextChanged += new System.EventHandler(this.tbGemiddelde_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toegevoegde getallen : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gemiddelde";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(403, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGemiddelde);
            this.Controls.Add(this.btNieuwGetal);
            this.Controls.Add(this.lbGetal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form2";
            this.Text = "GemiddeldeMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGetal;
        private System.Windows.Forms.Button btNieuwGetal;
        private System.Windows.Forms.TextBox tbGemiddelde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}