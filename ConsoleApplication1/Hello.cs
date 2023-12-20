using System;

namespace ConsoleApplication1
{
    public class Hello
    {
        private int hour;
        private int jourDeSemaine;
        private DateTime ajd;
        public DateTime ThisDateTime
        {
            set
            {
                hour = value.Hour;
                jourDeSemaine = (int) value.DayOfWeek;
                ajd = value;
            }
            get { return ajd; }
        }

        public int message
        {
            set { getHelloMessage();}
            get { 
                return 1;
            }
        }

        private int shiftStart;
        private int shiftEnd;
        private int afternoon;
        
        public Hello()
        {
            ThisDateTime = DateTime.Now;
            shiftStart = 9;
            shiftEnd = 18;
            afternoon = 13;
        }

        public Hello(int start, int aprem, int end)
        {
            ThisDateTime = DateTime.Now;
            shiftStart = start;
            shiftEnd = aprem;
            afternoon = end;
        }

        public void getHelloMessage()
        {
            
            if (isWeekend(ThisDateTime))
            {
                Console.Write("Bon weekend "+Environment.UserName+" ");
            }
            else if (hour>shiftStart)
            {
                Console.Write("Bonjour "+Environment.UserName+" ");
            }
            else if (hour>afternoon)
            {
                Console.Write("Bon aprem "+Environment.UserName+" ");
            }else if (hour>shiftEnd)
            {
                Console.Write("Bonne soirée "+Environment.UserName+" ");
            }
        }
        public bool isWeekend(DateTime day)
        {
            return  (day.DayOfWeek==DayOfWeek.Saturday || day.DayOfWeek==DayOfWeek.Sunday || (day.DayOfWeek == DayOfWeek.Friday && day.Hour > shiftEnd) ||
                                       (day.DayOfWeek == DayOfWeek.Monday && day.Hour < shiftStart));
        }
    }
}