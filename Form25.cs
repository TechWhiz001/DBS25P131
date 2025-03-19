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
    public partial class FacultyRequest: Form
    {
        private static WorkloadAssign instance;
        public static WorkloadAssign Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WorkloadAssign();
                }
                return instance;
            }
        }
        public FacultyRequest()
        {
            InitializeComponent();
        }
    }
}
