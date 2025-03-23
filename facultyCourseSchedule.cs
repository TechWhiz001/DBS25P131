using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    class facultyCourseSchedule
    {
        public int ScheduleId { get; set; }
        public int FacultyCourseId { get; set; }
        public int RoomId { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
       public  facultyCourseSchedule()
        { }
        public facultyCourseSchedule(int scheduleId, int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            ScheduleId = scheduleId;
            FacultyCourseId = facultyCourseId;
            RoomId = roomId;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
        }
        public facultyCourseSchedule(int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            FacultyCourseId = facultyCourseId;
            RoomId = roomId;
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
