using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAP.Database;
using RAP.Research;
using RAP.Control;
using RAP;


namespace RAP.Control
{
    public static class ResearcherController
    {
        public static List<Researcher> Researchers { get; set; }
        public static Researcher CurrentResearcher { get; set; }
        

        public static List<Researcher> LoadResearcher()
        {
            Researchers = ERDAdapter.FetchBasicResearcher();
            return Researchers;
        }

    }
}
