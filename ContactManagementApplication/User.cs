using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Management_Application
{
    public class User
    {
        public enum Gender{  
            male, female
        }
        public int Id { get; set; }
        private string firstName;
        public void setFirstName(string fname)
        {
            this.firstName = fname;
        }
        public string getFirstname()
        {
            return firstName;
        }


        private string lastname;
        public void setLastName(string lname)
        {
            this.lastname = lname;           
        }
        public string getLastname()
        {
            return lastname;
        }


        public Gender gender
        {
            set
            {
                this.gender = value;
            }
            get
            {
                return this.gender;
            }
        }
        private string City;
        public void setCity(string city)
        {
            this.City = city;
        }
        public string getCity()
        {
            return City; ;
        }
        public DateOnly AddedDate { get; set; }

        List<Address> address;
        List<Phone> phone;
        List<Email> email;
        public int Search()
        {
            if (getFirstname() != null || getLastname() != null || City != null || gender != Gender.male || gender != Gender.female
                || address != null || phone != null || email != null)
            {
                return 1;
            }
            else
                return 0;
        }
      
        public void AddPhone()
        {
            Phone _phone = new Phone();
            Console.WriteLine("enter the phone number");
            string phonenum = Console.ReadLine();
            _phone.setPhone(phonenum);
            Console.WriteLine("enter the type");
            string type = Console.ReadLine();
            _phone.setType(type);
            Console.WriteLine("enter the description");
            string des = Console.ReadLine();
            _phone.setDescription(des);
            phone.Add(_phone);
            Console.WriteLine("Successfully");

        }
       
        public void AddEmail()
        {
            Email _email = new Email();
            Console.WriteLine("enter Email");
            string email_ = Console.ReadLine();
            _email.setEmail(email_);
            Console.WriteLine("enter the type");
            string type = Console.ReadLine();
            _email.setType(type);
            Console.WriteLine("enter the description");
            string des = Console.ReadLine();
            _email.setDescription(des);
            email.Add(_email);
            Console.WriteLine("Successfully");
        }
        
        public void AddAddress()
        {
            Address _address = new Address();
            Console.WriteLine("enter Place");
            string place = Console.ReadLine();
            _address.setPlace(place);
            Console.WriteLine("enter the type");
            string type = Console.ReadLine();
            _address.setType(type);
            Console.WriteLine("enter the description");
            string des = Console.ReadLine();
            _address.setDescription(des);
            address.Add(_address);
            Console.WriteLine("Successfully");
        }



        public void EditPhoneNumber(Phone _phone)
        {
            //Console.WriteLine("enter the phone number");
            //string phonenum = Console.ReadLine();
            //_phone.setPhone(phonenum);
            //Console.WriteLine("enter the type");
            //string type = Console.ReadLine();
            //_phone.setType(type);
            //Console.WriteLine("enter the description");
            //string des = Console.ReadLine();
            //_phone.setDescription(des);
            //Console.WriteLine("Successfully");
            phone.Remove(_phone);
            AddPhone();


        }
        public void EditAddress(Address _address)
        {
            //Address _address = new Address();
            //Console.WriteLine("enter Place");
            //string place = Console.ReadLine();
            //_address.setPlace(place);
            //Console.WriteLine("enter the type");
            //string type = Console.ReadLine();
            //_address.setType(type);
            //Console.WriteLine("enter the description");
            //string des = Console.ReadLine();
            //_address.setDescription(des);
            //Console.WriteLine("Successfully");
            address.Remove(_address);
            AddAddress();


        }
        public void EditEmail(Email _email)
        {
            //Console.WriteLine("enter Email");
            //string email_ = Console.ReadLine();
            //_email.setEmail(email_);
            //Console.WriteLine("enter the type");
            //string type = Console.ReadLine();
            //_email.setType(type);
            //Console.WriteLine("enter the description");
            //string des = Console.ReadLine();
            //_email.setDescription(des);
           
            //Console.WriteLine("Successfully");
            email.Remove(_email);
            AddEmail();
        }





        public void DeleteAddress(Address _address)
        {
            address.Remove(_address);
        }
        public void DeletePhone(Phone _phone)
        {
            phone.Remove(_phone);
        }

        public void DeleteEmail(Email _email)
        {
            email.Remove(_email);  
        }




        public override string ToString() 
        {
            string addressString = string.Join(", ", address);
            string phoneString = string.Join(", ", phone);
            string emailString = string.Join(", ", email);

            return $"ID: {Id}\n" +
                   $"Name: {getFirstname()} {getLastname()}\n" +
                   $"Gender: {gender}\n" +
                   $"City: {City}\n" +
                   $"Added Date: {AddedDate.ToString("yyyy-MM-dd")}\n" +
                   $"Address: {addressString}\n" +
                   $"Phone: {phoneString}\n" +
                   $"Email: {emailString}";
        }

    }
}
