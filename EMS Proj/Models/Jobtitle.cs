using System.ComponentModel.DataAnnotations;

namespace EMS_Proj.Models
{
    public class Jobtitle
    {
        [Key]
        public int JobID { get; set; }

        public string JobTitle { get; set; }

        public string JobDescription { get; set; }


    }
}
