namespace C19_DateTimeMethods
{
    internal static class DateTimeLearn
    {
        // Section 19.5: DateTime.TryParse(String, DateTime)
        public static void DateTimeTryParse()
        {
            string[] dateTimeStrings = new[]{
                "14:23 22 Jul 2016",
                "99:23 2x Jul 2016",
                "22/7/2016 14:23:00"
                };
            foreach (var dateTimeString in dateTimeStrings)
            {
                DateTime dateTime;
                bool wasParsed = DateTime.TryParse(dateTimeString, out dateTime);
                string result = dateTimeString +
                (wasParsed
                ? $" was parsed to {dateTime}"
                : " can't be parsed to DateTime");
                Console.WriteLine(result);
            }
        }
        // Section 19.6: DateTime.AddMilliseconds(Double)
        public static void DateTimeAddMilliseconds()
        {
            string dateFormat = "MM/dd/yyyy hh:mm:ss.fffffff";
            DateTime date1 = new DateTime(2010, 9, 8, 16, 0, 0);
            Console.WriteLine("Original date: {0} ({1:N0} ticks)\n", date1.ToString(dateFormat), date1.Ticks);
            DateTime date2 = date1.AddMilliseconds(1);
            Console.WriteLine("Second date: {0} ({1:N0} ticks)", date2.ToString(dateFormat), date2.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)\n", date2 - date1, date2.Ticks - date1.Ticks);
            DateTime date3 = date1.AddMilliseconds(1.5);
            Console.WriteLine("Third date: {0} ({1:N0} ticks)", date3.ToString(dateFormat), date3.Ticks);
            Console.WriteLine("Difference between dates: {0} ({1:N0} ticks)", date3 - date1, date3.Ticks - date1.Ticks);
        }
        // Section 19.7: DateTime.Compare(DateTime t1, DateTime t2)
        public static void DateTimeCompare(DateTime date1, DateTime date2)
        {
            int result = DateTime.Compare(date1, date2);
            string relationship;
            if (result < 0)
                relationship = "is earlier than";
            else if (result == 0)
                relationship = "is the same time as";
            else relationship = "is later than";
            Console.WriteLine("{0} {1} {2}", date1, relationship, date2);
        }
        // Section 19.8: DateTime.DaysInMonth(Int32, Int32)
        public static void DateTimeDayInMonth(int month1 = 7, int month2 = 2)
        {
            int daysInJuly = System.DateTime.DaysInMonth(2001, month1);
            Console.WriteLine($"DaysInMonth: {2001}/{month1} is " + daysInJuly);
            // daysInFeb gets 28 because the year 1998 was not a leap year.
            int daysInFeb = System.DateTime.DaysInMonth(1998, month2);
            Console.WriteLine($"DaysInMonth: {1998}/{month2} is " + daysInFeb);
            // daysInFebLeap gets 29 because the year 1996 was a leap year.
            int daysInFebLeap = System.DateTime.DaysInMonth(1996, month2);
            Console.WriteLine($"DaysInMonth: {1996}/{month2} is " + daysInFebLeap);
        }
        // Section 19.9: DateTime.AddYears(Int32)
        public static void DateTimeDayAddYear()
        {
            DateTime baseDate = new DateTime(2000, 2, 29);
            Console.WriteLine("Base Date: {0:d}\n", baseDate);
            // Show dates of previous fifteen years.
            for (int ctr = -1; ctr >= -15; ctr--)
                Console.WriteLine("{0,2} year(s) ago:{1:d}",
                Math.Abs(ctr), baseDate.AddYears(ctr));
            Console.WriteLine();
            // Show dates of next fifteen years.
            for (int ctr = 1; ctr <= 15; ctr++)
                Console.WriteLine("{0,2} year(s) from now: {1:d}",
                ctr, baseDate.AddYears(ctr));
        }

    }
}
