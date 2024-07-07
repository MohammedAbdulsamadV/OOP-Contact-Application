using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Management_Application
{
    internal class Contact
    {
        List<User> users;
        public void Add(User user) {  
            users.Add(user); 
        }
        public void Remove(User user)
        {
            users.Remove(user);
        }
        public void Edit(User user)
        {
            User editedUser = user;
            users.Remove(user);
            editedUser.AddAddress();
            editedUser.AddEmail();
            editedUser.AddPhone();
            Console.WriteLine("enter first name");
            string fn= Console.ReadLine();
            editedUser.setFirstName(fn);
            Console.WriteLine("enter last name");
            string ln = Console.ReadLine();
            editedUser.setFirstName(ln);
            Console.WriteLine("enter city");
            string city = Console.ReadLine();
            editedUser.setFirstName(city);
            Add(editedUser);



        }

        public void ShowUsers(List<User> users) {
            foreach (var item in users)
            {
                item.ToString();
            }
        }

        public int countusers()
        {
            int count = 0;
            foreach (var item in users)
            {
                count++;
            }
            return count;
        }

    }
}