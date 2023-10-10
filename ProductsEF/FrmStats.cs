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
    public partial class FrmStats : Form
    {
        public FrmStats()
        {
            InitializeComponent();
        }

        Entity_Product_DBEntities DB = new Entity_Product_DBEntities();

        private void FrmStats_Load(object sender, EventArgs e)
        {
            label2.Text = DB.Category.Count().ToString();

            label3.Text = DB.Product.Count().ToString();

            label5.Text = DB.Customer.Count(x => x.Status == true).ToString();

            label7.Text = DB.Customer.Count(x => x.Status == false).ToString();

            label9.Text = DB.Product.Count(x => x.Category == 1).ToString();

            label11.Text = DB.Product.Sum(x => x.Stocks).ToString();

            label13.Text = (from x in DB.Product
                            orderby x.Price descending
                            select x.Product_Name
                           ).FirstOrDefault();

            label15.Text = (from x in DB.Product
                            orderby x.Price ascending
                            select x.Product_Name
                           ).FirstOrDefault();

            label17.Text = (from x in DB.Customer
                            select x.City
                           ).Distinct().Count().ToString();

            label19.Text = DB.Sales.Sum(x => x.Price).ToString();

            label21.Text = DB.TopBrand().FirstOrDefault();

            label23.Text = DB.Product.Count(x => x.Product_Name == "BUZDOLABI").ToString();
        }
    }
}
