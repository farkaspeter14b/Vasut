using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VasutRendszer.Classes
{
    public class UserHelper
    {
        public string filename = "users.txt";
        public List<User> Users = new List<User>();
        public UserHelper()
        {
            ReadAll();
        }
        public void ReadAll()
        {
            StreamReader read = new StreamReader(filename);
            while (!read.EndOfStream)
            {
                string[] sor = read.ReadLine().Split(';');
                User u = new User();
                u.name = sor[0];
                u.password = sor[1];
                Users.Add(u);
            }
            read.Close();
        }
        public bool AddUser(string name, string password) 
        {
            bool vane = false;
            foreach (User item in Users)
            {
                if (name == item.name)
                {
                    vane = true;
                }
            }
            if (vane == false)
            {
                User u = new User();
                u.name = name;
                u.password = password;
                Users.Add(u);
                StreamWriter write = new StreamWriter(filename, true);
                write.WriteLine(u.name + ";" + u.password);
                write.Close();
                return true;
            }
            return false;
        }
        public bool SearchUser(string name, string password)
        {
            foreach (User item in Users)
            {
                if (name == item.name && password == item.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
