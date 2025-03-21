using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Room
    {
        public int RoomId { get; set; }       
        public string RoomName { get; set; } 
        public string RoomType { get; set; }  
        public int Capacity { get; set; }     
        public Room()
        {

        }
       
        public Room(int roomId, string roomName, string roomType, int capacity)
        {
            RoomId = roomId;
            RoomName = roomName;
            RoomType = roomType;
            Capacity = capacity;
        }

       
        public Room(string roomName, string roomType, int capacity)
        {
            RoomName = roomName;
            RoomType = roomType;
            Capacity = capacity;
        }
    }
}
