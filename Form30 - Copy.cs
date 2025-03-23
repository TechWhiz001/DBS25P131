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
    public partial class requestStatusform : Form
    {
        private FacultyRequestBLL facultyrequestbll = new FacultyRequestBLL();
        private FacultyBLL facultybll = new FacultyBLL();
        private List<FacultyRequest> facultyrequest;


        private int uid;
        public requestStatusform(int userid)
        {
            InitializeComponent();
            this.uid = userid;
        }
        //private static requestStatus instance;
        //public static requestStatus Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new requestStatus();
        //        }
        //        return instance;
        //    }
        //}
        private void requestStatus_Load(object sender, EventArgs e)
        {
            Load_Request();
        }
        private void Load_Request()
        {
            dataGridView1.Rows.Clear();

            int facultyid = facultybll.GetFacultyIdByUserId(uid);
            var facultyrequests = facultyrequestbll.GetRequestsByFacultyId(facultyid);

            foreach (var request in facultyrequests)
            {
                dataGridView1.Rows.Add(
          request.RequestId,
                 request.Faculty != null ? request.Faculty.FacultyId : 0,
                 request.Faculty != null ? request.Faculty.Name : "N/A",
                request.Item != null ? request.Item.ItemName : "N/A",
                request.Quantity,
                 request.RequestDate.HasValue ? request.RequestDate.Value.ToString("yyyy-MM-dd") : "N/A",
                    request.Status != null ? request.Status.Value : "N/A"
                 );

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
