using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DBS25P131.Models;

namespace DBS25P131.DataAccessLayer
{
    public class FacultyRequestDAL
    {
        public List<FacultyRequest> GetAllFacultyRequests()
        {
            List<FacultyRequest> requests = new List<FacultyRequest>();
            string query = @"
                SELECT fr.request_id, fr.quantity, fr.request_date, 
                       f.faculty_id, f.name AS faculty_name, 
                       C.Consumable_id, C.item_name, 
                       l.lookup_id AS status_id, l.category, l.value AS status_value
                FROM faculty_requests fr
                LEFT JOIN faculty f ON fr.faculty_id = f.faculty_id
                LEFT JOIN Consumables C ON fr.item_id = C.Consumable_id
                LEFT JOIN lookup l ON fr.status_id = l.lookup_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requests.Add(new FacultyRequest
                        {
                            RequestId = Convert.ToInt32(reader["request_id"]),
                            Faculty = new Faculty
                            {
                                FacultyId = Convert.ToInt32(reader["faculty_id"]),
                                Name = reader["faculty_name"].ToString()
                            },
                            Item = new Consumables
                            {
                                ConsumableId = Convert.ToInt32(reader["Consumable_id"]),
                                ItemName = reader["item_name"].ToString()
                            },
                            Quantity = Convert.ToInt32(reader["quantity"]),
                            Status = new Lookup
                            {
                                LookupId = Convert.ToInt32(reader["status_id"]),
                                Category = reader["category"].ToString(),
                                Value = reader["status_value"].ToString()
                            },
                            RequestDate = reader.IsDBNull(reader.GetOrdinal("request_date"))
                                          ? (DateTime?)null
                                          : Convert.ToDateTime(reader["request_date"])
                        });
                    }
                }
            }
            return requests;
        }

        public FacultyRequest GetFacultyRequestById(int requestId)
        {
            FacultyRequest request = null;
            string query = @"
                SELECT fr.request_id, fr.quantity, fr.request_date, 
                       f.faculty_id, f.name AS faculty_name, 
                       C.Consumable_id, C.item_name, 
                       l.lookup_id AS status_id, l.category, l.value AS status_value
                FROM faculty_requests fr
                LEFT JOIN faculty f ON fr.faculty_id = f.faculty_id
                LEFT JOIN Consumables C ON fr.item_id = C.Consumable_id
                LEFT JOIN lookup l ON fr.status_id = l.lookup_id
                WHERE fr.request_id = @request_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@request_id", requestId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            request = new FacultyRequest
                            {
                                RequestId = Convert.ToInt32(reader["request_id"]),
                                Faculty = new Faculty
                                {
                                    FacultyId = Convert.ToInt32(reader["faculty_id"]),
                                    Name = reader["faculty_name"].ToString()
                                },
                                Item = new Consumables
                                {
                                    ConsumableId = Convert.ToInt32(reader["Consumable_id"]),
                                    ItemName = reader["item_name"].ToString()
                                },
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                Status = new Lookup
                                {
                                    LookupId = Convert.ToInt32(reader["status_id"]),
                                    Category = reader["category"].ToString(),
                                    Value = reader["status_value"].ToString()
                                },
                                RequestDate = reader.IsDBNull(reader.GetOrdinal("request_date"))
              ? (DateTime?)null
              : Convert.ToDateTime(reader["request_date"])

                            };
                        }
                    }
                }
            }
            return request;
        }

        public bool InsertFacultyRequest(int fid, int itemid, int quan, int name, string date)
        {
            string query = @"INSERT INTO faculty_requests (faculty_id, item_id, quantity, status_id, request_date)
                             VALUES (@faculty_id, @item_id, @quantity, @status_id, @request_date)";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@faculty_id", fid);
                    command.Parameters.AddWithValue("@item_id", itemid);
                    command.Parameters.AddWithValue("@quantity", quan);
                    command.Parameters.AddWithValue("@status_id", name);
                    command.Parameters.AddWithValue("@request_date", date);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateFacultyRequest(FacultyRequest request)
        {
            string query = @"UPDATE faculty_requests 
                             SET faculty_id = @faculty_id, item_id = @item_id, quantity = @quantity, 
                                 status_id = @status_id, request_date = @request_date
                             WHERE request_id = @request_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@faculty_id", request.Faculty.FacultyId);
                    command.Parameters.AddWithValue("@item_id", request.Item.ConsumableId);
                    command.Parameters.AddWithValue("@quantity", request.Quantity);
                    command.Parameters.AddWithValue("@status_id", request.Status.LookupId);
                    command.Parameters.AddWithValue("@request_date", request.RequestDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@request_id", request.RequestId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateFacultyRequestStatus(int requestId, int statusId)
        {
            string query = @"UPDATE faculty_requests SET status_id = @status_id WHERE request_id = @request_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@status_id", statusId);
                    command.Parameters.AddWithValue("@request_id", requestId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public List<FacultyRequest> GetRequestsByFacultyId(int facultyId)
        {
            List<FacultyRequest> requests = new List<FacultyRequest>();
            string query = @"
        SELECT fr.request_id, fr.quantity, fr.request_date, 
               f.faculty_id, f.name AS faculty_name, 
               c.Consumable_id, c.item_name, 
               l.lookup_id AS status_id, l.category, l.value AS status_value
        FROM faculty_requests fr
        LEFT JOIN faculty f ON fr.faculty_id = f.faculty_id
        LEFT JOIN Consumables c ON fr.item_id = c.Consumable_id
        LEFT JOIN lookup l ON fr.status_id = l.lookup_id
        WHERE fr.faculty_id = @faculty_id";  // Filter by faculty ID

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@faculty_id", facultyId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            requests.Add(new FacultyRequest
                            {
                                RequestId = Convert.ToInt32(reader["request_id"]),
                                Faculty = new Faculty
                                {
                                    FacultyId = Convert.ToInt32(reader["faculty_id"]),
                                    Name = reader["faculty_name"].ToString()
                                },
                                Item = new Consumables
                                {
                                    ConsumableId = Convert.ToInt32(reader["Consumable_id"]),
                                    ItemName = reader["item_name"].ToString()
                                },
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                Status = new Lookup
                                {
                                    LookupId = Convert.ToInt32(reader["status_id"]),
                                    Category = reader["category"].ToString(),
                                    Value = reader["status_value"].ToString()
                                },
                                RequestDate = reader.IsDBNull(reader.GetOrdinal("request_date"))
                                              ? (DateTime?)null
                                              : Convert.ToDateTime(reader["request_date"])
                            });
                        }
                    }
                }
            }
            return requests;
        }


        public bool DeleteFacultyRequest(int requestId)
        {
            string query = "DELETE FROM faculty_requests WHERE request_id = @request_id";

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@request_id", requestId);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
