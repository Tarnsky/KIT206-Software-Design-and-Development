
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAP
{
    class Controller
    {
        //The example shown here follows the pattern discussed in the Module 6 summary slides,
        //maintaining two collections, a master and a 'viewable' one (which is the 'view model'
        //in Microsoft's Model-View-ViewModel approach to Model-View-Controller)
        private List<Researcher> staff;
        public List<Researcher> Workers { get { return staff; } set { } }
       
        private ObservableCollection<Researcher> viewableStaff;
        public ObservableCollection<Researcher> VisibleWorkers { get { return viewableStaff; } set { } }

        public Controller()
        {
            staff = ERDAdapter.LoadAll();
            viewableStaff = new ObservableCollection<Researcher>(staff); //this list we will modify later

            //Part of step 2.3.2 from Week 8 tutorial
            foreach (Researcher e in staff)
            {
                e.Degree = ERDAdapter.LoadTrainingSessions(e.ID);
            }
        }

        public ObservableCollection<Researcher> GetViewableList()
        {
            return VisibleWorkers;
        }

        //This version of Filter modifies the viewable list instead of returning a new list,
        //but the procedure is almost the same
        public void Filter(Gender gender)
        {
            var selected = from Researcher e in staff
                           where gender == Gender.Any || e.Gender == gender
                           select e;
            viewableStaff.Clear();            
            //Converts the result of the LINQ expression to a List and then calls viewableStaff.Add with each element of that list in turn
            selected.ToList().ForEach( viewableStaff.Add );
        }
    }
}

