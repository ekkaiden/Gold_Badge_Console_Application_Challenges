using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2__Claims__Library
{
    public enum ClaimType { Car, Home, Theft }
    public enum IsValid { Valid, Invalid }
    public class ClaimDetails
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfAccident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public IsValid IsValid { get; set; }
        public bool ClaimIsValid
        {
            get
            {
                switch (IsValid)
                {
                    case IsValid.Valid:
                        return true;
                    case IsValid.Invalid:
                        return false;
                }
                if ((int)IsValid > 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public ClaimDetails()
        {

        }
        public ClaimDetails(int claimid, ClaimType claimType, string description, double amount, DateTime dateOfAccident, DateTime dateOfClaim, IsValid isValid)
        {
            ClaimID = claimid;
            ClaimType = claimType;
            Description = description;
            Amount = amount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
