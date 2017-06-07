using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime endDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int counter = 0;
   


            for (DateTime i = startDay; i <= endDay; i = i.AddDays(1))
            {
                DateTime[] nonWorkingDays = new DateTime[12];
                nonWorkingDays[0] = new DateTime(i.Year, 01, 01);
                nonWorkingDays[1] = new DateTime(i.Year, 03, 03);
                nonWorkingDays[2] = new DateTime(i.Year, 05, 01);
                nonWorkingDays[3] = new DateTime(i.Year, 05, 06);
                nonWorkingDays[4] = new DateTime(i.Year, 05, 24);
                nonWorkingDays[5] = new DateTime(i.Year, 09, 06);
                nonWorkingDays[6] = new DateTime(i.Year, 09, 22);
                nonWorkingDays[7] = new DateTime(i.Year, 11, 01);
                nonWorkingDays[9] = new DateTime(i.Year, 12, 24);
                nonWorkingDays[10] = new DateTime(i.Year, 12, 25);
                nonWorkingDays[11] = new DateTime(i.Year, 12, 26);

                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (!nonWorkingDays.Contains(i))
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(counter);
        }
    }
}
