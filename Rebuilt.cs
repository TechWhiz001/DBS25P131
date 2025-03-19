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
    public partial class Rebuilt : Form
    {
        public Rebuilt()
        {
            InitializeComponent();

        }
        private static Rebuilt instance;
        public static Rebuilt Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Rebuilt();
                }
                return instance;
            }
         }
        public void LoadForm(Form form)
        {

            FirstPagepanel.Controls.Clear();


            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            FirstPagepanel.Controls.Add(form);
            form.Show();
        }

        private void FirstPagepanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
