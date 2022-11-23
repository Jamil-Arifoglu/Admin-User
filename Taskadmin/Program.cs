using System.ComponentModel;

namespace Taskadmin
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Admin admin = new Admin(true, "Blog", "", "");

            admin.ShowDatainfo();
        }
    }
}