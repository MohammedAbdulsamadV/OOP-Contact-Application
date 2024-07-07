using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Management_Application
{
    public class Email
    {
        private string email, type, description;
        public void setEmail(string _email)
        {
            this.email = _email;
        }
        private string getEmail() {
            return this.email;
        }
        public void setType(string _type)
        {
            this.type = _type;
        }
        private string getType()
        {
            return this.type;
        }
        public void setDescription(string _description) {
            this.description = _description;
        }
        private string getDescription()
        {
            return this.description;
        }
        public void getFullEmailInfo()
        {
            Console.WriteLine($"Email:{getEmail}");
            Console.WriteLine($"Type:{getType}");
            Console.WriteLine($"Description:{getDescription}");
        }
    }
}
