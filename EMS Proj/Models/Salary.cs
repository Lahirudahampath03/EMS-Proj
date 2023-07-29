using System.ComponentModel.DataAnnotations;

namespace EMS_Proj.Models
{
    public class Salary
    {
        [Key]
        public int SalID { get; set; }

        public int EmpID { get; set; }

        public string Amount { get; set; }

        public string Effectivedate { get; set; }
 


    }
}
