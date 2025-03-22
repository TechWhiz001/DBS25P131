using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class RoomBLL
    {
        private readonly RoomDAL roomDAL;

        public RoomBLL()
        {
            roomDAL = new RoomDAL();
        }

        public List<Room> GetAllRooms()
        {
            return roomDAL.GetAllRooms();
        }
        public List<Room> GetUnassignedRooms()
        {
            return roomDAL.GetUnassignedRooms();
        }
        public bool AddRoom(string rname, string rtype, int capacity)
        {
            
            return roomDAL.InsertRoom(rname,rtype,capacity);
        }

        public bool UpdateRoom(int rid, string rname, string rtype, int capacity)
        {
            
            return roomDAL.UpdateRoom(rid,rname,rtype,capacity);
        }

        public bool DeleteRoom(int roomId)
        {
            if (roomId <= 0)
            {
                throw new ArgumentException("Invalid room ID.");
            }
            return roomDAL.DeleteRoom(roomId);
        }
    }
}
