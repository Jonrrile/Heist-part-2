using System;
using System.Collections.Generic;

namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank JGWentworth = new Bank()
            {
                CashOnHand = 3
            };

            LockSpecialist Jon = new LockSpecialist()
            {
                Name = "Jon",
                SkillLevel = 7,
                PercentageCut = 25

            };
            Jon.PerformSkill();

            Console.WriteLine($"{Jon.Name} robbed the bank");
        }
    }
}