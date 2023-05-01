using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class ExpenseClaim
{

    // Fields 
    private int numberOfJourneys;
    private double totalExpenses = 0;




    //---------Journeys-----------------------------//

    // Setter method for the number of journeys field    
    public void SetNumberOfJourneys()
    {
        // Ask the user for the number of journeys completed
        Console.Write("Please enter the number of journeys completed: ");

        // Assign number of journeys user selected to local variable
        this.numberOfJourneys = int.Parse(Console.ReadLine());

    }

    // Getter method for the number of journeys field
    public int GetNumberOfJourneys()
    {
        return numberOfJourneys;
    }








    //---------Total Expenses-----------------------------//


    // Setter method for the total expenses field
 
    public void AddToTotalExpenses(double expenseCost)
    {
        this.totalExpenses += expenseCost;
    }


    // Getter method for the total expenses field
    public double GetTotalExpenses()
    {
        return totalExpenses;
    }





}

