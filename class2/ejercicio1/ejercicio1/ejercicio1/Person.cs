using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; }
        public int Age { 
            get {
                DateTime today = DateTime.Today;
                int age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age))
                    age--;
                return age;
            } 
        }

    }
}
