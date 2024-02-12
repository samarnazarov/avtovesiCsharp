namespace Avtovesi
{
    partial class Webbrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.refresh_button = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.documentText_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1264, 704);
            this.webBrowser1.TabIndex = 0;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(22, 14);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(103, 23);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(131, 13);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(103, 23);
            this.print_button.TabIndex = 2;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // documentText_button
            // 
            this.documentText_button.Location = new System.Drawing.Point(240, 12);
            this.documentText_button.Name = "documentText_button";
            this.documentText_button.Size = new System.Drawing.Size(103, 23);
            this.documentText_button.TabIndex = 3;
            this.documentText_button.Text = "DocumentText";
            this.documentText_button.UseVisualStyleBackColor = true;
            this.documentText_button.Click += new System.EventHandler(this.documentText_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Webbrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documentText_button);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Webbrowser";
            this.Text = "Webbrowser";
            this.Load += new System.EventHandler(this.Webbrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button documentText_button;
        private System.Windows.Forms.Label label1;
    }
}