using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Console_Application_Challenges
{
    class MenuUI
    {
        private readonly MenuRepository _menuRepository = new MenuRepository();
        public void Run()
        {
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Welcome to Komodo Cafe! Please enter the number of the option you would like to select:\n" +
                    "1: View Menu\n" +
                    "2: Add Item to Menu\n" +
                    "3: Remove Item From Menu\n" +
                    "4: Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowMenuContents();
                        break;
                    case "2":
                        AddToMenu();
                        break;
                    case "3":
                        RemoveFromMenu();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option\n" +
                            "Press any key to continue....");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void DisplayMenuItem(MenuDetails content)
        {
            Console.WriteLine($"Item Number: {content.Number}\n" +
                $"Item Name: {content.Name}\n" +
                $"Item Description: {content.Description}\n" +
                $"Item Ingredients: {content.Ingredients}\n" +
                $"Item Price: {content.Price}\n");
        }
        private void ShowMenuContents()
        {
            Console.Clear();
            List<MenuDetails> menuList = _menuRepository.GetDetails();
            foreach (MenuDetails content in menuList)
            {
                DisplayMenuItem(content);
            }
            Console.WriteLine("Press any key to return....");
            Console.ReadKey();

        }
        private void AddToMenu()
        {
            Console.Clear();
            MenuDetails content = new MenuDetails();
            Console.WriteLine("Add a menu item here.");
            Console.WriteLine("Please enter a menu number:");
            string numberInput = Console.ReadLine();
            int numberNumber = int.Parse(numberInput);
            content.Number = numberNumber;
            Console.WriteLine("Please enter a name for the item here:");
            content.Name = Console.ReadLine();
            Console.WriteLine("Please enter a description of the item here:");
            content.Description = Console.ReadLine();
            Console.WriteLine("Please enter a list of ingredients in the item here:");
            content.Ingredients = Console.ReadLine();
            Console.WriteLine("Please enter the price of the item here:");
            string priceInput = Console.ReadLine();
            double pricePrice = double.Parse(priceInput);
            content.Price = pricePrice;
            _menuRepository.AddMenuDetails(content);
        }
        private void RemoveFromMenu()
        {
            Console.Clear();
            Console.WriteLine("Which meal item would you like to remove?");
            List<MenuDetails> menuDetails = _menuRepository.GetDetails();
            int count = 0;
            foreach (MenuDetails content in menuDetails)
            {
                count++;
                Console.WriteLine($"{count}. {content.Name}");
            }
            int targetNumber = int.Parse(Console.ReadLine());
            int targetName = targetNumber - 1;
            if(targetName >= 0 && targetName < menuDetails.Count)
            {
                MenuDetails expectedItem = menuDetails[targetName];
                if (_menuRepository.RemoveExistingItem(expectedItem))
                {
                    Console.WriteLine($"{expectedItem.Name} was removed successfully.");
                }
                else
                {
                    Console.WriteLine("The expected item was unable to be located and removed.");
                }
            }
        }
    }
}
