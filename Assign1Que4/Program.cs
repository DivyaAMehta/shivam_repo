using Assign1Que4;
using Microsoft.VisualBasic;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        BankAccount saving = new SavingAccount();
        BankAccount current = new CurrentAccount();
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Bank Name:");
        string bank=Console.ReadLine();
        Console.WriteLine("Select Account Type");
        Console.WriteLine("1.Saving\n 2.Current");
        string num = Console.ReadLine();

        switch (num)
        {
            case "1":
                {
                    Console.WriteLine("Welcome");
                    Console.WriteLine("Customer Name:"+name);
                    Console.WriteLine("Bank Name:"+bank);
                    Console.WriteLine("Bank Account Type: Saving");
                    Console.WriteLine("Bank Balance:"+saving.Balance);
                    Console.WriteLine("Select Mode:");
                    Console.WriteLine("1.Deposit\n 2.Withdraw");
                    string num1 = Console.ReadLine();
                    switch (num1)
                    {
                        case "1":
                            {
                                saving.Deposit(100);
                                Console.WriteLine("Bank Balance:" + saving.Balance);

                            }
                            break;
                        case "2":
                            {
                                saving.Withdraw(10);
                                Console.WriteLine("Bank Balance:" + saving.Balance);

                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid choice");
                            }
                            break;
                    }

                }
                break;
            case "2":
                {
                    Console.WriteLine("Welcome");
                    Console.WriteLine("Customer Name:" + name);
                    Console.WriteLine("Bank Name:" + bank);
                    Console.WriteLine("Bank Account Type: Current");
                    Console.WriteLine("Bank Balance:"+current.Balance);
                    Console.WriteLine("Select Mode:");
                    Console.WriteLine("1.Deposit\n 2.Withdraw");
                    string num1 = Console.ReadLine();
                    switch (num1)
                    {
                        case "1":
                            {
                                current.Deposit(110);
                                Console.WriteLine("Bank Balance:" + current.Balance);

                            }
                            break;
                        case "2":
                            {
                                current.Withdraw(30);
                                Console.WriteLine("Bank Balance:" + current.Balance);

                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid choice");

                            }
                            break;
                    }
                }
                break;

            default:
                    Console.WriteLine("Invalid choice");
                break;
        }
    }
}