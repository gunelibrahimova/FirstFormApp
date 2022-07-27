namespace FirstFormApp
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.Txtemail = new System.Windows.Forms.TextBox();
            this.Btnregister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(251, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // Txtconfirmpassword
            // 
            this.Txtconfirmpassword.Location = new System.Drawing.Point(251, 327);
            this.Txtconfirmpassword.Name = "Txtconfirmpassword";
            this.Txtconfirmpassword.Size = new System.Drawing.Size(271, 27);
            this.Txtconfirmpassword.TabIndex = 8;
            this.Txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // Txtemail
            // 
            this.Txtemail.Location = new System.Drawing.Point(251, 183);
            this.Txtemail.Name = "Txtemail";
            this.Txtemail.Size = new System.Drawing.Size(271, 27);
            this.Txtemail.TabIndex = 7;
            // 
            // Btnregister
            // 
            this.Btnregister.BackColor = System.Drawing.Color.IndianRed;
            this.Btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnregister.ForeColor = System.Drawing.Color.White;
            this.Btnregister.Location = new System.Drawing.Point(255, 374);
            this.Btnregister.Name = "Btnregister";
            this.Btnregister.Size = new System.Drawing.Size(131, 44);
            this.Btnregister.TabIndex = 6;
            this.Btnregister.Text = "Register";
            this.Btnregister.UseVisualStyleBackColor = false;
            this.Btnregister.Click += new System.EventHandler(this.Btnregister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(251, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(251, 254);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(271, 27);
            this.Txtpassword.TabIndex = 12;
            this.Txtpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(255, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(251, 55);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(271, 27);
            this.TxtName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(251, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Surname";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(251, 117);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(271, 27);
            this.TxtSurname.TabIndex = 17;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtconfirmpassword);
            this.Controls.Add(this.Txtemail);
            this.Controls.Add(this.Btnregister);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox Txtconfirmpassword;
        private TextBox Txtemail;
        private Button Btnregister;
        private Label label2;
        private TextBox Txtpassword;
        private Label label4;
        private TextBox TxtName;
        private Label label5;
        private TextBox TxtSurname;
    }
}