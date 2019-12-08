using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserAdminProgram
{
    class UserManager
    {
        public List<User> Users = new List<User>();
        
        public void CreateUser(User newUser)
        {
            Users.Add(newUser);
        }

        public void EditUser(int editnumber, User newUser)
        {
            Users[editnumber] = newUser;
        }

        public void DeleteUser(int deletenumber)
        {
            Users.RemoveAt(deletenumber);
        }

        public List<User> FindByName(string name)
        {
            int count = 0;
            List<User> findresult = new List<User>();
            foreach(User e in Users)
            {
                if(e.Name == name)
                {
                    findresult.Add(e);
                }
                count++;
            }
            return findresult;
        }

        public void SaveFile(string filename)
        {
            StreamWriter savefile = new StreamWriter(@"C:\Users\tjals\desktop\practice\" + filename + ".txt");
            foreach(User e in Users)
            {
                savefile.WriteLine(e.Name);
                savefile.WriteLine(e.Phone);
                savefile.WriteLine(e.Age);
                savefile.WriteLine(e.Sex);
            }
            savefile.Close();
        }

        public void LoadFile(string filename)
        {
            try
            {
                using (StreamReader loadfile = new StreamReader(@"C:\Users\tjals\desktop\practice\" + filename + ".txt"))
                {
                    string line;
                    while ((line = loadfile.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
           
        }
    }
}
