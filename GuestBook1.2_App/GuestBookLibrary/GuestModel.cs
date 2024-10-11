using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary
{
    public class GuestModel
    {
        public string FirstName { private get; set; }
        public string LastName { private get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string MessageToHost { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age => DateTime.Now.Year - BirthDate.Year;

        public GuestModel(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
