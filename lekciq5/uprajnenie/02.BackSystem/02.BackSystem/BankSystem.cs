//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
//as follows: number_of_months * interest_rate.Loan accounts have no interest for the first 3 months if are held by 
//individuals and for the first 2 months if are held by a company.Deposit accounts have no interest if their balance is
//positive and less than 1000.Mortgage accounts have ½ interest for the first 12 months for companies and no interest for
//the first 6 months for individuals.Your task is to write a program to model the bank system by classes and interfaces. 
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the 
//interest functionality through overridden methods.

using System;

class BankSystem
{
    static void Main()
    {
        // creating 3 different accounts
        Account acc1 = new Deposit(Custemer.Individual, 1234, 0.75m);
        Account acc2 = new Loan(Custemer.Companie, 100052, 1.2m);
        Account acc3 = new Mortgage(Custemer.Individual, 754, 0.98m);
        acc1.PrintBalance();
        acc1.CalcInterest(7);
        acc1.PrintBalance();
        acc1.Deposit(300);
        //acc1.Draw- it is Account
        Deposit acc4 = new Deposit(Custemer.Individual, 2222, 0.35m);
        acc4.Draw(1111);
        acc2.CalcInterest(7);
        acc2.Deposit(555);      
    }
}

