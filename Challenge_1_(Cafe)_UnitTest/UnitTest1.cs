using Gold_Badge_Console_Application_Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge_1__Cafe__UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddToMenu_ShouldGetCorrectBoolean()
        {
            MenuDetails content = new MenuDetails();
            MenuDetailsRepository repository = new MenuDetailsRepository();
            bool addResult = repository.AddMenuDetails(content);
            Assert.IsTrue(addResult);
            Console.WriteLine(addResult);
        }
        [TestMethod]
        public void GetMenu_ShouldReturnCorrectCollection()
        {
            MenuDetails content = new MenuDetails();
            MenuDetailsRepository repo = new MenuDetailsRepository();
            repo.AddMenuDetails(content);
            List<MenuDetails> menuList = repo.GetDetails();
            bool menuHasContent = menuList.Contains(content);
            Assert.IsTrue(menuHasContent);
        }
        //private MenuDetailsRepository _repo;
        //[TestMethod]
        //public void RemoveFromMenu_ShouldReturnTrue()
        //{
            //MenuDetails content = _repo.GetDetails();
            //bool removeItem = _repo.RemoveExistingItem(content);
            //Assert.IsTrue(removeItem);
        //}


    }
}