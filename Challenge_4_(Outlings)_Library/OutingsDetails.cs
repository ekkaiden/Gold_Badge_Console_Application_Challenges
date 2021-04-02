using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4__Outlings__Library
{
    public enum EventType { Golf, Bowling, AmusementPark, Concert}
    public class OutingsDetails
    {
        public EventType EventType { get; set; }
        public int NumAttend { get; set; }
        public DateTime DateAttend { get; set; }
        public double IndCost { get; set; }
        public double TotCost { get; set; }
        
    
    public OutingsDetails()
    {

    }
    public OutingsDetails(EventType eventType, int numAttend, DateTime dateAttend, double indCost, double totCost)
    {
        EventType = eventType;
        NumAttend = numAttend;
        DateAttend = dateAttend;
        IndCost = indCost;
        TotCost = totCost;
    }

        public static explicit operator OutingsDetails(double v)
        {
            throw new NotImplementedException();
        }
    }
}

