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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Entity_Product_DBEntities DB = new Entity_Product_DBEntities();

        private void listBtn_Click(object sender, EventArgs e)
        {
            var categories = DB.Category.ToList();
            dataGridView1.DataSource = categories;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Category TBLCategory = new Category();
            TBLCategory.Name = NameBox.Text;
            DB.Category.Add(TBLCategory);
            DB.SaveChanges();
            MessageBox.Show("Added a new Category.");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Category.ToList();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int indexToBeDeleted = Convert.ToInt32(IDBox.Text);
            var valueToBeDeleted = DB.Category.Find(indexToBeDeleted);
            DB.Category.Remove(valueToBeDeleted);
            DB.SaveChanges();
            MessageBox.Show("Deleted a Category.");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Category.ToList();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int indexToBeUpdated = Convert.ToInt32(IDBox.Text);
            var valueToBeUpdated = DB.Category.Find(indexToBeUpdated);
            valueToBeUpdated.Name = NameBox.Text;
            DB.SaveChanges();
            MessageBox.Show("Updated the related Category");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DB.Category.ToList();
        }
    }
}
