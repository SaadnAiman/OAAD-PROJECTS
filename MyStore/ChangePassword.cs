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
    public partial class ChangePassword : Form
    {
        Code.bll qd = new Code.bll();
        public ChangePassword(Code.bll qdb)
        {
            InitializeComponent();
            qd = qdb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oldpasstxt.Text = "";
            newpasstxt.Text = "";
            rtpasstxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (qd.PASSWORD == oldpasstxt.Text)
            {
                if (newpasstxt.Text.Equals(rtpasstxt.Text))
                {
                    qd.PASSWORD = newpasstxt.Text;
                    if (qd.ChangePassword(qd))
                    {
                        MessageBox.Show("Password Changed Successfully");
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Password do not matched!!!!");
                    oldpasstxt.Text = "";
                    newpasstxt.Text = "";
                    rtpasstxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old PAssword");
                oldpasstxt.Text = "";
                newpasstxt.Text = "";
                rtpasstxt.Text = "";
            }
        }
    }
}
