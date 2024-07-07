using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Management_Application
{
    public class Phone
    {
        private string PhoneNumber, type, description;

        
        public void setPhone(string _phone)
        {
            this.PhoneNumber = _phone;
        }
        public void setType(string _type)
        {
            this.type = _type;
        }
        public void setDescription(string _description)
        {
            this.description = _description;
        }
        private string getPhoneNumber()
        {
            return this.PhoneNumber;
        }
        private string getType()
        {
            return this.type;
        }
        private string getDescription()
        {
            return description;
        }
        public void getFullPhone()
        {
            Console.WriteLine($"PhoneNumber:{getPhoneNumber}");
            Console.WriteLine($"Type:{getType}");
            Console.WriteLine($"Description:{getDescription}");
        }

    }
}
