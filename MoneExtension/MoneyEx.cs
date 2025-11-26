namespace MoneExtension;

public static class MoneyEx
{
    public static int ToCents(this decimal money)
    {
        if (money < 0)
        {
            return 0;
        }// negative money is not allowed
        var text = money.ToString("0.00")
                        .Replace(".", "")
                        .Replace(",", "");// convert to string without decimal point
        if(string.IsNullOrEmpty(text))
            return 0;
        
        int.TryParse(text, out var result);// parse to int or return 0 if failed 
        return result;
    }
    

}
