using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Project
    {
        public int ProjectId { get; set; }    // Primary Key, Auto-increment
        public string Title { get; set; }     // Project Title
        public string Description { get; set; } // Nullable Text Field
        public Project() { }
        // Constructor for Data Retrieval (Includes ID)
        public Project(int projectId, string title, string description)
        {
            ProjectId = projectId;
            Title = title;
            Description = description;
        }
       
        // Constructor for Data Adding (Excludes ID)
        public Project(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
