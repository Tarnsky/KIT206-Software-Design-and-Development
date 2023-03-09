using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAP.Research;
using RAP.Database;
using RAP.Control;
using RAP;


namespace RAP.Research
{
    
    public class Position
    {
        public EmploymentLevel Level { get; set; }  
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        //Title will return the persons title eg: "DR, Miss"
        public string Title()
        {
            return "DR";
        }
//ToTile will return the name of thier employment based on thier level
        public string ToTitle(EmploymentLevel Level)
        {
            switch(Level)
            {
                case EmploymentLevel.Student:
                    return "Student";

                case EmploymentLevel.A:
                    return "Postdoc";

                case EmploymentLevel.B:
                    return "Lecturer";

                case EmploymentLevel.C:
                    return "Senior Lecturer";

                case EmploymentLevel.D:
                    return "Associate Professor";

                case EmploymentLevel.E:
                    return "Professor";

                default:
                    return "NA";


            }

        }
    }
}
