using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockCodingChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TalkingClock talkClock = new TalkingClock();
            string input = string.Empty;
            if(args.Count() == 0)
            {
                input = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                input = args[0];
            }
            var result = talkClock.GetHumanFriendlyTime(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
