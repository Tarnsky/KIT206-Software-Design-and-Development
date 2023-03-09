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
    //As an example, this includes an additional 'EmploymentLevel' called Any that could be used in a GUI drop-down list.
    public enum EmploymentLevel { Student, A, B, C, D, E };

    public class Staff
    {

        public float ThreeYearAverage()
        {
            int publicationsTally = 0; //tally for publications of last three years

            if (PublicationYear = Today.year || Today.year - 1 || Today.year - 2) //detects if publication year is within last three years
            {
                publicationsTally++;
            }

            publicationsTally / 3;
            return publicationsTally;
        }

        //Researchers ThreeYearAverage is divided by their employment level to calcute and return their performance
        public float Performance()
        {

            float performacnelevel = 0.0;
            float testing = ThreeYearAverage() / EmploymentLevel;

            return testing;
        }
    }
}