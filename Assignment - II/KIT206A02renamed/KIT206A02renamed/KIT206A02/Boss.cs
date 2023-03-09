using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAP.Research;
using RAP.Database;
using RAP.Control;
using RAP;

namespace RAP
{
    class Boss
    {

        private List<Researcher> staff;
        public List<Researcher> Workers { get { return staff; } set { } }

        private ObservableCollection<Researcher> viewableStaff;
        public ObservableCollection<Researcher> VisibleWorkers { get { return viewableStaff; } set { } }

        public Boss()
        {
            staff = ERDAdapter.FetchBasicResearcher();
            viewableStaff = new ObservableCollection<Researcher>(staff); //this list we will modify later

            //Part of step 2.3.2 from Week 8 tutorial
            foreach (Researcher e in staff)
            {
                e.Work = ERDAdapter.FetchBasicPublication(e.ID);
            }
        }

        public ObservableCollection<Researcher> GetViewableList()
        {
            return VisibleWorkers;
        }


        public void Filter(Researcher type)
        {
            var selected = from Researcher e in viewableStaff
                           select type;
            viewableStaff.Clear();
            selected.ToList().ForEach(viewableStaff.Add);
        }
        public void FilterName(Researcher GivenName)
        {
            var selected = from Researcher e in viewableStaff
                           select GivenName;
            viewableStaff.Clear();
            selected.ToList().ForEach(viewableStaff.Add);
        }

    }
}
