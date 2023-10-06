using CreateDB__EF.AdditionalTools;
using CreateDB__EF.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB__EF.Entities.DerivedEntities
{
    public class Student : IId, IFullname
    {
        public Student(string firstname, string lastname, int schoolNumber, Gender gender, DateTime birthdate, string phoneNumber)
        {
            Firstname = firstname;
            Lastname = lastname;
            SchoolNumber = schoolNumber;
            this.gender = gender;
            Birthdate = birthdate;
            PhoneNumber = phoneNumber;
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int SchoolNumber { get; set; }

        public Gender gender { get; set; }

        public DateTime Birthdate { get; set; }

        public string PhoneNumber { get; set; }
        public int Id { get ; set ; }

        public ICollection<Book> Books { get; set; }
    }
}
