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
    public partial class Process_faculty_requests: Form
    {
        public Process_faculty_requests()
        {
            InitializeComponent();
        }
        private static Process_faculty_requests instance;
        public static Process_faculty_requests Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Process_faculty_requests();
                }
                return instance;
            }
        }
    }
}
