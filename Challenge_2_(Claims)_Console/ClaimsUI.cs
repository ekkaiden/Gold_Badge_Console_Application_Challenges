using Challenge_2__Claims__Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2__Claims__Console
{
    public class ClaimsUI
    {
        private readonly ClaimRepository _claimRepository = new ClaimRepository();
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
                Console.WriteLine("Welcome to Komodo Claims Department!\n" +
                    "Please enter the number of the option you would like to select:\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        PullNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option." +
                            "Press any key to continue....\n");
                        Console.ReadKey();
                        break;

                }
            }
        }
        private void ShowAllClaims()
        {
            Console.Clear();
            List<ClaimDetails> claimList = _claimRepository.GetDetails();
            foreach (ClaimDetails content in claimList)
            {
                DisplayClaim(content);
            }
            Console.WriteLine("Press any key to return....");
            Console.ReadKey();
        }
        private void DisplayClaim(ClaimDetails content)
        {
            Console.WriteLine($"Claim ID: {content.ClaimID}\n" +
                $"Claim Type: {content.ClaimType}\n" +
                $"Description of Claim: {content.Description}\n" +
                $"Claim Amount: {content.Amount}\n" +
                $"Date of Accident: {content.DateOfAccident}\n" +
                $"Date of Claim: {content.DateOfClaim}\n" +
                $"Is a Valid Claim?: {content.IsValid}\n");
        }
        private void PullNextClaim()
        {
            Console.Clear();
            Queue<ClaimDetails> claimList = _claimRepository.QueueDetails();
            foreach (ClaimDetails content in claimList)
            {
                DisplayClaim(content);
            }
            Console.WriteLine("Press any key to return....");
            Console.ReadKey();
        }
        private void PullQueue(ClaimDetails content)
        {
            Queue<ClaimDetails> claim_queue = new Queue<ClaimDetails>();
            claim_queue.Enqueue(content);
        }
        private void AddNewClaim()
        {
            Console.Clear();
            ClaimDetails content = new ClaimDetails();
            Console.WriteLine("Add a new claim here");
            Console.WriteLine("Please enter the new claim ID here:");
            string inputID = Console.ReadLine();
            int numberID = int.Parse(inputID);
            content.ClaimID = numberID;
            Console.WriteLine("Please select the claim type here:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n");
            string typeInput = Console.ReadLine();
            int typeNumber = int.Parse(typeInput);
            content.ClaimType = (ClaimType)typeNumber;
            _claimRepository.AddClaimDetails(content);
            Console.WriteLine("Please enter a short description of this claim:");
            content.Description = Console.ReadLine();
            Console.WriteLine("Please enter the claim amount here:");
            string amountInput = Console.ReadLine();
            double amountNumber = double.Parse(amountInput);
            content.Amount = amountNumber;
            Console.WriteLine("Please enter the date of the accident here, in MM/DD/YYYY format:");
            string dateAccInput = Console.ReadLine();
            DateTime dateAccNumber = DateTime.Parse(dateAccInput);
            content.DateOfAccident = dateAccNumber;
            Console.WriteLine("Please enter today's date here, in MM/DD/YYYY format:");
            string dateClInput = Console.ReadLine();
            DateTime dateClNumber = DateTime.Parse(dateClInput);
            content.DateOfClaim = dateClNumber;
            Console.WriteLine("Is this claim valid?\n" +
                "1. Yes\n" +
                "2. No\n");
            string isValid = Console.ReadLine();
            switch (isValid)
            {
                case "1":
                    content.IsValid = IsValid.Valid;
                    break;
                case "2":
                    content.IsValid = IsValid.Invalid;
                    break;
                default:
                    Console.WriteLine("Please select one of the listed options.");
                    Console.ReadKey();
                    break;
            }
            _claimRepository.AddClaimDetails(content);

        }
    }
}
