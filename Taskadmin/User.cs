using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Taskadmin
{
    internal class User
    {
        private  string _username;
        private protected string Username;
        private  string _password;
        private protected string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }

        public void Showdata()
        {
            Console.Write("Username: ");
            string userr = Console.ReadLine();
            Username = userr;
            if (userr.Length > 6)
            {
                Passwword();
                _username = userr;
            }
            else
            {
                Console.WriteLine("Yeniden Daxil Edin");
                Showdata();
            }
        }
        public void Passwword()
        {
            Console.Write("Password: ");
            string pin = Console.ReadLine();
            Password = pin;

            if (pin == pin.ToLower())
            {
                Console.WriteLine("Set again Password");
                Passwword();
            }
            else
            {
                _password = pin;
            }




        }



    }
}

