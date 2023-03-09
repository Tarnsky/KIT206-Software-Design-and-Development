using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAP.Database;
using RAP.Research;
using RAP.Control;
using RAP;


namespace RAP.Control
{
    public static class PublicationsController
    {
        public static List<string> PublicationYears { get; set; }
        public static Publication Publications { get; set; }
        public static bool Sort { get; set; }



        public static List<Publication> LoadPublication()
        {
            Researcher researcher = ResearcherController.CurrentResearcher;
            Sort = true;

            if (researcher != null)
            {
                PublicationYears = Enumerable.Range(researcher.EarliestStart.Year, DateTime.Today.Year - (researcher.EarliestStart.Year - 1)).Select(n => n.ToString()).ToList();

                return researcher.PublicationsCount();
            }

            return null;

        }
    }
}
