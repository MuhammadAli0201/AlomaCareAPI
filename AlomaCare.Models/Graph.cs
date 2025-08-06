using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlomaCare.Models
{
    public class Graph
    {
        public string Label { get; set; }
        public int Count { get; set; }
        public double Percentage { get; set; }
    }

    public class GraphDashboard
    {
        public List<Graph> Outcome { get; set; }
        public List<Graph> Weight { get; set; }
        public List<Graph> Sepsis { get; set; }
        public List<Graph> HieGraph { get; set; }
        // public List<Graph> CongenitalInfection { get; set; }
        //  public List<Graph> CongenitalOrganisms { get; set; }
        // public List<Graph> EarlySepsisOrganisms { get; set; }
        // public List<Graph> FungalSepsisPresence { get; set; }
        // public List<Graph> FungalOrganisms { get; set; }
    }
}
