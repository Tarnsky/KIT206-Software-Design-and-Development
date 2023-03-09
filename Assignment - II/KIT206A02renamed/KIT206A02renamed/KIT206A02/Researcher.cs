using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAP.Control;
using RAP.Research;
using RAP.Database;
using RAP;




namespace RAP.Research
{
    // enumerations for the campus and level variables
    public enum Placement { Any, Student, Staff };

    public class Researcher
    {
        // getters and setters for the researcher class
        public int ID { get; set; }
        public string GivenName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
        public string Campus { get; set; }
        public string Email { get; set; }
        public string PhotoURL { get; set; } 
        public string Degree { get; set; }
        public Type Type { get; set; }
        public Placement Placement { get; set; }
        public DateTime Start { get; set; }
        public DateTime CurrentStart { get; set; }

        public List<Publication> Work { get; set; }

        //calculate attributes
        //public string GetCurrentJob
        public double Tenure { get { return DateTime.Today.Subtract(EarliestStart).TotalDays / 365.2425; } }

        //public DateTime CurrentJobStart

        // public Position GetEarlistJob


        public DateTime EarliestStart
        {
            get
            {
                var StartDates = from Staff s in Researcher
                                 orderby s.Start descending
                                 select s.Start;
                return StartDates.First();
            }
        }
        public int PublicationsCount
        {
            get { return Work == null ? 0 : Work.Count(); }
        }
    }
}
        

