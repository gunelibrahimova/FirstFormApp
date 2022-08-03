using FirstFormApp.Models;
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
    public partial class Dashboard : Form
    {
        private readonly CategoryManager _categoryManager = new();
        ProductManager _productManager = new();
        public Dashboard()
        {
            InitializeComponent();
        }

        public void LoadProducts()
        {
            Dgvproduct.DataSource = _productManager.GetAllProducts();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            LoadProducts();

            var category = _categoryManager.GetAll();

            var txtCategoryName = Txtcategoryname;

            foreach (var c in category)
            {
                txtCategoryName.Items.Add(c.Name);
            }
        }

        private void Btnaddtolist_Click(object sender, EventArgs e)
        {


            var productName = Txtname.Text;
            var price = Txtprice.Value;
            var quantity = Txtquantity.Value;
            var sku = Txtsku.Text;
            var category = Txtcategoryname.Text;
            var productionDate = Txtdatetime.Value;
            var expressionDate = Txtexpression.Value;

            Txtchecked.Items.Add(productName+"-"+price + "-" +quantity + "-" +sku + "-" +category + "-" +productionDate + "-" +expressionDate);
            Txtname.Text = "";
            Txtprice.Value = 0;
            Txtquantity.Value = 0;

        }

        private void Btnaddtobase_Click(object sender, EventArgs e)
        {
            var productList = Txtchecked.Items;

            for(int i = 0; i < productList.Count; i++)
            {
                var product = productList[i].ToString().Split("-");

                Product newProduct = new()
                {
                    Name = product[0],
                    Price = Convert.ToDecimal(product[1]),
                    Quantity = Convert.ToDecimal(product[2]),
                    SKU = product[3],
                    CategoryId = 1,
                    ProductionDate = Convert.ToDateTime(product[5]),
                    ExpirationDate = Convert.ToDateTime(product[6]),
                    PhotoURL = "kjsdn"
                };
                _productManager.Add(newProduct);
            }

            LoadProducts();
        }
    }
}
