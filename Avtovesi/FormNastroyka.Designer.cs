namespace Avtovesi
{
    partial class FormNastroyka
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NastroyliIpAddress = new System.Windows.Forms.TextBox();
            this.textBox_NastroykiLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NastroykiPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_ConfigFileStorage = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP адресс камеры";
            // 
            // textBox_NastroyliIpAddress
            // 
            this.textBox_NastroyliIpAddress.Location = new System.Drawing.Point(194, 23);
            this.textBox_NastroyliIpAddress.Name = "textBox_NastroyliIpAddress";
            this.textBox_NastroyliIpAddress.Size = new System.Drawing.Size(280, 22);
            this.textBox_NastroyliIpAddress.TabIndex = 1;
            // 
            // textBox_NastroykiLogin
            // 
            this.textBox_NastroykiLogin.Location = new System.Drawing.Point(194, 65);
            this.textBox_NastroykiLogin.Name = "textBox_NastroykiLogin";
            this.textBox_NastroykiLogin.Size = new System.Drawing.Size(280, 22);
            this.textBox_NastroykiLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // textBox_NastroykiPassword
            // 
            this.textBox_NastroykiPassword.Location = new System.Drawing.Point(194, 111);
            this.textBox_NastroykiPassword.Name = "textBox_NastroykiPassword";
            this.textBox_NastroykiPassword.Size = new System.Drawing.Size(280, 22);
            this.textBox_NastroykiPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пароль";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(194, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(194, 197);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // Button_ConfigFileStorage
            // 
            this.Button_ConfigFileStorage.Location = new System.Drawing.Point(562, 462);
            this.Button_ConfigFileStorage.Name = "Button_ConfigFileStorage";
            this.Button_ConfigFileStorage.Size = new System.Drawing.Size(126, 32);
            this.Button_ConfigFileStorage.TabIndex = 12;
            this.Button_ConfigFileStorage.Text = "Сохранить";
            this.Button_ConfigFileStorage.UseVisualStyleBackColor = true;
            this.Button_ConfigFileStorage.Click += new System.EventHandler(this.Button_ConfigFileStorage_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(493, 23);
            this.maskedTextBox1.Mask = "000.000.000.000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(186, 22);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // FormNastroyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 518);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Button_ConfigFileStorage);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NastroykiPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_NastroykiLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NastroyliIpAddress);
            this.Controls.Add(this.label1);
            this.Name = "FormNastroyka";
            this.Text = "Настройка камеры и весов";
            this.Load += new System.EventHandler(this.FormNastroyka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NastroyliIpAddress;
        private System.Windows.Forms.TextBox textBox_NastroykiLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NastroykiPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_ConfigFileStorage;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}