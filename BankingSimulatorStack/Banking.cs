﻿using System;

namespace BankingSimulatorStack
{
    // cash withdraw and deposite are done
    public class Banking
    {
        // cash withdraw
        public int cashWithdraw(int cashToWithdraw, int currentBalance)
        {
            currentBalance -= cashToWithdraw;
            return currentBalance;
        }

        // cash deposite
        public int cashDeposite(int cashToDeposite, int currentBalance)
        {
            currentBalance += cashToDeposite;
            return currentBalance;
        }
    }    
}
