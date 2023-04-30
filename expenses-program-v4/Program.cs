using System;
using System.Collections.Generic;

class ExpenseClaim
{
    private double expenseCost;
    private double travelCost;
    private double nonRefundable;
    private string claimType;

    public void SetExpenseCost(double expenseCost)
    {
        this.expenseCost = expenseCost;
    }

    public double GetExpenseCost()
    {
        return expenseCost;
    }

    public void SetTravelCost(double travelCost)
    {
        this.travelCost = travelCost;
    }

    public double GetTravelCost()
    {
        return travelCost;
    }

    public void SetNonRefundable(double nonRefundable)
    {
        this.nonRefundable = 0;
    }

    public double GetNonRefundable()
    {
        return nonRefundable;
    }

    public void SetClaimType(string claimType)
    {
        this.claimType = claimType;
    }

    public string GetClaimType()
    {
        return claimType;
    }

    public double GetTotalCost()
    {
        double totalCost = expenseCost + travelCost - nonRefundable;
        if (claimType == "Just Travel")
        {
            totalCost -= expenseCost;
        }
        return totalCost;
    }

    public List<string> GetReceiptDetails()
    {
        List<string> details = new List<string>();
        details.Add("Claim type: " + claimType);
        details.Add("Expense cost: " + expenseCost);
        details.Add("Travel cost: " + travelCost);
        details.Add("Non-refundable: " + nonRefundable);
        details.Add("Total cost: " + GetTotalCost());
        return details;
    }
}

class Company
{
    public static double GetReclaimableTax(double totalCost)
    {
        return totalCost * 0.20;
    }
}




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Expense Claim Program\n");

        Console.Write("Enter the number of journeys completed: ");
        int numberOfJourneys = int.Parse(Console.ReadLine());

        List<ExpenseClaim> claims = new List<ExpenseClaim>();

        for (int i = 0; i < numberOfJourneys; i++)
        {
            Console.WriteLine("\nJourney " + (i + 1) + "\n");

            Console.Write("Enter the expense cost: ");
            double expenseCost = double.Parse(Console.ReadLine());

            Console.Write("Enter the travel cost: ");
            double travelCost = double.Parse(Console.ReadLine());

            Console.Write("Enter the non-refundable amount: ");
            double nonRefundable = double.Parse(Console.ReadLine());

            string[] claimTypes = { "Travel and Expenses", "Just Travel" };
            Console.WriteLine("Select claim type:");
            for (int j = 0; j < claimTypes.Length; j++)
            {
                Console.WriteLine(j + 1 + ") " + claimTypes[j]);
            }
            int claimTypeIndex = int.Parse(Console.ReadLine()) - 1;
            string claimType = claimTypes[claimTypeIndex];

            ExpenseClaim claim = new ExpenseClaim();
            claim.SetExpenseCost(expenseCost);
            claim.SetTravelCost(travelCost);
            claim.SetNonRefundable(nonRefundable);
            claim.SetClaimType(claimType);

            claims.Add(claim);
        }

        double totalExpenseCost = 0;
        double totalTravelCost = 0;
        double totalNonRefundable = 0;
        double totalCost = 0;

        foreach (ExpenseClaim claim in claims)
        {
            totalExpenseCost += claim.GetExpenseCost();
            totalTravelCost += claim.GetTravelCost();
            totalNonRefundable += claim.GetNonRefundable();
            totalCost += claim.GetTotalCost();
        }

        double reclaimableTax = Company.GetReclaimableTax(totalCost);

        Console.WriteLine("\nReceipt Details:\n");

        foreach (ExpenseClaim claim in claims)
        {
            Console.WriteLine("\nClaim:");
            List<string> details = claim.GetReceiptDetails();
            foreach (string detail in details)
            {
                Console.WriteLine(detail);
            }
        }

        Console.WriteLine("\nTotals:\n");

        Console.WriteLine("Total expense cost: " + totalExpenseCost);
        Console.WriteLine("Total travel cost: " + totalTravelCost);
        Console.WriteLine("Total non-refundable: " + totalNonRefundable);
        Console.WriteLine("Total cost: " + totalCost);
        Console.WriteLine("Reclaimable tax: " + reclaimableTax);
    }
}
