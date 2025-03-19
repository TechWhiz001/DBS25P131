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
    public partial class faculty_course_schedule : Form
    {
        public faculty_course_schedule()
        {
            InitializeComponent();
        }
        private static faculty_course_schedule instance;
        public static faculty_course_schedule Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new faculty_course_schedule();
                }
                return instance;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
