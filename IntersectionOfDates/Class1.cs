﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfDates
{
    class Program
    {
        public void IntersectPeriods(List<dynamic> SetA, List<dynamic> SetB)
        {
            foreach (TimeRange PeriodSetA in SetA)
            {
                foreach (TimeRange PeriodSetB in SetB)
                {
                    if ((PeriodSetA.EndingDate > PeriodSetA.StartingDate) && (PeriodSetB.EndingDate > PeriodSetB.StartingDate))
                    {
                        if (((PeriodSetA.StartingDate <= PeriodSetB.StartingDate) && (PeriodSetA.EndingDate <= PeriodSetB.EndingDate)) && ((PeriodSetA.EndingDate >= PeriodSetB.StartingDate)))
                            Console.WriteLine(PeriodSetB.StartingDate + " - " + PeriodSetA.EndingDate);
                        else if ((PeriodSetA.StartingDate >= PeriodSetB.StartingDate) && (PeriodSetA.EndingDate >= PeriodSetB.EndingDate) && ((PeriodSetA.EndingDate >= PeriodSetB.StartingDate)))
                            Console.WriteLine(PeriodSetA.StartingDate + " - " + PeriodSetB.EndingDate);
                        else if ((PeriodSetA.StartingDate >= PeriodSetB.StartingDate) && (PeriodSetA.EndingDate <= PeriodSetB.EndingDate))
                            Console.WriteLine(PeriodSetA.StartingDate + " - " + PeriodSetA.EndingDate);
                        else if ((PeriodSetA.StartingDate <= PeriodSetB.StartingDate) && (PeriodSetA.EndingDate >= PeriodSetB.EndingDate))
                            Console.WriteLine(PeriodSetB.StartingDate + " - " + PeriodSetB.EndingDate);
                        else
                            Console.WriteLine("No Intersection");
                    }
                    else
                        Console.WriteLine("Wrong Entry");
                }
            }
        }

        static void Main(string[] args)
        {
            Program Range = new Program();
            var ListA = new List<dynamic>();
            var ListB = new List<dynamic>();
            Console.WriteLine("Enter the number of periods in setA");
            int NumberOfPeriodsSetA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of periods in setB");
            int NumberOfPeriodSetB = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < NumberOfPeriodsSetA; index++)
            {
                Console.WriteLine("Enter your period range {0} in setA: ", (index + 1));
                TimeRange p1 = new TimeRange(Convert.ToDateTime(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
                ListA.Add(p1);
            }
            for (int index = 0; index < NumberOfPeriodSetB; index++)
            {
                Console.WriteLine("Enter your period range {0} in setB: ", (index + 1));
                TimeRange p2 = new TimeRange(Convert.ToDateTime(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()));
                ListB.Add(p2);
            }
            Range.IntersectPeriods(ListA, ListB);
            Console.ReadLine();
        }
    }

}


