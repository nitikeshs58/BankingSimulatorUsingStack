using System;

namespace BankingSimulatorStack
{
    class stackMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!**Welcome to banking simulator using stack.**!!");
            Console.WriteLine("Enter StackList size :");
            int size = Convert.ToInt32(Console.ReadLine());
            // object creation of StackList and parameterized constructor called
            StackList stack = new StackList(size);
            // object creation of Banking
            Banking bank = new Banking();

            int count = 0;
            int choice = 0;
            int person = 0;
            while (count < size)
            {
                person = count + 1;
                int accountantBalance = 5000;
                int totalAccountantBalance = 0;

                Console.WriteLine("\nUser : " + person);
                Console.WriteLine("\nEnter your Choice :\nPress 1: toDeposite \nPress 2: toWithdraw");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1 || choice == 2)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Deposite amount: ");
                            int depositeCash = Convert.ToInt32(Console.ReadLine());
                            if (depositeCash <= 0)
                            {
                                Console.WriteLine("!!** Deposite cash must be grater than 0 **!!\n");
                            }
                            else
                            {
                                totalAccountantBalance = bank.cashDeposite(depositeCash, accountantBalance);
                                stack.push(totalAccountantBalance);
                                stack.showStacklist();
                                stack.pop();
                                depositeCash = 0;
                                count += 1;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter withdraw amount: ");
                            int withdrawCash = Convert.ToInt32(Console.ReadLine());
                            if (accountantBalance < withdrawCash || withdrawCash <= 0)
                            {
                                Console.WriteLine("!!** Insufficient/Invalid balance to withdraw **!!\n");
                            }
                            else
                            {
                                totalAccountantBalance = bank.cashWithdraw(withdrawCash, accountantBalance);
                                stack.push(totalAccountantBalance);
                                stack.showStacklist();
                                stack.pop();
                                withdrawCash = 0;
                                count += 1;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("!!**Enter appropriate value.**!!\n");
                }                
            }
        }
    }
}
