namespace FirstFormApp
{
    partial class Category
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(242, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Category";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(238, 83);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(271, 27);
            this.TxtName.TabIndex = 19;
            // 
            // Btnregister
            // 
            this.Btnregister.BackColor = System.Drawing.Color.IndianRed;
            this.Btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnregister.ForeColor = System.Drawing.Color.White;
            this.Btnregister.Location = new System.Drawing.Point(238, 129);
            this.Btnregister.Name = "Btnregister";
            this.Btnregister.Size = new System.Drawing.Size(131, 44);
            this.Btnregister.TabIndex = 21;
            this.Btnregister.Text = "Add";
            this.Btnregister.UseVisualStyleBackColor = false;
            this.Btnregister.Click += new System.EventHandler(this.Btnregister_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnregister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtName);
            this.Name = "Category";
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox TxtName;
        private Button Btnregister;
    }
}