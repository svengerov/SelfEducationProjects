using System;
using System.Linq;
public class HouseExpenses
{
    public List<HouseExpense> ourHouseExpenses;
    
    public HouseExpenses()
    {
        ourHouseExpenses = new List<HouseExpense>();
        
    }  

    public void AddExpense(HouseExpense newExpense)
    {
        ourHouseExpenses.Add(newExpense);
    }

    public List<HouseExpense> GetExpensesByMonth(int month)
    {
         var specificMonthExpenses = ourHouseExpenses.Where(expense => expense.ExpenceDate.Month == month).ToList();
        return specificMonthExpenses;
    }

    public List<HouseExpense> BiggerThanAmount(double amount)
    {
        var bigExpenses = ourHouseExpenses.Where(expense => expense.ExpenceAmount >= amount).ToList();
        return bigExpenses;
    }
    public List<HouseExpense> GetExpensesByShop(string shopName)
    {
        var specificShopExpenses = ourHouseExpenses.Where(expense => expense.ShopName == shopName).ToList();
        return specificShopExpenses;
    }

    public double GetTotalAmount(List<HouseExpense> expenses)
    {        
        double totalAmount = expenses.Sum(expense => expense.ExpenceAmount);
        return totalAmount;
    }

}