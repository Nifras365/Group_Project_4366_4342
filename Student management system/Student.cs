using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RegNo { get; set; }
        public string Mail { get; set; }
        public string DathOfBirth { get; set; }
        public int Age { get; set; }
        public string PhoneNo { get; set; } 
        public string Address { get; set; }
        public string CorseOfStudy { get; set; }

        public Student(string firstName, string lastName, int regNo, string mail, string dathOfBirth, int age, string phoneNo, string address, string corseOfStudy)
        {
            FirstName = firstName;
            LastName = lastName;
            RegNo = regNo;
            Mail = mail;
            DathOfBirth = dathOfBirth;
            Age = age;
            PhoneNo = phoneNo;
            Address = address;
            CorseOfStudy = corseOfStudy;
        }


    }
}
