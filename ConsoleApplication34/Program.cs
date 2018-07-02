using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 359999;

            TimeSpan timespan = TimeSpan.FromSeconds(seconds);
            int day = timespan.Days;
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;
            string answer = "";

            if (day > 0)
            {
                int daytohour = day * 24;
                hour = hour + daytohour;
                answer = hour+":" + timespan.ToString(@"mm\:ss");
            }
            else
            {
               answer = timespan.ToString(@"hh\:mm\:ss");
            }
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}

