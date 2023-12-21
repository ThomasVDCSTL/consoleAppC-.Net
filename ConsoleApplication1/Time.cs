using System;

namespace ConsoleApplication1
{
    public class Time : iTime
    {
        public DateTime getTime()
        {
            return DateTime.Now;

        }
    }
}