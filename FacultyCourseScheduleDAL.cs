using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    class FacultyCourseScheduleDAL
    {
        public bool AddSchedule(int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            // Check if there is a time conflict
            if (IsTimeConflict(roomId, dayOfWeek, startTime, endTime))
            {
                Console.WriteLine("Error: Time conflict detected! The room is already occupied at this time.");
                return false; // Prevent insertion
            }

            string query = @"INSERT INTO faculty_Course_Schedule (faculty_course_id, room_id, day_of_week, start_time, end_time) 
                     VALUES (@FacultyCourseId, @RoomId, @DayOfWeek, @StartTime, @EndTime)";
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FacultyCourseId", facultyCourseId);
                    cmd.Parameters.AddWithValue("@RoomId", roomId);
                    cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        private bool IsTimeConflict(int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            string query = @"
        SELECT COUNT(*) FROM faculty_Course_Schedule 
        WHERE room_id = @RoomId 
        AND day_of_week = @DayOfWeek 
        AND (
            (@StartTime >= start_time AND @StartTime < end_time) OR  -- New start is within existing time
            (@EndTime > start_time AND @EndTime <= end_time) OR      -- New end is within existing time
            (@StartTime <= start_time AND @EndTime >= end_time)      -- New time completely overlaps existing time
        )";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RoomId", roomId);
                    cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // If count > 0, a conflict exists
                }
            }
        }


        public List<facultyCourseSchedule> GetAllSchedules()
        {
            List<facultyCourseSchedule> schedules = new List<facultyCourseSchedule>();
            string query = @"
                SELECT 
                    fcs.schedule_id,
                    fcs.faculty_course_id,
                    fcs.room_id,
                    fcs.day_of_week,
                    fcs.start_time,
                    fcs.end_time
                FROM faculty_Course_Schedule fcs
                JOIN faculty_courses fc ON fcs.faculty_course_id = fc.faculty_course_id
                JOIN rooms r ON fcs.room_id = r.room_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            schedules.Add(new facultyCourseSchedule
                            {
                                ScheduleId = reader.GetInt32(0),
                                FacultyCourseId = reader.GetInt32(1),
                                RoomId = reader.GetInt32(2),
                                DayOfWeek = reader.GetString(3),
                                StartTime = reader.GetTimeSpan(4),
                                EndTime = reader.GetTimeSpan(5)

                            });
                        }

                    }
                }
            }
            return schedules;
        }

        public facultyCourseSchedule GetScheduleById(int id)
        {
            string query = "SELECT * FROM faculty_Course_Schedule WHERE schedule_id = @ScheduleId";
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ScheduleId", id);  // Missing parameter added

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new facultyCourseSchedule
                            {
                                ScheduleId = reader.GetInt32(0),
                                FacultyCourseId = reader.GetInt32(1),
                                RoomId = reader.GetInt32(2),
                                DayOfWeek = reader.GetString(3),
                                StartTime = reader.GetTimeSpan(4),
                                EndTime = reader.GetTimeSpan(5)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool UpdateSchedule(int scheduleId, int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            // Check if there is a time conflict
            if (IsTimeConflictForUpdate(scheduleId, roomId, dayOfWeek, startTime, endTime))
            {
                Console.WriteLine("Error: Time conflict detected! The room is already occupied at this time.");
                return false; // Prevent update
            }

            string query = @"
        UPDATE faculty_Course_Schedule 
        SET faculty_course_id = @FacultyCourseId, 
            room_id = @RoomId, 
            day_of_week = @DayOfWeek, 
            start_time = @StartTime, 
            end_time = @EndTime 
        WHERE schedule_id = @ScheduleId";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FacultyCourseId", facultyCourseId);
                    cmd.Parameters.AddWithValue("@RoomId", roomId);
                    cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);
                    cmd.Parameters.AddWithValue("@ScheduleId", scheduleId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        private bool IsTimeConflictForUpdate(int scheduleId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            string query = @"
        SELECT COUNT(*) FROM faculty_Course_Schedule 
        WHERE room_id = @RoomId 
        AND day_of_week = @DayOfWeek 
        AND schedule_id != @ScheduleId  -- Exclude the current schedule being updated
        AND (
            (@StartTime >= start_time AND @StartTime < end_time) OR 
            (@EndTime > start_time AND @EndTime <= end_time) OR      
            (@StartTime <= start_time AND @EndTime >= end_time)      
        )";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ScheduleId", scheduleId);
                    cmd.Parameters.AddWithValue("@RoomId", roomId);
                    cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // If count > 0, a conflict exists
                }
            }
        }



        public bool DeleteSchedule(int id)
        {
            string query = "DELETE FROM faculty_Course_Schedule WHERE schedule_id = @ScheduleId";
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ScheduleId", id); 
                    return cmd.ExecuteNonQuery() > 0; 
                }
            }
        }
    }
}
