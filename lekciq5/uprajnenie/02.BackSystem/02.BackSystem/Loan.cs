using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Loan : Account
{
    public Loan(Custemer customer, decimal balance, decimal rate)
        : base(customer, balance, rate)
    {
    }
    public override void CalcInterest(sbyte period)
    {
        if (base.Custemer == Custemer.Individual)
        {
            period = (sbyte)(period - 3);
        }
        if (base.Custemer == Custemer.Companie)
        {
            period = (sbyte)(period - 2);
        }
        base.InterestAmount = period * base.InterestRate;
        base.PrintAmount();
        //cleaning the interest
        base.InterestAmount = 0;
    }
}

