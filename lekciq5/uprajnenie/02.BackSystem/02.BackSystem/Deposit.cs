using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Deposit : Account ,IDrawable
{
    public Deposit(Custemer custemer, decimal balance, decimal rate)
        : base(custemer, balance, rate)
    {
    }
    // this method is just for calculating the interest not adding it to the balance
    public override void CalcInterest(sbyte period)
    {
        if (base.Balance < 1000)
        {
            base.PrintAmount();
        }
        else
        {
            base.InterestAmount = period * base.InterestRate;
            base.PrintAmount();
            //cleaning the interest
            base.InterestAmount = 0;
        }
    }
    // this method will take sum from the balance and print the new one
    public void Draw(decimal sum)
    {
        this.Sum = sum;
        base.Balance = base.Balance - sum;
        base.PrintBalance();
    }
}

