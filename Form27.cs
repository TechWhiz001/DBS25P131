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
    public partial class Resource : Form
    {
        public Resource()
        {
            InitializeComponent();
        }
        private static Resource instance;
        public static Resource Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Resource();
                }
                return instance;
            }
        }
        private void Requests_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
