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
    public partial class Bill : Form
    {
        Code.bll qd = new Code.bll();
        int s;
        public Bill(int item,String user,int bil,int sid)
        {
            InitializeComponent();
            lbldate.Text = DateTime.Now.ToString();
            lblname.Text = user;
            lblqty.Text = item.ToString();
            ttltxt.Text = bil.ToString();
            s = sid;

        }

        private void Bill_Load(object sender, EventArgs e)
        {
            qd.GetSellProduct(cartgrid,s);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblqty_Click(object sender, EventArgs e)
        {

        }

        private void thanklbl_Click(object sender, EventArgs e)
        {

        }
    }
}
