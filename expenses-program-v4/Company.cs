using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Company
{
    // Static method to calculate the amount of tax that can be reclaimed by the company
    // calculated at 20% of the total cost
    public static double GetReclaimableTax(double totalCost)
    {
        // Multiply the total cost by 0.2 (20%) to get the amount of tax that can be reclaimed
        return totalCost * 0.2;
    }
}
