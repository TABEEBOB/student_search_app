
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Student : Person
    {
      //global variables.
        
        private string major;
        private string gpa;

        public Student()//no argument constructor. set all variables to empty string
        {
            name = "";
            address = "";
            phone = "";
            email = "";
            major = "";
            gpa = "";

        }
        //constructor with 6 argument
        public Student(string name, string address, string phone, string email, string major, string gpa)
        {
            this.name = name;
            this. address = address;
            this.phone = phone;
            this.email = email;
            this. major = major;
            this.gpa = gpa;

        }

        //getter and setter for all variables.
        
        public string getMajor() { return major; }
        public void setMajor(string major) {this.major = major; }

        public string getGPA() { return gpa; }
        public void setGPA(string gpa) {this.gpa = gpa; }

        //display() method
        


    }
}
