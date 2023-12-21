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
        

        private int shiftStart;
        private int shiftEnd;
        private int afternoon;
        
        public Hello() 
            : this(9,18,13)
        {
        }

        public Hello(int start, int aprem, int end) 
            : this(start,aprem,end, new Time())
        {
        }
        public Hello(int start, int aprem, int end, iTime time)
        {
            ThisDateTime = time.getTime();
            shiftStart = start;
            shiftEnd = aprem;
            afternoon = end;
        }

        public string getHelloMessage()
        {
            
            if (isWeekend(ThisDateTime))
            {
                return("Bon weekend "+Environment.UserName+" ");
            }
            else if (hour>shiftEnd)
            {
                return("Bonsoir "+Environment.UserName+" ");
            }
            else if (hour>afternoon)
            {
                return("Bon aprem "+Environment.UserName+" ");
            }else 
            {
                return("Bonjour "+Environment.UserName+" ");
            }
        }
        public bool isWeekend(DateTime day)
        {
            return  (day.DayOfWeek==DayOfWeek.Saturday || day.DayOfWeek==DayOfWeek.Sunday || (day.DayOfWeek == DayOfWeek.Friday && day.Hour > shiftEnd) ||
                                       (day.DayOfWeek == DayOfWeek.Monday && day.Hour < shiftStart));
        }
    }
}