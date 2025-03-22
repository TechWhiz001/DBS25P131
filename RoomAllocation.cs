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

namespace DBS25P131.PresentationLayer
{
    public partial class RoomAllocation : Form
    {
        private FacultyBLL facultybll = new FacultyBLL();
        private RoomBLL roombll = new RoomBLL();
        private FacultyRoomAllocationBLL roomallocationbll = new FacultyRoomAllocationBLL();
        private SemesterBLL semesterbll = new SemesterBLL();

        private int allocationId = 0;
        private string facultyName;
        private int facultyId;
        private string roomName;
        private int roomId;
        private string roomType;
        private string semesterTerm;
        private int semesterYear;
        private int ReservedHours;
        private List<Room> roomassign;
        private List<Semester> semesterassign;
        private List<RoomAllocation> roomsallow;

        public RoomAllocation()
        {
            InitializeComponent();
        }
        private static ProjectAssign instance;
        public static ProjectAssign Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectAssign();
                }
                return instance;
            }
        }
        private void Load_Rooms()
        {
            roomassign = roombll.GetUnassignedRooms();
            RnameCombobox.Items.Clear();
            foreach (var room in roomassign)
            {
                RnameCombobox.Items.Add(room.RoomName);
            }
        }
        private void Load_Faculty()
        {
            var faculties = facultybll.GetAllFaculties();
            FNcomboBox1.Items.Clear();
            foreach (var faculty in faculties)
            {
                FNcomboBox1.Items.Add(faculty.Name);
            }
        }

        private void Load_Semester()
        {
            semesterassign = semesterbll.GetAllSemesters();
            TermcomboBox2.Items.Clear();
            YearcomboBox1.Items.Clear();
            foreach (var semester in semesterassign)
            {
                TermcomboBox2.Items.Add(semester.Term);
                YearcomboBox1.Items.Add(semester.Year.ToString());
            }
        }

        private void Load_AssignedRooms()
        {
            dataGridView1.Rows.Clear();
            var roomaAllow = roomallocationbll.GetAllocations();

            foreach (var room in roomaAllow)
            {

                dataGridView1.Rows.Add(
                    room.AllocationId,
                    room.Faculty.FacultyId,
                    room.Faculty.Name,
                    room.Room.RoomId,
                    room.Room.RoomName,
                    room.Room.RoomType,
                    room.Semester.Year,
                    room.Semester.Term,
                    room.ReservedHours
                );
            }
        }
        private void ResetFields()
        {
            // Clear TextBoxes
            FItextBox5.Clear();
            RItextBox1.Clear();
            rhoursetextBox2.Clear();
            RtypetextBox3.Clear();

            // Reset ComboBoxes
            FNcomboBox1.SelectedIndex = -1;
            RnameCombobox.SelectedIndex = -1;
            TermcomboBox2.SelectedIndex = -1;
            YearcomboBox1.SelectedIndex = -1;

            // Reset Stored Values
            allocationId = 0;
            facultyId = 0;
            facultyName = "";
            roomId = 0;
            roomName = "";
            roomType = "";
            semesterTerm = "";
            semesterYear = 0;
            ReservedHours = 0;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int facultyProjectIdToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this room assignment?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            roomallocationbll.RemoveAllocation(facultyProjectIdToDelete);

                            Load_AssignedRooms();

                            MessageBox.Show("Room assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    allocationId = Convert.ToInt32(row.Cells[0].Value);
                    facultyId = Convert.ToInt32(row.Cells[1].Value);
                    facultyName = row.Cells[2].Value.ToString();
                    roomId = Convert.ToInt32(row.Cells[3].Value);

                    roomName = row.Cells[4].Value.ToString();
                    roomType = row.Cells[5].Value.ToString();
                    semesterYear = Convert.ToInt32(row.Cells[6].Value);
                    semesterTerm = row.Cells[7].Value.ToString();
                    ReservedHours = Convert.ToInt32(row.Cells[8].Value);

                    FItextBox5.Text = facultyId.ToString();
                    RItextBox1.Text = roomId.ToString();
                    rhoursetextBox2.Text = ReservedHours.ToString();

                    FNcomboBox1.SelectedItem = facultyName;
                    RnameCombobox.SelectedItem = roomName;
                    RtypetextBox3.Text = roomType;
                    TermcomboBox2.SelectedItem = semesterTerm;
                    YearcomboBox1.SelectedItem = semesterYear.ToString();
                }
            }
        }

        private void FNcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FNcomboBox1.SelectedItem != null)
            {
                facultyName = FNcomboBox1.SelectedItem.ToString();

                var selectedFaculty = facultybll.GetAllFaculties().FirstOrDefault(f => f.Name == facultyName);

                if (selectedFaculty != null)
                {
                    facultyId = selectedFaculty.FacultyId;
                    FItextBox5.Text = facultyId.ToString();
                }
            }
        }

        private void FItextBox5_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(FItextBox5.Text, out facultyId);

        }

        private void RnameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RnameCombobox.SelectedItem != null)
            {
                roomName = RnameCombobox.SelectedItem.ToString();

                var selectedroom = roomassign.FirstOrDefault(p => p.RoomName == roomName);

                if (selectedroom != null)
                {
                    roomId = selectedroom.RoomId;
                    roomType = selectedroom.RoomType;

                    RItextBox1.Text = roomId.ToString();
                    RtypetextBox3.Text = roomType;

                }
            }
        }

        private void RItextBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(RItextBox1.ToString(), out roomId);

        }

        private void YearcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearcomboBox1.SelectedItem != null)
            {
                int.TryParse(YearcomboBox1.SelectedItem.ToString(), out semesterYear);
            }
        }

        private void TermcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TermcomboBox2.SelectedItem != null)
            {
                semesterTerm = TermcomboBox2.SelectedItem.ToString();
            }
            else
            {
                semesterTerm = "";
            }
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FNcomboBox1.SelectedItem != null)
                {
                    facultyName = FNcomboBox1.SelectedItem.ToString();
                    var selectedFaculty = facultybll.GetAllFaculties().FirstOrDefault(f => f.Name == facultyName);
                    if (selectedFaculty != null)
                        facultyId = selectedFaculty.FacultyId;
                }

                if (RnameCombobox.SelectedItem != null)
                {
                    roomName = RnameCombobox.SelectedItem.ToString();
                    var selectedProject = roomassign.FirstOrDefault(p => p.RoomName == roomName);
                    if (selectedProject != null)
                        roomId = selectedProject.RoomId;
                }

                if (TermcomboBox2.SelectedItem != null)
                    semesterTerm = TermcomboBox2.SelectedItem.ToString();

                if (YearcomboBox1.SelectedItem != null)
                    int.TryParse(YearcomboBox1.SelectedItem.ToString(), out semesterYear);

                if (!int.TryParse(rhoursetextBox2.Text, out ReservedHours) || ReservedHours <= 0)
                {
                    MessageBox.Show("Please enter a valid number for Reserved hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (facultyId == 0 || roomId == 0 || string.IsNullOrEmpty(semesterTerm) || semesterYear == 0 || ReservedHours == 0)
                {
                    MessageBox.Show("Please fill in all fields before adding a room assignment.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int semesterId = semesterbll.GetSemesterIdByTermAndYear(semesterTerm, semesterYear);

                if (allocationId == 0)
                {
                    roomallocationbll.AddAllocation(facultyId, roomId, semesterId, ReservedHours);
                    MessageBox.Show("Room assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    roomallocationbll.UpdateAllocation(allocationId, facultyId, roomId, semesterId, ReservedHours);
                    MessageBox.Show("Room assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    allocationId = 0;
                }


                Load_AssignedRooms();


                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RoomAllocation_Load(object sender, EventArgs e)
        {
            Load_Faculty();
            Load_Rooms();
            Load_Semester();
            Load_AssignedRooms();
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

        private void RhourecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (RhourecomboBox1.Text != null)
            //{
            //    int.TryParse(RhourecomboBox1.Text, out ReservedHours);
            //    RhourecomboBox1.Text = ReservedHours.ToString();
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Rtypecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Rtypecombobox.SelectedItem != null)
            //{
            //    roomType = Rtypecombobox.SelectedItem.ToString();
            //}
            //else
            //{
            //    roomType = "";
            //}
        }

        private void rhoursetextBox2_TextChanged(object sender, EventArgs e)
        {
            if (rhoursetextBox2.Text != null)
            {
                int.TryParse(rhoursetextBox2.Text, out ReservedHours);
                rhoursetextBox2.Text = ReservedHours.ToString();
            }
        }

        private void RtypetextBox3_TextChanged(object sender, EventArgs e)
        {
            if (RtypetextBox3.Text != null)
            {
                roomType = RtypetextBox3.Text;
            }
            else
            {
                roomType = "";
            }

        }
    }
}
