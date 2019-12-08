using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdminProgram
{
    class User
    {
        public string Name
        {
            get;
            private set;
        }
        
        public string Phone
        {
            get;
            private set;
        }

        public int Age
        {
            get;
            private set;
        }

        public string Sex
        {
            get;
            private set;
        }

        public User(string name, string phone, int age, string sex)
        {
            Name = name;
            Phone = phone;
            Age = age;
            Sex = sex;
        }

        public string GetUserInfo()
        {
            return "Name: " + Name;
        }

        public string GetDetailUserInfo()
        {
            return " Name : " + Name  + " Phone : " + Phone  + " Age :" + Age  + " Sex : " +  Sex; 
        }

    }
}
