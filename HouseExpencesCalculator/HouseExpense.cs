public class HouseExpense
{
  
  public double ExpenceAmount {  get; set; }
  public  DateTime ExpenceDate { get; set; }
  public string ShopName { get; set; }
    public HouseExpense(double amount_,DateTime expenceDate,string shopName)
    {
        this.ExpenceAmount = amount_;   
        this.ExpenceDate = expenceDate;
        this.ShopName = shopName;
    }


   
}