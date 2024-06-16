
using System;
using System.Linq;

public class HouseExpencesCalculator
{
    public static void Main(string[] args)
    {
        var myHouseExpenses = new HouseExpenses();
        var supersal1 = new HouseExpense(215, new DateTime(2024, 5, 31), "Supersal");
        var supersal2 = new HouseExpense(100, new DateTime(2024, 5, 21), "Supersal");
        var supersal3 = new HouseExpense(300, new DateTime(2024, 7, 31), "Supersal");
        var russianShop1 = new HouseExpense(90, new DateTime(2024, 5, 20), "Russian");


        // Add expenses
        myHouseExpenses.AddExpense(supersal1);
        myHouseExpenses.AddExpense(supersal2);
        myHouseExpenses.AddExpense(supersal3);
        myHouseExpenses.AddExpense(russianShop1);


        // Get total expenses
        // double totalExpenses = myHouseExpenses.GetTotalExpenses();
        // Console.WriteLine($"Total expenses: ${totalExpenses}");

        // Get May expences
        var MayExpenses = myHouseExpenses.GetExpensesByMonth(5);
        Console.WriteLine($"May expenses: ${MayExpenses.Sum(e => e.ExpenceAmount)}");

        //Get big expences
        var BigExpenses = myHouseExpenses.BiggerThanAmount(200);
        Console.WriteLine($"Big expenses: ${BigExpenses.Sum(e => e.ExpenceAmount)}");

        //Get Supersal expences
        var SupersalExpenses = myHouseExpenses.GetExpensesByShop("Supersal");
        Console.WriteLine($"Supersal expenses: ${SupersalExpenses.Sum(e => e.ExpenceAmount)}");
    }
}


