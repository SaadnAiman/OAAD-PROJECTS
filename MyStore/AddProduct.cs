using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStore
{
    public partial class AddProduct : Form
    {
        Code.bll qd = new Code.bll();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PNametxt.Text = "";
            PPricetxt.Text = "";
            PQuantitytxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qd.AddProduct(PNametxt.Text, Convert.ToInt32(PPricetxt.Text), Convert.ToInt32(PQuantitytxt.Text)))
            {
                PNametxt.Text = "";
                PPricetxt.Text = "";
                PQuantitytxt.Text = "";
                MessageBox.Show("Product add Sucessfuly");

            }
            else {
                MessageBox.Show("Something Gone Wrong");
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
