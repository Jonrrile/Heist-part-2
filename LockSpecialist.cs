using System;
using System.Collections.Generic;

namespace Heist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill()
        {
            int CashOnHand = 0 - SkillLevel;
            Console.WriteLine($"The bank has ${CashOnHand} on hand.");
        }
    }

}