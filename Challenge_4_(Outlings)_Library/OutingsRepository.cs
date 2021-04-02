using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4__Outlings__Library
{
    public class OutingsRepository: OutingsDetailsRepository
    {
        private List<OutingsDetails> GetOutingsDetails()
        {
            List<OutingsDetails> allOutings = new List<OutingsDetails>();
            foreach (OutingsDetails content in _outingsDetails)
            {
                if (content is OutingsDetails)
                {
                    allOutings.Add(content as OutingsDetails);
                }
            }
            return allOutings;
        }
        private List<OutingsDetails> GetIndCost()
        {
            List<OutingsDetails> allIndCost = new List<OutingsDetails>();
            foreach (OutingsDetails content in _indOutingsDetails)
            {
                if (content is OutingsDetails)
                {
                    double indCost = content.IndCost;
                    allIndCost.Add((OutingsDetails)indCost);
                }
            }
            return allIndCost;
        }
    }
}
