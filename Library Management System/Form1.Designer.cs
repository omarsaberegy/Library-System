namespace Library_Management_System
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Exittxt = new System.Windows.Forms.Button();
            this.Passwordtxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNametxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Signuptxt = new System.Windows.Forms.Button();
            this.SignIntxt = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.forgetmailtext = new System.Windows.Forms.TextBox();
            this.forgetmaillabel = new System.Windows.Forms.Label();
            this.Typetogetmail = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(67, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(592, 162);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "               \" LIBRARY \"\r\n           * MANAGEMENT * \r\n                  SYSTEM";
            // 
            // Exittxt
            // 
            this.Exittxt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exittxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exittxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exittxt.Location = new System.Drawing.Point(343, 424);
            this.Exittxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exittxt.Name = "Exittxt";
            this.Exittxt.Size = new System.Drawing.Size(76, 27);
            this.Exittxt.TabIndex = 25;
            this.Exittxt.Text = "Exit";
            this.Exittxt.UseVisualStyleBackColor = true;
            this.Exittxt.Click += new System.EventHandler(this.Exittxt_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(354, 217);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(120, 22);
            this.Passwordtxt.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(202, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password  :";
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(354, 181);
            this.UserNametxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(120, 20);
            this.UserNametxt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(264, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Forgot Password ?!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(202, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(235, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type  :";
            // 
            // Signuptxt
            // 
            this.Signuptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signuptxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Signuptxt.Location = new System.Drawing.Point(429, 315);
            this.Signuptxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Signuptxt.Name = "Signuptxt";
            this.Signuptxt.Size = new System.Drawing.Size(92, 29);
            this.Signuptxt.TabIndex = 16;
            this.Signuptxt.Text = "Sign Up";
            this.Signuptxt.UseVisualStyleBackColor = true;
            this.Signuptxt.Click += new System.EventHandler(this.Signuptxt_Click);
            // 
            // SignIntxt
            // 
            this.SignIntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIntxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignIntxt.Location = new System.Drawing.Point(239, 315);
            this.SignIntxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SignIntxt.Name = "SignIntxt";
            this.SignIntxt.Size = new System.Drawing.Size(88, 29);
            this.SignIntxt.TabIndex = 15;
            this.SignIntxt.Text = "Sign In";
            this.SignIntxt.UseVisualStyleBackColor = true;
            this.SignIntxt.Click += new System.EventHandler(this.SignIntxt_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(373, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(309, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Serial";
            this.label8.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton1.Location = new System.Drawing.Point(373, 245);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Librarian";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(373, 268);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Reader";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(405, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clich here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // forgetmailtext
            // 
            this.forgetmailtext.Location = new System.Drawing.Point(177, 381);
            this.forgetmailtext.Name = "forgetmailtext";
            this.forgetmailtext.Size = new System.Drawing.Size(143, 20);
            this.forgetmailtext.TabIndex = 31;
            this.forgetmailtext.Visible = false;
            // 
            // forgetmaillabel
            // 
            this.forgetmaillabel.AutoSize = true;
            this.forgetmaillabel.Location = new System.Drawing.Point(76, 388);
            this.forgetmaillabel.Name = "forgetmaillabel";
            this.forgetmaillabel.Size = new System.Drawing.Size(82, 13);
            this.forgetmaillabel.TabIndex = 32;
            this.forgetmaillabel.Text = "Enter your mail :";
            this.forgetmaillabel.Visible = false;
            // 
            // Typetogetmail
            // 
            this.Typetogetmail.AutoSize = true;
            this.Typetogetmail.Location = new System.Drawing.Point(370, 388);
            this.Typetogetmail.Name = "Typetogetmail";
            this.Typetogetmail.Size = new System.Drawing.Size(89, 13);
            this.Typetogetmail.TabIndex = 33;
            this.Typetogetmail.Text = "Select your type :";
            this.Typetogetmail.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(495, 403);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Reader";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton4.Location = new System.Drawing.Point(495, 380);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 17);
            this.radioButton4.TabIndex = 34;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Librarian";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(567, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Get my data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(732, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.Typetogetmail);
            this.Controls.Add(this.forgetmaillabel);
            this.Controls.Add(this.forgetmailtext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Exittxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Signuptxt);
            this.Controls.Add(this.SignIntxt);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Exittxt;
        private System.Windows.Forms.MaskedTextBox Passwordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox UserNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Signuptxt;
        private System.Windows.Forms.Button SignIntxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox forgetmailtext;
        private System.Windows.Forms.Label forgetmaillabel;
        private System.Windows.Forms.Label Typetogetmail;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button2;
    }
}

