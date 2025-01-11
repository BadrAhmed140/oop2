using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace opp2
{



    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class HireDate
    {
        public int Day { get;  set; }
        public int Month { get;  set; }
        public int Year { get;  set; }



        public HireDate(int day, int month, int year)
        {


            Day = day;
            Month = month;
            Year = year;
        }


        public override string ToString() { 
        return $"{Year:D4}-{Month:D2}-{Day:D2}";
        }
    }


    internal class Q1
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HireDate HireDate { get; set; }
        private string gender;
        public string Gender
        {
            get  { return gender; }
             set
            {
                if (value == "M" || value == "F"|| value == "m" || value == "f")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' (Male) or 'F' (Female).");
                }
            }
        }

        public Q1 (int id,string name , SecurityLevel secsecurityLevel, double salary ,HireDate hireDate,string gender)
        {
            Id = id;    
            Name = name;
            SecurityLevel = secsecurityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;

        }

        public override string ToString()
        {
            return $"Employee ID: {Id}\n" +
              $"Name: {Name}\n" +
              $"Security Level: {SecurityLevel}\n" +
              $"Salary: {Salary}\n" +
              $"Hire Date: {HireDate:yyyy-MM-dd}\n" +
              $"Gender: {Gender}";
        }

    }
}
