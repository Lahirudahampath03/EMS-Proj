using System.ComponentModel.DataAnnotations;

namespace EMS_Proj.Models
{
    public class Leave
    {
        [Key]
        public int LeaveID { get; set; }   

         public int EmpID { get; set; }

        public  string Startdate { get; set; }

        public string Enddate { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }


        public Employee Employee { get; set; }

    }
}
