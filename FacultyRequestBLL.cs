using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{

    public class FacultyRequestBLL
    {
        private readonly FacultyRequestDAL facultyRequestDAL;

        public FacultyRequestBLL()
        {
            facultyRequestDAL = new FacultyRequestDAL();
        }

        public List<FacultyRequest> GetAllFacultyRequests()
        {
            return facultyRequestDAL.GetAllFacultyRequests();
        }

        public FacultyRequest GetFacultyRequestById(int requestId)
        {
            return facultyRequestDAL.GetFacultyRequestById(requestId);
        }

        public bool UpdateFacultyRequestStatus(int requestId, int statusId)
        {
            FacultyRequest request = facultyRequestDAL.GetFacultyRequestById(requestId);
            if (request == null) return false;

            request.Status = new Lookup { LookupId = statusId };

            return facultyRequestDAL.UpdateFacultyRequest(request);
        }
    }
}
