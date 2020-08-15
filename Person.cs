

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Person
    {
        //class variables
        public String name;
        public String address;
        public String phone;
        public String email;

        //getters and setters for class variables
        public void setName(String name) { 

            this.name = name; 
        }
        public String getName() { 

            return name; 
        }

        public void setAddress(String address) { 
            
            this.address = address; 
        }
        public String getAddress() {
            
            return address; 
        }

        public void setPhone(String phone) { 
            
            this.phone = phone; 
        }
        public String getPhone() { 
            
            return phone;
        }

        public void setEmail(String email) { 
            
            this.email = email; 
        }
        public String getEmail() { 
            
            return email; 
        }

        public virtual void Display()//make display method virtual
        {
            Console.WriteLine("Student Name=" + getName());
            Console.WriteLine("Address=" + getAddress());
            Console.WriteLine("Phone=" + getPhone());
            Console.WriteLine("Email=" + getEmail());
        }
    }
}
