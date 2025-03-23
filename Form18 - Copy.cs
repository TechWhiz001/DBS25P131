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
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBS25P131
{
    public partial class RoomAllocationForm : Form
    {
        private RoomBLL roombll;

        private int roomId;
        private string roomName;
        private string roomType;
        private  int capacity;
        private List<Room> roomassign;
        private static RoomAllocationForm instance;
        public static RoomAllocationForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomAllocationForm();
                }
                return instance;
            }
        }
        public RoomAllocationForm()
        {
            InitializeComponent();
            roombll = new RoomBLL();
        }
        private void Load_AllocateRoom()
        {
            dataGridView1.Rows.Clear();
            var roomassign = roombll.GetAllRooms();

            foreach (var room in roomassign)
            {

                dataGridView1.Rows.Add(
                    room.RoomId,
                    room.RoomName,
                    room.RoomType,
                    room.Capacity
                );
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void RoomAllocationForm_Load(object sender, EventArgs e)
        {
            Load_AllocateRoom();
            if (!dataGridView1.Columns.Contains("Update"))
            {
                DataGridViewButtonColumn UpdateButton = new DataGridViewButtonColumn();
                UpdateButton.Name = "Update";
                UpdateButton.HeaderText = "Action";
                UpdateButton.Text = "Update";
                UpdateButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(UpdateButton);
            }
            if (!dataGridView1.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Action";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButton);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete") 
                {
                    int facultyProjectIdToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this project assignment?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            roombll.DeleteRoom(facultyProjectIdToDelete);

                            Load_AllocateRoom();

                            MessageBox.Show("Project assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    roomId = Convert.ToInt32(row.Cells[0].Value);
                    roomName = row.Cells[1].Value.ToString();
                    roomType = row.Cells[2].Value.ToString();
                    capacity = Convert.ToInt32(row.Cells[3].Value);

                    RntextBox2.Text = roomName.ToString();
                    RtypetextBox1.Text = roomType.ToString();
                    captextBox1.Text = capacity.ToString();
                }
            }
        }

        

        private void RntextBox2_TextChanged(object sender, EventArgs e)
        {
            roomName = RntextBox2.Text;
        }

        private void RtypetextBox1_TextChanged(object sender, EventArgs e)
        {
            roomType = RtypetextBox1.Text;
        }

        private void captextBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(captextBox1.Text, out capacity);
        }

        private void RAssignbutton_Click(object sender, EventArgs e)
        {
            try
            {
               
                if ( string.IsNullOrEmpty(roomType) || string.IsNullOrEmpty(roomName) || capacity==0)
                {
                    MessageBox.Show("Please fill in all fields before adding a Room assignment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (roomId == 0)
                {
                    roombll.AddRoom(roomName, roomType, capacity );
                    MessageBox.Show("Project assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    roombll.UpdateRoom(roomId, roomName, roomType, capacity);
                    MessageBox.Show("Project assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    roomId = 0;
                }


                Load_AllocateRoom();


                //ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
