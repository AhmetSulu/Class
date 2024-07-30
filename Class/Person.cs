using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Tam adını almak için method.
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        // Tam yaşı almak için method.
        public int GetAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if       (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                age -= 1;

            return age;
        }

        // Bilgileri yazdırmak için method.
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {GetFullName()}");
            Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
            Console.WriteLine($"Age: {GetAge()}");
        }
    }
    }
   
