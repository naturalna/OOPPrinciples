using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Account : ICalculatable, IDepositable
    {
        private Custemer custemer;
        public Custemer Custemer
        {
            get { return this.custemer; }
           protected set { this.custemer = value; }
        }
        private decimal balance;
        protected decimal Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        private decimal interestRate;
        public decimal InterestRate
        {
            get { return this.interestRate; }
           protected set { this.interestRate = value; }
        }
        private decimal interestAmount;
        public decimal InterestAmount
        {
            get { return this.interestAmount; }
            set { this.interestAmount = value; }
        }
        private decimal sum;
        protected decimal Sum
        {
            set
            {
                this.sum = value;
                if (value > this.Balance && value < 0)
                {
                    throw new ApplicationException("You do not have enough money");
                }
            }
        }
        protected Account(Custemer custemer,decimal balance,decimal interestRate)
        {
            this.Custemer = custemer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.InterestAmount = 0;
            this.Sum = 0;
        }
        public abstract void CalcInterest(sbyte period);
        public void Deposit(decimal sum)
        {
           this.Balance = this.Balance + sum;
           PrintBalance();
        }
        public void PrintBalance()
        {
            Console.WriteLine("Your balance is : {0}",this.Balance);
        }
        protected void PrintAmount()
        {
            Console.WriteLine("You interest amount is : {0}",this.InterestAmount);
        }
    }

