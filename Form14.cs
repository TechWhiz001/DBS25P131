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
    public partial class Process_faculty_requests : Form
    {
        private readonly FacultyRequestBLL _facultyRequestBLL = new FacultyRequestBLL()  ;

        public Process_faculty_requests()
        {
            InitializeComponent();
            FrequestGridView.CellClick += FrequestGridView_CellContentClick;

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

        private void LoadFacultyRequests()
        {
            FrequestGridView.Rows.Clear();
            FrequestGridView.Columns.Clear(); // Prevent duplicate columns

            // Add columns
            FrequestGridView.Columns.Add("RequestID", "Request ID");
            FrequestGridView.Columns.Add("Fid", "Faculty ID");
            FrequestGridView.Columns.Add("FacultyName", "Faculty Name");
            FrequestGridView.Columns.Add("ItemName", "Item Name");
            FrequestGridView.Columns.Add("Quantity", "Quantity");
            FrequestGridView.Columns.Add("StatusID", "Status ID");
            FrequestGridView.Columns.Add("RequestDate", "Request Date");

            // Fulfill Button
            DataGridViewButtonColumn fulfillButton = new DataGridViewButtonColumn()
            {
                Name = "FulFillButton",
                HeaderText = "Fulfill",
                Text = "✔ Fulfill",
                UseColumnTextForButtonValue = true
            };
            FrequestGridView.Columns.Add(fulfillButton);

            // Reject Button
            DataGridViewButtonColumn rejectButton = new DataGridViewButtonColumn()
            {
                Name = "RejectButton",
                HeaderText = "Reject",
                Text = "❌ Reject",
                UseColumnTextForButtonValue = true
            };
            FrequestGridView.Columns.Add(rejectButton);

            // Fetch only approved requests (Status ID 8 = Approved)
            List<FacultyRequest> requests = _facultyRequestBLL
                .GetAllFacultyRequests()
                .Where(r => r.Status != null && r.Status.LookupId == 8) // Only Approved
                .ToList();

            foreach (var request in requests)
            {
                FrequestGridView.Rows.Add(
                    request.RequestId,
                    request.Faculty?.FacultyId,
                    request.Faculty?.Name ?? "Unknown",
                    request.Item?.ItemName ?? "Unknown",
                    request.Quantity,
                    request.Status.LookupId,
                    request.RequestDate.HasValue ? request.RequestDate.Value.ToShortDateString() : "N/A"
                );
            }
        }

        private void Process_faculty_requests_Load(object sender, EventArgs e)
        {
            LoadFacultyRequests();
        }

        private void UpdateRequestStatus(int rowIndex, int statusId)
        {
            // ✅ Prevent invalid selection errors
            if (rowIndex < 0 || rowIndex >= FrequestGridView.Rows.Count)
            {
                MessageBox.Show("Invalid selection. Please select a valid request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = FrequestGridView.Rows[rowIndex];

            // ✅ Ensure the column name is correct
            if (!int.TryParse(selectedRow.Cells["RequestID"].Value?.ToString(), out int requestId))
            {
                MessageBox.Show("Invalid request selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var request = _facultyRequestBLL.GetFacultyRequestById(requestId);
            if (request == null)
            {
                MessageBox.Show("Request not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            request.Status.LookupId = statusId;

            if (_facultyRequestBLL.UpdateFacultyRequestStatus(requestId, statusId))
            {
                string action = (statusId == 10) ? "fulfilled" : "rejected";
                MessageBox.Show($"Request {requestId} has been {action}.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Remove the row safely after a successful update
                if (rowIndex >= 0 && rowIndex < FrequestGridView.Rows.Count)
                {
                    FrequestGridView.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Failed to update request status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrequestGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = FrequestGridView.Columns[e.ColumnIndex].Name;

            if (columnName == "FulFillButton")
            {
                UpdateRequestStatus(e.RowIndex, 10); // Fulfill request (Status ID 10)
            }
            else if (columnName == "RejectButton")
            {
                UpdateRequestStatus(e.RowIndex, 9); // Reject request (Status ID 9)
            }
        }

    }
}
