using System.ComponentModel.DataAnnotations;


namespace EMS_Proj.Models
{
    public class Attendance
    {
        [Key]
        public int attenID { get; set; }

       public int EmpID { get; set; }

        public string Checkintime { get; set; }

        public string Checkouttime { get; set; }

        public string Date { get; set; }


    }
}
