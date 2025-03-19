using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P131
{
    public partial class forgetPassword : Form
    {
        public forgetPassword()
        {
            InitializeComponent();
        }
        private static forgetPassword instance;
        public static forgetPassword Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new forgetPassword();
                }
                return instance;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashBoard dBoard = new dashBoard();
            dBoard.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
