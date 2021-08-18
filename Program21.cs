using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program21
    {
        static void GetRole(string qualification, out string eligibleRole)
        {
            switch (qualification)
            {
                case "B.Tech":
                    eligibleRole = "Programmer";
                    break;
                case "MBA":
                    eligibleRole = "HR";
                    break;
                case "MCA":
                    eligibleRole = "Trainer";
                    break;
                default:
                    eligibleRole = "Assistant";
                    break;
            }
        }
        static void Main(string[] args)
        {
            string qualification = "B.Tech";
            string eligibleRole;
            GetRole(qualification, out eligibleRole);
            Console.WriteLine($"For qualication  {qualification}, eligible role is: {eligibleRole}");
        }
    }
}
/*
 * out parameter used to have variable without initializtion and changes will be effect to the original
 * commonly used in the case of initialization at definition
 */