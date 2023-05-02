using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        // Create a list of the ExpenseClaim objects
        List<ExpenseClaim> Expenseclaims = new List<ExpenseClaim>();

        // Create a new instance of the ExpenseClaim class
        ExpenseClaim expenseClaim = new ExpenseClaim();

        // Print Title of program to console
        
        Console.Write("\n---------------------NEW EXPENSE CLAIM---------------------\n\n");


        // Ask user to set number of journeys in expense claim object
        expenseClaim.SetNumberOfJourneys();

        // Create a list of the Journey objects
        List<Journey> Journeys = new List<Journey>();


        // Loop through for the amount of journeys selected by the user for the expense claim instance
        for (int i = 0; i < expenseClaim.GetNumberOfJourneys(); i++)
        {
            // Create a new instance of the Journey class
            Journey journey = new Journey();

            // Print journey number to the console
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\nJourney " + (i + 1) + " Claim Details\n");

            // Get the user to set the claim type of the journey
            journey.SetClaimType();

            // Get the user to set the travel cost of the current journey
            journey.SetTravelCost();


            // If claim is for expenses as well as travel then set expense cost 

            if (journey.GetClaimType() == "Travel and Expenses")
            {
                // Ask the user to enter the expense cost ,parse to double and save to local variable
                Console.WriteLine("\nPlease enter the expense cost: ");
                double expenseCost = double.Parse(Console.ReadLine());

                // Set current journey expense cost from user input
                journey.SetExpenseCost(expenseCost);

                // Set the non refundable amount in the current journey object
                journey.SetNonRefundable(expenseCost);

                // Add current journey instance expenses to current claim instance running total
                expenseClaim.AddToTotalExpenses(expenseCost);



            }

            // Add current journey instance to the list of journeys
            Journeys.Add(journey);

            Console.WriteLine("\n----------------------------------------------------------");



















        }

        Console.WriteLine(expenseClaim.GetTotalExpenses());

        foreach (Journey r in Journeys)
        {

            Console.WriteLine("I'm printing something");

        }




    }

}
