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
    public partial class UserProfiles: Form
    {
        public UserProfiles()
        {
            InitializeComponent();
        }
        private static UserProfiles instance;
        public static UserProfiles Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserProfiles();
                }
                return instance;
            }
        }
    }
}
