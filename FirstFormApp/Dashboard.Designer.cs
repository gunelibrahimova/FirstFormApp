namespace FirstFormApp
{
    partial class Dashboard
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
            this.Txtchecked = new System.Windows.Forms.CheckedListBox();
            this.Txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtprice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcategoryname = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.Btnuploadphoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txtquantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtsku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtdatetime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtexpression = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Btnaddtolist = new System.Windows.Forms.Button();
            this.Btnaddtobase = new System.Windows.Forms.Button();
            this.Dgvproduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Txtprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtchecked
            // 
            this.Txtchecked.FormattingEnabled = true;
            this.Txtchecked.Location = new System.Drawing.Point(860, 19);
            this.Txtchecked.Name = "Txtchecked";
            this.Txtchecked.Size = new System.Drawing.Size(381, 290);
            this.Txtchecked.TabIndex = 0;
            // 
            // Txtname
            // 
            this.Txtname.Location = new System.Drawing.Point(12, 53);
            this.Txtname.Name = "Txtname";
            this.Txtname.Size = new System.Drawing.Size(234, 27);
            this.Txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product name";
            // 
            // Txtprice
            // 
            this.Txtprice.DecimalPlaces = 2;
            this.Txtprice.Location = new System.Drawing.Point(12, 127);
            this.Txtprice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Txtprice.Name = "Txtprice";
            this.Txtprice.Size = new System.Drawing.Size(234, 27);
            this.Txtprice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // Txtcategoryname
            // 
            this.Txtcategoryname.FormattingEnabled = true;
            this.Txtcategoryname.Location = new System.Drawing.Point(12, 215);
            this.Txtcategoryname.Name = "Txtcategoryname";
            this.Txtcategoryname.Size = new System.Drawing.Size(234, 28);
            this.Txtcategoryname.TabIndex = 5;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category.Location = new System.Drawing.Point(12, 174);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(92, 28);
            this.Category.TabIndex = 6;
            this.Category.Text = "Category";
            // 
            // Btnuploadphoto
            // 
            this.Btnuploadphoto.Location = new System.Drawing.Point(627, 184);
            this.Btnuploadphoto.Name = "Btnuploadphoto";
            this.Btnuploadphoto.Size = new System.Drawing.Size(159, 43);
            this.Btnuploadphoto.TabIndex = 7;
            this.Btnuploadphoto.Text = "Upload Photo";
            this.Btnuploadphoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(627, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 114);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Txtquantity
            // 
            this.Txtquantity.DecimalPlaces = 2;
            this.Txtquantity.Location = new System.Drawing.Point(339, 127);
            this.Txtquantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Txtquantity.Name = "Txtquantity";
            this.Txtquantity.Size = new System.Drawing.Size(234, 27);
            this.Txtquantity.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(339, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            // 
            // Txtsku
            // 
            this.Txtsku.Location = new System.Drawing.Point(339, 53);
            this.Txtsku.Name = "Txtsku";
            this.Txtsku.Size = new System.Drawing.Size(234, 27);
            this.Txtsku.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(339, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "SKU";
            // 
            // Txtdatetime
            // 
            this.Txtdatetime.Location = new System.Drawing.Point(339, 216);
            this.Txtdatetime.Name = "Txtdatetime";
            this.Txtdatetime.Size = new System.Drawing.Size(250, 27);
            this.Txtdatetime.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(339, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date of production";
            // 
            // Txtexpression
            // 
            this.Txtexpression.Location = new System.Drawing.Point(339, 297);
            this.Txtexpression.Name = "Txtexpression";
            this.Txtexpression.Size = new System.Drawing.Size(250, 27);
            this.Txtexpression.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(339, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Expression date";
            // 
            // Btnaddtolist
            // 
            this.Btnaddtolist.Location = new System.Drawing.Point(12, 281);
            this.Btnaddtolist.Name = "Btnaddtolist";
            this.Btnaddtolist.Size = new System.Drawing.Size(159, 43);
            this.Btnaddtolist.TabIndex = 17;
            this.Btnaddtolist.Text = "Add to list";
            this.Btnaddtolist.UseVisualStyleBackColor = true;
            this.Btnaddtolist.Click += new System.EventHandler(this.Btnaddtolist_Click);
            // 
            // Btnaddtobase
            // 
            this.Btnaddtobase.Location = new System.Drawing.Point(695, 266);
            this.Btnaddtobase.Name = "Btnaddtobase";
            this.Btnaddtobase.Size = new System.Drawing.Size(159, 43);
            this.Btnaddtobase.TabIndex = 18;
            this.Btnaddtobase.Text = "Add to base";
            this.Btnaddtobase.UseVisualStyleBackColor = true;
            this.Btnaddtobase.Click += new System.EventHandler(this.Btnaddtobase_Click);
            // 
            // Dgvproduct
            // 
            this.Dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvproduct.Location = new System.Drawing.Point(12, 402);
            this.Dgvproduct.Name = "Dgvproduct";
            this.Dgvproduct.RowHeadersWidth = 51;
            this.Dgvproduct.RowTemplate.Height = 29;
            this.Dgvproduct.Size = new System.Drawing.Size(1229, 188);
            this.Dgvproduct.TabIndex = 19;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 602);
            this.Controls.Add(this.Dgvproduct);
            this.Controls.Add(this.Btnaddtobase);
            this.Controls.Add(this.Btnaddtolist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtexpression);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtdatetime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtsku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtquantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btnuploadphoto);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Txtcategoryname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.Txtchecked);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txtprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox Txtchecked;
        private TextBox Txtname;
        private Label label1;
        private NumericUpDown Txtprice;
        private Label label2;
        private ComboBox Txtcategoryname;
        private Label Category;
        private Button Btnuploadphoto;
        private PictureBox pictureBox1;
        private NumericUpDown Txtquantity;
        private Label label3;
        private TextBox Txtsku;
        private Label label4;
        private DateTimePicker Txtdatetime;
        private Label label5;
        private DateTimePicker Txtexpression;
        private Label label6;
        private Button Btnaddtolist;
        private Button Btnaddtobase;
        private DataGridView Dgvproduct;
    }
}