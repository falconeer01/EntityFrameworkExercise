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
    public partial class Main_Entrance : Form
    {
        public Main_Entrance()
        {
            InitializeComponent();
        }

        private void CatOp_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void ProdOp_Click(object sender, EventArgs e)
        {
            Products frm_products = new Products();
            frm_products.Show();
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            FrmStats frmStats = new FrmStats();
            frmStats.Show();
        }
    }
}
