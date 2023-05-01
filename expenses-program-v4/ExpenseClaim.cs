using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class ExpenseClaim
{
        // Fields to store the expense cost, travel cost, non-refundable amount, and claim type
        private double expenseCost;
        private double travelCost;
        private double nonRefundable;
        private string claimType;


        // Setter method for the expense cost field    
        public void SetExpenseCost(double expenseCost)
        {
            this.expenseCost = expenseCost;
        }

        // Getter method for the expense cost field
        public double GetExpenseCost()
        {
            return expenseCost;
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

        public void SetNonRefundable(double expenseCost)
        {
            if (expenseCost > 50)
            {
                this.nonRefundable = expenseCost - 50;

            }
            else
            {
                this.nonRefundable = 0;
            }

        }


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
            double totalCost = expenseCost + travelCost;

            return totalCost;
        }

        // Method to generate the receipt details as a list of strings
        public List<string> GetReceiptDetails()
        {
            // Create a new list to store the receipt details
            List<string> details = new List<string>();

            // Add the claim type, expense cost, travel cost, non-refundable amount, and total cost to the list of receipt details
            details.Add("Claim type: " + claimType);
            details.Add("\nExpense cost: " + expenseCost);
            details.Add("Travel cost: " + travelCost);
            details.Add("Total cost: " + GetTotalCost());
            details.Add("Non-refundable amount: " + nonRefundable);


            // Return the list of receipt details
            return details;
        }
        
}

