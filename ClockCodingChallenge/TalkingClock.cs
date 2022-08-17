using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockCodingChallenge
{
    public class TalkingClock
    {
        private static readonly string[] unitsArray = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static readonly string[] tensArray = { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty" };

        public string GetHumanFriendlyTime(string time)
        {
            int hour = 0;
            int min = 0;
            string minText = string.Empty;
            string minDisplayText = Contants.Past;

            if(!time.Contains(':'))
            {
                return Contants.InvalidTime;
            }
            var splitHourAndMinute = SplitString(time);
            var isValidSplitString = IsValidSplitString(splitHourAndMinute);
            if(isValidSplitString)
            {
                ParseParseStringToInt(splitHourAndMinute, out hour, out min);
            }
            else
            {
                return Contants.InvalidTime;
            }
            if (hour > Contants.TwentyThree || min > Contants.Sixty)
            {
                return Contants.InvalidTime;
            }
            hour = hour > Contants.Twelve ? hour - Contants.Twelve : hour;

            string hourText = unitsArray[hour];

            if (min == Contants.Zero)
            {
                return hourText + Contants.OClock;
            }
            if (min == Contants.Thirty)
            {
                return Contants.HalfPast + hourText;
            }
            if (min > Contants.Thirty)
            {
                min = Contants.Sixty - min;
                minDisplayText = Contants.To;
                hour++;
                hourText = unitsArray[hour];
            }
            minText = GetMinText(minDisplayText, min);
            return minText + minDisplayText + hourText;
        }

        private void ParseParseStringToInt(string[] splitHourAndMinute, out int hour, out int min)
        {
            int.TryParse(splitHourAndMinute[0], out hour);
            int.TryParse(splitHourAndMinute[1], out min);
        }

        private static string[] SplitString(string time)
        {
            return time.Split(':');
        }

        private static bool IsValidSplitString(string[] splitString)
        {
            if (!string.IsNullOrEmpty(splitString[0]) && 
                !string.IsNullOrEmpty(splitString[1]))
                return true;
            return false;
        }

        private string GetMinText(string minDisplayText, int min)
        {
            if (min >= Contants.Twenty)
            {
                minDisplayText = string.IsNullOrEmpty(minDisplayText) ? Contants.Past : minDisplayText;
                return tensArray[min / Contants.Ten] + " " + unitsArray[min % Contants.Ten].ToLower();
            }
            minDisplayText = Contants.Past;

            return unitsArray[min];
        }
    }
}
