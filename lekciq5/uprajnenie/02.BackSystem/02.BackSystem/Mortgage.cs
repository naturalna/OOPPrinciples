using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Mortgage : Account
{
    private sbyte restOfthePeriod;
    public sbyte RestOfthePeriod
    {
        get { return this.restOfthePeriod; }
        set { this.restOfthePeriod = value; }
    }
    public Mortgage(Custemer customer,decimal balance,decimal rate)
        : base(customer,balance,rate)
    {
        this.RestOfthePeriod = 0;
    }
    public override void CalcInterest(sbyte period)
    {
        if (base.Custemer == Custemer.Individual)
        {
            if (period <= 6)
            {
                base.InterestAmount = period * base.InterestRate / 2;
                base.PrintAmount();
                //cleaning the interest
                base.InterestAmount = 0;
            }
            else
            {

                this.RestOfthePeriod = (sbyte)(period - 6);
                base.InterestAmount = (6 * base.InterestRate / 2) + (RestOfthePeriod * base.InterestRate);
                base.PrintAmount();
                //cleaning the interest
                base.InterestAmount = 0;
            }
        }
        if (base.Custemer == Custemer.Companie )
        {
            if (period <= 12)
            {
                base.InterestAmount = period * base.InterestRate / 2;
                base.PrintAmount();
                //cleaning the interest
                base.InterestAmount = 0;
            }
            else
            {

                this.RestOfthePeriod = (sbyte)(period - 12);
                base.InterestAmount = (12 * base.InterestRate / 2) + (RestOfthePeriod * base.InterestRate);
                base.PrintAmount();
                //cleaning the interest
                base.InterestAmount = 0;
            }
        }
    }
}


