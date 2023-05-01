using System;
using System.Collections.Generic;

class ExpenseClaim
{
    // Fields to store the expense cost, travel cost, non-refundable amount, and claim type
    private double expenseCost;
    private double travelCost;
    private double nonRefundable = 50.00;
    private string claimType;

    // Setter method for the expense cost field

    /*
    public void SetExpenseCost(double expenseCost)
    {
        this.expenseCost = expenseCost;
    }

    */

    // Getter method for the expense cost field
    public double GetExpenseCost()
    {
        return expenseCost;
    }

    // Setter method for the expense cost field
    public void SetExpenseCost(double expenseCost)
    {
        this.expenseCost = expenseCost;
    }

    // Setter method for the travel cost field
    public void SetTravelCost(double travelCost)
    {
        this.travelCost = travelCost;
    }

    // Getter method for the travel cost field
    public double GetTravelCost()
    {
        return travelCost;
    }

    // Setter method for the non-refundable amount field
    /*
    public void SetNonRefundable(double nonRefundable)
    {
        this.nonRefundable = nonRefundable;
    }
    */

    // Getter method for the non-refundable amount field
    public double GetNonRefundable()
    {
        return nonRefundable;
    }


    // Setter method for the claim type field
    public void SetClaimType(string claimType)
    {
        this.claimType = claimType;
    }

    // Getter method for the claim type field
    public string GetClaimType()
    {
        return claimType;
    }

    // Method to calculate the total cost of the expense claim
    public double GetTotalCost()
    {
        // Calculate the total cost by adding the expense cost and travel cost and then subtracting the non-refundable amount
        double totalCost = expenseCost + travelCost - nonRefundable;

        // If the claim type is "Just Travel", subtract the expense cost from the total cost
        if (claimType == "Just Travel")
        {
            totalCost -= expenseCost;
        }

        // Return the total cost
        return totalCost;
    }

    // Method to generate the receipt details as a list of strings
    public List<string> GetReceiptDetails()
    {
        // Create a new list to store the receipt details
        List<string> details = new List<string>();

        // Add the claim type, expense cost, travel cost, non-refundable amount, and total cost to the list of receipt details
        details.Add("Claim type: " + claimType);
        details.Add("Expense cost: " + expenseCost);
        details.Add("Travel cost: " + travelCost);
        details.Add("Non-refundable: " + nonRefundable);
        details.Add("Total cost: " + GetTotalCost());

        // Return the list of receipt details
        return details;
    }
}


public class Company
{
    // Static method to calculate the amount of tax that can be reclaimed by the company
    // calculated at 20% of the total cost
    public static double GetReclaimableTax(double totalCost)
    {
        // Multiply the total cost by 0.2 (20%) to get the amount of tax that can be reclaimed
        return totalCost * 0.2;
    }
}



class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the ExpenseClaim class
        ExpenseClaim expenseClaim = new ExpenseClaim();

        // Create an array for the claim type choices
        string[] claimTypes = { "Travel and Expenses", "Just Travel" };

        // Ask the user to select the claim type from the choices
        Console.WriteLine("Select claim type:");
        for (int j = 0; j < claimTypes.Length; j++)
        {
            Console.WriteLine(j + 1 + ") " + claimTypes[j]);
        }
        int claimTypeIndex = int.Parse(Console.ReadLine()) - 1;

        

        // Assign user claim type choice to local variable
        string claimType = claimTypes[claimTypeIndex];

        // Set the claim type in the expense claim object

        expenseClaim.SetClaimType(claimType);

        // Ask the user to enter the travel cost
        Console.WriteLine("Enter the travel cost: ");
        double travelCost = double.Parse(Console.ReadLine());

        // Set the travel cost in the expense claim object
        expenseClaim.SetTravelCost(travelCost);

        // Ask the user to enter the expense cost
        Console.WriteLine("Enter the expense cost: ");
        double expenseCost = double.Parse(Console.ReadLine());

        

       // Set the expense cost in the expense claim object
       expenseClaim.SetExpenseCost(expenseCost);

       /*

       // Ask the user to enter the non-refundable amount
       Console.WriteLine("Enter the non-refundable amount: ");
       double nonRefundable = double.Parse(Console.ReadLine());

        */

        // Get the non-refundable amount in the expense claim object
        expenseClaim.GetNonRefundable();

       

        // Get the receipt details from the expense claim object
        var receiptDetails = expenseClaim.GetReceiptDetails();

        // Print the receipt details
        Console.WriteLine("\nReceipt Details:");
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
    }
}
