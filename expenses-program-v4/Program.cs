using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        // Create a list of the ExpenseClaim objects
        List<ExpenseClaim> Expenseclaims = new List<ExpenseClaim>();


        // Create an array for the claim type choices
        string[] claimTypes = { "Travel and Expenses", "Just Travel" };

        // Ask the user for the number of journeys completed
        Console.WriteLine("------------------Expense Claim Program------------------\n");
        Console.Write("Please enter the number of journeys completed: ");

        // Assign number of journeys user selected to local variable
        int numberOfJourneys = int.Parse(Console.ReadLine());

        // Loop through expense claim creation for the amount of journeys selected by the user
        for (int i = 0; i < numberOfJourneys; i++)
        {   
            // Print journey number to the console
            Console.WriteLine("\nJourney " + (i + 1) + "\n");

            // Ask the user to select the claim type from the available choices
            Console.WriteLine("Please select a claim type:\n");
            for (int j = 0; j < claimTypes.Length; j++)
            {
                Console.WriteLine(j + 1 + ") " + claimTypes[j]);
            }

            // Parse user selected index to local variable
            int claimTypeIndex = int.Parse(Console.ReadLine()) - 1;

            // Assign corresponding user claim type choice to local variable
            string claimType = claimTypes[claimTypeIndex];

            // Create a new instance of the ExpenseClaim class
            ExpenseClaim expenseClaim = new ExpenseClaim();

            // Set the claim type in the expense claim object
            expenseClaim.SetClaimType(claimType);

            // Ask the user to enter the travel cost
            Console.WriteLine("\nPlease enter the travel cost: ");
            double travelCost = double.Parse(Console.ReadLine());

            // Set the travel cost in the expense claim object
            expenseClaim.SetTravelCost(travelCost);

            // Initialise the travel cost variable
            double expenseCost = 0;

            // If claim is for travel and expenses, get expense cost from user
            if (claimType == "Travel and Expenses")
            {
                // Ask the user to enter the expense cost
                Console.WriteLine("\nPlease enter the expense cost: ");
                expenseCost = double.Parse(Console.ReadLine());

                // Set the expense cost in the expense claim object
                expenseClaim.SetExpenseCost(expenseCost);
            }

            // Set the non refundable amount in the expense claim object
            expenseClaim.SetNonRefundable(expenseCost);

            // Get the receipt details from the expense claim object
            var receiptDetails = expenseClaim.GetReceiptDetails();



            // Print the receipt details
            Console.WriteLine("\n\n---------------------------Receipt Details-------------------------------\n");
            foreach (var detail in receiptDetails)
            {
                Console.WriteLine(detail);
            }

            // Calculate and print the total cost of the expense claim
            Console.WriteLine("\nTotal cost of the expense claim: " + expenseClaim.GetTotalCost());

            // Calculate and print the tax that can be reclaimed by the company (20% of the total cost)
            Console.WriteLine("Tax that can be reclaimed by the company: " + expenseClaim.GetTotalCost() * 0.2);

            // Calculate and print the amount that will need to be paid to the employee (total cost minus non-refundable amount)
            Console.WriteLine("Amount that will need to be paid to the employee: " + (expenseClaim.GetTotalCost() - expenseClaim.GetNonRefundable()));

            // Calculate and print the average payment required (total cost divided by 2, since the employee is awarded 100% of the travel cost)
            Console.WriteLine("Average payment required: " + expenseClaim.GetTotalCost() / 2);

            // Calculate and print the largest payment made (whichever is greater: the travel cost or the expense cost minus the £50 limit)
            double largestPayment = expenseCost - 50 > travelCost ? expenseCost - 50 : travelCost;
            Console.WriteLine("Largest payment made: " + largestPayment);
            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // Add ExpenseClaim object to list of Expense Claims
            Expenseclaims.Add(expenseClaim);



        }
    }

}
