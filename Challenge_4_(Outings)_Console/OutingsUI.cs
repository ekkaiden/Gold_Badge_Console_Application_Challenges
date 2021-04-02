using Challenge_4__Outlings__Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4__Outings__Console
{
    class OutingsUI
    {
        private readonly OutingsRepository _outingsRepository = new OutingsRepository();
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
                Console.WriteLine("Welcome to Komodo Company Outings! Please enter the number of the option you would like to select:\n" +
                    "1: View all Outings\n" +
                    "2: Add a New Outing\n" +
                    "3: View Total Outing Cost\n" +
                    "4: View Total Outing Cost by Type\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllOutings();
                        break;
                    case "2":
                        AddOuting();
                        break;
                    case "3":
                        OutingTotalCost();
                        break;
                    case "4":
                        TotalOutingByType();
                        break;
                    default:
                        Console.WriteLine("Please select a valid option\n" +
                            "Press any key to continue.......\n");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void ShowAllOutings()
        {
            Console.Clear();
            List<OutingsDetails> outingsList = _outingsRepository.GetDetails();
            foreach (OutingsDetails content in outingsList)
            {
                DisplayOuting(content);
            }
            Console.WriteLine("Press any key to return....");
            Console.ReadKey();
        }
        private void DisplayOuting(OutingsDetails content)
        {
            Console.WriteLine($"Event Type: {content.EventType}\n" +
                $"Number of Attendants: {content.NumAttend}\n" +
                $"Date of Event: {content.DateAttend}\n" +
                $"Total Cost per Person for the Event: {content.IndCost}\n" +
                $"Total Cost for the Event: {content.TotCost}\n");
        }
        private void AddOuting()
        {
            Console.Clear();
            OutingsDetails content = new OutingsDetails();
            Console.WriteLine("Add an outing to the list here.");
            Console.WriteLine("Please select the event type:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");
            string eventType = Console.ReadLine();
            int eventNumber = int.Parse(eventType);
            content.EventType = (EventType)eventNumber;
            Console.WriteLine("Please enter the number of people that attended:");
            string attendInput = Console.ReadLine();
            int attendNumber = int.Parse(attendInput);
            content.NumAttend = attendNumber;
            Console.WriteLine("Please enter the date of the event:");
            string dateEvent = Console.ReadLine();
            DateTime dateNumbers = DateTime.Parse(dateEvent);
            content.DateAttend = dateNumbers;
            Console.WriteLine("Please enter the total cost per person:");
            string personCost = Console.ReadLine();
            double personNumber = double.Parse(personCost);
            content.IndCost = personNumber;
            Console.WriteLine("Please enter the total cost of the outing:");
            string totalCost = Console.ReadLine();
            double totalNumber = double.Parse(totalCost);
            content.TotCost = totalNumber;
            _outingsRepository.AddOutingsDetails(content);
        }
        private void OutingTotalCost()
        {
            Console.Clear();
            List<OutingsDetails> outingsTotalCost = _outingsRepository.IndTotalDetails();
            foreach (OutingsDetails content in outingsTotalCost)
            {
                DisplayIndTotal(content);
            }
            Console.WriteLine("Press any key to return....");
            Console.ReadKey();
        }
        private void DisplayIndTotal(OutingsDetails content)
        {
            Console.WriteLine($"Total cost for all outings: { content.IndCost}");
        }
        private void TotalOutingByType()
        {

        }
    }
}
