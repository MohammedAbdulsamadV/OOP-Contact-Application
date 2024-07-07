using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Management_Application
{
    public class Address
    {
        private string place,type,description;
        public void setPlace(string _place)
        {
            this.place = _place;
        }
        public void setType(string _type)
        {
            this.type = _type;
        }
        public void setDescription(string _description)
        {
            this.description = _description;
        }
        private string getPlace() {
            return this.place;
        }
        private string getType()
        {
            return this.type;
        }
        private string getDescription()
        {
            return this.description;
        }
        public void getFullAddressInfo()
        {
            Console.WriteLine($"Place:{getPlace}");
            Console.WriteLine($"Type:{getType}");
            Console.WriteLine($"Description:{getDescription}");
        }




    }
}
