﻿using System;
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
    public partial class requestStatus: Form
    {
        public requestStatus()
        {
            InitializeComponent();
        }
        private static requestStatus instance;
        public static requestStatus Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new requestStatus();
                }
                return instance;
            }
        }
    }
}
