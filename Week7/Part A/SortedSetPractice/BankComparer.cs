using System.Collections.Generic;

public class BankComparer : IComparer<BankAccount>
{
    public int Compare(BankAccount? x, BankAccount? y)
    {
        if (x == null && y == null)
        {
            return 0;
        }
        if (x == null)
        {
            return -1;
        }
        if (y == null)
        {
            return 1;
        }
        
        int result = x.Balance.CompareTo(y.Balance);
        if (result == 0)
        {
            result = string.Compare(x.Owner, y.Owner);
        }
        return result;
    }
}