using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2__Claims__Library
{
    public class ClaimRepository : ClaimDetailsRepository
    {
        public List<ClaimDetails> ShowAllClaims()
        {
            List<ClaimDetails> allClaims = new List<ClaimDetails>();
            foreach (ClaimDetails content in _claimDetails)
            {
                if (content is ClaimDetails)
                {
                    allClaims.Add((ClaimDetails)content);
                }                
            }
            return allClaims;
        }
    }
}
