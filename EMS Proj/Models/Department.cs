using System.ComponentModel.DataAnnotations;

namespace EMS_Proj.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int  MgrID { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }
}
