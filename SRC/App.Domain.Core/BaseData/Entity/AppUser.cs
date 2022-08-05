using Microsoft.AspNetCore.Identity;
namespace App.Domain.Core.BaseData.Entity
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Isactive { get; set; }
        public DateTime CreatedAt { get; set; }

        //public AppUser(string x)
        //{
        //     UserName = x;
        //     FirstName = x;
        //     LastName = x;
        //     Isactive = true;
        //     CreatedAt = DateTime.Now;
        //}
        //public AppUser()
        //{
        //    Email="a@Gmail"

        //}

    }

  

   
}
