using System;
using HerancaCourse.Entities;

namespace HerancaCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(2032, "Alex", 500.00);
            Account acc2 = new SavingsAccount(2032, "Jão", 500.00, 0.01);

            acc1.WithDraw(10);
            acc2.WithDraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
