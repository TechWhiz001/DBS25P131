using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBS25P131.BusinessLayer;
using DBS25P131.Models;

namespace DBS25P131
{
    public partial class submitRequest : Form
    {
        private FacultyRequestBLL facultyRequestbll = new FacultyRequestBLL();
        private ConsumableBLL consumablesbll = new ConsumableBLL();


        private int requestid;
        private int facultyid;
        private string facultyName;
        private string itemname;
        private int quantity;
        private DateTime date;
        private string formateDate;
        private List<FacultyRequest> facultyrequest;

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FitextBox2_TextChanged(object sender, EventArgs e)
        {
            facultyid = Convert.ToInt32(FitextBox2.Text);
        }

        private void FNtextBox3_TextChanged(object sender, EventArgs e)
        {
            facultyName = FNtextBox3.Text;
        }

        private void RescomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemname = RescomboBox1.Text;
        }

        private void QnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)QnumericUpDown1.Value;
        }

        private void RDdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = RDdateTimePicker1.Value;
            formateDate = date.ToString("yyyy-MM-dd");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (facultyid <= 0)
            {
                MessageBox.Show("Please enter a valid Faculty ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(facultyName))
            {
                MessageBox.Show("Please enter Faculty Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(itemname))
            {
                MessageBox.Show("Please select an item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(formateDate))
            {
                MessageBox.Show("Please select a request date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get item ID from the database
            int itemid = consumablesbll.GetItemIdByName(itemname);

            if (itemid == -1)
            {
                MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert request into the database
            bool isInserted = facultyRequestbll.insertFacultyRequest(facultyid, itemid, quantity, 8, formateDate);

            if (isInserted)
            {
                MessageBox.Show("Your request has been submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to submit request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitRequest_Load(object sender, EventArgs e)
        {
            FitextBox2.Clear();
            FNtextBox3.Clear();
            RescomboBox1.Items.Clear(); // Clear existing items
            QnumericUpDown1.Value = 1; // Set default quantity
            RDdateTimePicker1.Value = DateTime.Today; // Set today's date

            // Reset stored variables
            facultyid = 0;
            facultyName = string.Empty;
            itemname = string.Empty;
            quantity = 1;
            formateDate = string.Empty;

            // Load available items from the consumables table
            List<Consumables> availableItems = consumablesbll.GetAllConsumables();

            if (availableItems != null && availableItems.Count > 0)
            {
                // Extract item names and add them to the ComboBox
                foreach (var item in availableItems)
                {
                    RescomboBox1.Items.Add(item.ItemName); // Assuming 'ItemName' is the correct property
                }
            }
            else
            {
                MessageBox.Show("No available items found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
