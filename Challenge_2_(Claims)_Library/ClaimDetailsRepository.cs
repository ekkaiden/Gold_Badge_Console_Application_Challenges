using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2__Claims__Library
{
    public class ClaimDetailsRepository
    {
        public readonly List<ClaimDetails> _claimDetails = new List<ClaimDetails>();
        public readonly Queue<ClaimDetails> _queueDetails = new Queue<ClaimDetails>();
        public bool AddClaimDetails(ClaimDetails content)
        {
            int startingCount = _claimDetails.Count;

            _claimDetails.Add(content);

            bool wasAdded = (_claimDetails.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public bool AddQueueDetails(ClaimDetails content)
        {
            int startingCount = _queueDetails.Count;

            _claimDetails.Add(content);

            bool wasAdded = (_queueDetails.Count > startingCount) ? true : false;
            return wasAdded;
        }
        public List<ClaimDetails> GetDetails()
        {
            return _claimDetails;
        }
        public Queue<ClaimDetails> QueueDetails()
        {
            return _queueDetails;
        }
    }
}
