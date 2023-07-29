using System.ComponentModel.DataAnnotations;

namespace EMS_Proj.Models
{
    public class Account
    {
        [Key]
        
        public int UID { get; set; }
      
        public string Uname { get; set; }

        public string Password { get; set;}
   
    }

    public class LoginViewModel

    {
        




    }
}
