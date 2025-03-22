using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class FacultyRoomAllocation
        {
            public int AllocationId { get; set; }  
            public int ReservedHours { get; set; }

            public Faculty Faculty { get; set; }
            public Room Room { get; set; }
            public Semester Semester { get; set; }

            // Constructor
            public FacultyRoomAllocation(int allocationId, Faculty faculty, Room room, int reservedHours, Semester semester)
            {
                AllocationId = allocationId;
                ReservedHours = reservedHours;
                Faculty =  faculty;
                Room =  room;
                Semester = semester;
            }
        }
    }


