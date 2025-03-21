using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Project
    {
        public int ProjectId { get; set; }   
        public string Title { get; set; }     
        public string Description { get; set; }
        public Project() { }
        
        public Project(int projectId, string title, string description)
        {
            ProjectId = projectId;
            Title = title;
            Description = description;
        }
       
        
        public Project(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
