using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DBS25P131.BusinessLayer;
using DBS25P131.Models;

namespace DBS25P131
{
    public partial class HODFREQUEST : Form
    {
        private readonly FacultyRequestBLL _facultyRequestBLL;

        public HODFREQUEST()
        {
            InitializeComponent();
            _facultyRequestBLL = new FacultyRequestBLL();
/*            FrequestGridView.CellClick += dataGridView1_CellContentClick;
*/        }
        private static FacultyRequestBLL instance;
        public static FacultyRequestBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FacultyRequestBLL();
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

            // Approve Button
            DataGridViewButtonColumn approveButton = new DataGridViewButtonColumn()
            {
                Name = "ApproveButton",
                HeaderText = "Approve",
                Text = "✔ Approve",
                UseColumnTextForButtonValue = true
            };
            FrequestGridView.Columns.Add(approveButton);

            // Reject Button
            DataGridViewButtonColumn rejectButton = new DataGridViewButtonColumn()
            {
                Name = "RejectButton",
                HeaderText = "Reject",
                Text = "❌ Reject",
                UseColumnTextForButtonValue = true
            };
            FrequestGridView.Columns.Add(rejectButton);

            // Fetch only pending requests (Status ID 7 = Pending)
            List<FacultyRequest> requests = _facultyRequestBLL
                .GetAllFacultyRequests()
                .Where(r => r.Status != null && r.Status.LookupId == 8) // Only Pending
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = FrequestGridView.Columns[e.ColumnIndex].Name;
            if (columnName == "ApproveButton")
            {
                UpdateRequestStatus(e.RowIndex, 8); // Approve
            }
            else if (columnName == "RejectButton")
            {
                UpdateRequestStatus(e.RowIndex, 9); // Reject
            }
        }

        private void UpdateRequestStatus(int rowIndex, int statusId)
        {
            // Check row validity
            if (rowIndex < 0 || rowIndex >= FrequestGridView.Rows.Count)
            {
                return;
            }

            DataGridViewRow selectedRow = FrequestGridView.Rows[rowIndex];
            if (!int.TryParse(selectedRow.Cells["RequestID"].Value?.ToString(), out int requestId))
            {
                return;
            }

            var request = _facultyRequestBLL.GetFacultyRequestById(requestId);
            if (request == null)
            {
                MessageBox.Show("Request not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update request status
            if (_facultyRequestBLL.UpdateFacultyRequestStatus(requestId, statusId))
            {
                string action = (statusId == 8) ? "approved" : "rejected";
                MessageBox.Show($"Request {requestId} has been {action}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Remove the row if still valid
                if (rowIndex < FrequestGridView.Rows.Count)
                {
                    FrequestGridView.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Failed to update request status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HODFREQUEST_Load(object sender, EventArgs e)
        {
            LoadFacultyRequests();
        }
    }
}
