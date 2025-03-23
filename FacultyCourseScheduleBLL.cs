using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    class FacultyCourseScheduleBLL
    {
        private FacultyCourseScheduleDAL scheduleDAL = new FacultyCourseScheduleDAL();

        public bool AddSchedule(int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            if (startTime >= endTime)
            {
                return false; // Validation check
            }
            return scheduleDAL.AddSchedule(facultyCourseId, roomId, dayOfWeek, startTime, endTime);
        }

        public List<facultyCourseSchedule> GetAllSchedules()
        {
            return scheduleDAL.GetAllSchedules();
        }

        public facultyCourseSchedule GetScheduleById(int id)
        {
            return scheduleDAL.GetScheduleById(id);
        }

        public bool UpdateSchedule(int scheduleId, int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            if (startTime >= endTime)
            {
                return false; // Validation check
            }
            return scheduleDAL.UpdateSchedule(scheduleId, facultyCourseId, roomId, dayOfWeek, startTime, endTime);
        }

        public bool DeleteSchedule(int id)
        {
            return scheduleDAL.DeleteSchedule(id);
        }
    }
}
