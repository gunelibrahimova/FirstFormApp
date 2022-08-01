using FirstFormApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApp
{
    public partial class Category : Form
    {
        CategoryManager _manager = new();
        public Category()
        {
            InitializeComponent();
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            var name = TxtName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Butun xanalari doldurun", "Diqqet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Category category = new()
                    {
                        Name = name,
                    };
                    _manager.Add(category);
                    MessageBox.Show("Category ugurla elave olundu");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xeta bas verdi yeniden cehd edin");
                }
            }
        }
    }
}
