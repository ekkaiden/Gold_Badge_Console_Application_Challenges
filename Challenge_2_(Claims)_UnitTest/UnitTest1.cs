using Challenge_2__Claims__Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Challenge_2__Claims__UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNewClaim_ShouldGetCorrectBoolean()
        {
            ClaimDetails content = new ClaimDetails();
            ClaimDetailsRepository repository = new ClaimDetailsRepository();
            bool addClaim = repository.AddClaimDetails(content);
            Assert.IsTrue(addClaim);
            System.Console.WriteLine(addClaim);
        }
        [TestMethod]
        public void ShowAllClaims_ShouldGetCorrectBoolean()
        {
            ClaimDetails content = new ClaimDetails();
            ClaimDetailsRepository repository = new ClaimDetailsRepository();
            repository.AddClaimDetails(content);
            List<ClaimDetails> claimList = repository.GetDetails();
            bool listHasClaims = claimList.Contains(content);
            Assert.IsTrue(listHasClaims);
        }
    }
}
