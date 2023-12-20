using System;

namespace ConsoleApplication1
{
    public class Hello
    {
        private DateTime thisDateTime;
        private int shiftStart;
        private int shiftEnd;
        private int afternoon;
        
        public Hello()
        {
            thisDateTime = DateTime.Now;
            shiftStart = 9;
            shiftEnd = 18;
            afternoon = 13;
        }

        public Hello(int start, int aprem, int end)
        {
            thisDateTime = DateTime.Now;
            shiftStart = start;
            shiftEnd = aprem;
            afternoon = end;
        }

        public void getHelloMessage()
        {
            
            if (isWeekend(thisDateTime))
            {
                Console.WriteLine("Bon weekend "+Environment.UserName);
            }
            else if (thisDateTime.Hour>shiftStart)
            {
                Console.WriteLine("Bonjour "+Environment.UserName);
            }
            else if (thisDateTime.Hour>afternoon)
            {
                Console.WriteLine("Bon aprem "+Environment.UserName);
            }else if (thisDateTime.Hour>shiftEnd)
            {
                Console.WriteLine("Bonne soirée "+Environment.UserName);
            }
        }
        public bool isWeekend(DateTime day)
        {
            return  (day.DayOfWeek==DayOfWeek.Saturday || day.DayOfWeek==DayOfWeek.Sunday|| (day.DayOfWeek == DayOfWeek.Friday && day.Hour > shiftEnd) ||
                                       (day.DayOfWeek == DayOfWeek.Monday && day.Hour < shiftStart));
        }
    }
}