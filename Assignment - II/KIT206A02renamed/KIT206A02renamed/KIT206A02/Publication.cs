using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAP;
using RAP.Research;
using RAP.Database;
using RAP.Control;


namespace RAP
{

	public enum OutputType { Conference, Journal, Other };

    public class Publication
    {
        public string Doi { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public int PublicationYear { get; set; }
        public OutputType Type { get; set; }
        public string CiteAs { get; set; }
        public DateTime Available { get; set; }

        //returns the age of the publication
        public int Age()
        {
            var today = DateTime.Today;
            var age = today.Year - PublicationYear;
            return age;
        }
    }
}