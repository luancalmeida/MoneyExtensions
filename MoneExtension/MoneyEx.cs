namespace MoneExtension;

public static class MoneyEx
{
    public static int ToCents(this decimal money)
    {
        if (money < 0)
        {
            return 0;
        }// negative money is not allowed
        var value = money.ToString("0.00")
                        .Replace(".", "")
                        .Replace(",", "");// convert to string without decimal point
        if(string.IsNullOrEmpty(value))
            return 0;
        
        int.TryParse(value, out var result);// parse to int or return 0 if failed 
        return result;
    }
    

}
