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

        public bool AddRoom(Room room)
        {
            if (room == null || string.IsNullOrWhiteSpace(room.RoomName) ||
                string.IsNullOrWhiteSpace(room.RoomType) || room.Capacity <= 0)
            {
                throw new ArgumentException("Invalid room data.");
            }
            return roomDAL.InsertRoom(room);
        }

        public bool UpdateRoom(Room room)
        {
            if (room == null || room.RoomId <= 0 || string.IsNullOrWhiteSpace(room.RoomName) ||
                string.IsNullOrWhiteSpace(room.RoomType) || room.Capacity <= 0)
            {
                throw new ArgumentException("Invalid room data.");
            }
            return roomDAL.UpdateRoom(room);
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
