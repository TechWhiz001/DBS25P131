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
    public partial class AssignCourses : Form
    {
        public AssignCourses()
        {
            InitializeComponent();
        }
        private static AssignCourses instance;
        public static AssignCourses Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AssignCourses();
                }
                return instance;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
