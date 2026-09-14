using System.Collections.Generic;

public class BankComparer : IComparer<BankAccount>
{
    public int Compare(BankAccount? x, BankAccount? y)
    {
        int result = x.Balance.CompareTo(y.Balance);

        if (result == 0)
        {
            result = string.Compare(x.Owner, y.Owner);
        }

        return result;
    }
}