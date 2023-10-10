using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsEF
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        Entity_Product_DBEntities DB = new Entity_Product_DBEntities();

        private void listBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in DB.Product
                                        select new
                                        {
                                            x.ID,
                                            x.Product_Name,
                                            x.Brand,
                                            x.Stocks,
                                            x.Price,
                                            x.Category1.Name,
                                            x.Status
                                        }).ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Product TBLProduct = new Product
            {
                Product_Name = ProNameBox.Text,
                Brand = BrandBox.Text,
                Stocks = short.Parse(Stocks.Text),
                Price = decimal.Parse(PriceBox.Text),
                Status = true,
                Category = int.Parse(CatgBox.Text)
            };

            DB.Product.Add(TBLProduct);
            DB.SaveChanges();
            MessageBox.Show("Added a new Product.");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(IDBox.Text);
            var table = DB.Product.Find(x);
            DB.Product.Remove(table);
            DB.SaveChanges();
            MessageBox.Show("Deleted the related Product.");
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(IDBox.Text);
            var table = DB.Product.Find(x);
            table.Product_Name = ProNameBox.Text;
            table.Brand = BrandBox.Text;
            table.Stocks = short.Parse(Stocks.Text);
            table.Price = decimal.Parse(PriceBox.Text);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            var categories = (from x in DB.Category
                              select new
                              {
                                  x.ID,
                                  x.Name
                              }
                             ).ToList();
            CatgBox.ValueMember = "ID";
            CatgBox.DisplayMember = "Name";
            CatgBox.DataSource = categories;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Text = string.Empty;
                }
            }
        }
    }
}
