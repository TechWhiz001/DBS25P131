using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class FacultyRequest
    {
        public int RequestId { get; set; }
        public Faculty Faculty { get; set; }  // Foreign key (faculty_id from Faculty table)
        public Consumables Item { get; set; }  // Foreign key (item_id from Consumables table)
        public int Quantity { get; set; }
        public Lookup Status { get; set; }  // Foreign key (status_id from Lookup table)
        public DateTime RequestDate { get; set; }

        public FacultyRequest() 
        { }

        public FacultyRequest(int requestId, Faculty faculty, Consumables item, int quantity, Lookup status, DateTime requestDate)
        {
            RequestId = requestId;
            Faculty = faculty;
            Item = item;
            Quantity = quantity;
            Status = status;
            RequestDate = requestDate;
        }
    }
}