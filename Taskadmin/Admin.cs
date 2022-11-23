using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskadmin
{  internal class Admin:User
    {


        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string Section, string username, string password) : base(username, password)
        {
            IsSuperAdmin = isSuperAdmin;
           this.Section = Section;
        }

        public void ShowDatainfo()
        {
            Showdata();
            Console.WriteLine(" ");
            Console.WriteLine($" {IsSuperAdmin}: {Section} Username: {Username},  Password: {Password}");
        }


    }

}
