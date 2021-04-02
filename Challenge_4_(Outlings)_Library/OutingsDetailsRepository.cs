using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4__Outlings__Library
{
    public class OutingsDetailsRepository
    {
        public readonly List<OutingsDetails> _outingsDetails = new List<OutingsDetails>();
        public readonly List<OutingsDetails> _indOutingsDetails = new List<OutingsDetails>();
        public bool AddOutingsDetails(OutingsDetails content)
        {
            int startingCount = _outingsDetails.Count;
            _outingsDetails.Add(content);
            bool wasAdded = (_outingsDetails.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public List<OutingsDetails> GetDetails()
        {
            return _outingsDetails;
        }
        public bool AddIndCost(OutingsDetails content)
        {
            double totalCount = _indOutingsDetails.Count;
            int totalCountBool;
            totalCountBool = System.Convert.ToInt32(totalCount);
            double indCost = content.IndCost;
            _indOutingsDetails.Add((OutingsDetails)indCost);
            //double totalIndCost = (_indOutingsDetails = totalCountBool) ? true : false;
            //bool totalIndCostBool;
            //totalIndCostBool = System.Convert.ToBoolean(totalIndCost);
            bool indCostBool;
            indCostBool = System.Convert.ToBoolean(indCost);
            return indCostBool;
        }
        public List<OutingsDetails> IndTotalDetails()
        {
            return _indOutingsDetails;
        }
    }
}
