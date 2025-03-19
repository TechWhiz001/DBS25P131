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
    public partial class VeiwCourses : Form
    {
        public VeiwCourses()
        {
            InitializeComponent();
        }
        private static VeiwCourses instance;
        public static VeiwCourses Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VeiwCourses();
                }
                return instance;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
