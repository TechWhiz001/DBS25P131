using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class FacultyRoomAllocationBLL
    {
        private FacultyRoomAllocationDAL dal = new FacultyRoomAllocationDAL();

        public bool AddAllocation(int fid,int rid,int sid,int rhours)
        {
            return dal.Insert(fid,rid,sid,rhours);
        }

        public List<FacultyRoomAllocation> GetAllocations()
        {
            return dal.GetAllAllocations();
        }

        public bool UpdateAllocation(int aid, int fid, int rid, int sid, int rhours)
        {
            return dal.Update(aid,fid,rid,sid,rhours);
        }

        public bool RemoveAllocation(int allocationId)
        {
            return dal.Delete(allocationId);
        }
    }
}
