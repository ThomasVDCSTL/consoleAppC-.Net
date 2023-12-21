using System;

namespace ConsoleApplication1
{
    public class FakeTime : iTime
    {

        private DateTime _time;
        
        public FakeTime(DateTime time)
        {
            _time = time;
        }
        
        public DateTime getTime()
        {
            return _time;
        }
        
    }
}