using Challenge_4__Outlings__Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Challenge_4__Outings__UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShowAllOutings_BooleanShouldReturnTrue()
        {
            OutingsDetails content = new OutingsDetails();
            OutingsDetailsRepository repository = new OutingsDetailsRepository();
            repository.AddOutingsDetails(content);
            List<OutingsDetails> outingsList = repository.GetDetails();
            bool listHasOutings = outingsList.Contains(content);
            Assert.IsTrue(listHasOutings);
        }
        [TestMethod]
        public void AddOuting_BooleanShouldReturnTrue()
        {
            OutingsDetails content = new OutingsDetails();
            OutingsDetailsRepository repository = new OutingsDetailsRepository();
            bool addOuting = repository.AddOutingsDetails(content);
            Assert.IsTrue(addOuting);
            System.Console.WriteLine(addOuting);
        }
    }
}
