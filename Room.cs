using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Room
    {
        public int RoomId { get; set; }       // Primary Key, Auto-increment
        public string RoomName { get; set; }  // Room Name
        public string RoomType { get; set; }  // Enum ('Classroom', 'Lab')
        public int Capacity { get; set; }     // Capacity
        public Room()
        {

        }
        // Constructor for Data Retrieval (Includes ID)
        public Room(int roomId, string roomName, string roomType, int capacity)
        {
            RoomId = roomId;
            RoomName = roomName;
            RoomType = roomType;
            Capacity = capacity;
        }

        // Constructor for Data Adding (Excludes ID)
        public Room(string roomName, string roomType, int capacity)
        {
            RoomName = roomName;
            RoomType = roomType;
            Capacity = capacity;
        }
    }
}
