using System.ComponentModel.DataAnnotations;

namespace EMS_Proj.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

         public string Title { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Phonenumber { get; set; }

        public int DepartID { get; set; }

         public string salary { get; set; }

        public Jobtitle jobtitle { get; set; }

        public ICollection<Leave> leaves { get; set;}

    }
}
