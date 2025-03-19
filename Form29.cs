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
    public partial class submitRequest : Form
    {
        public submitRequest()
        {
            InitializeComponent();
        }
        private static submitRequest instance;
        public static submitRequest Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new submitRequest();
                }
                return instance;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
