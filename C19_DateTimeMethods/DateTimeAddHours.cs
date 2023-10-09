namespace C19_DateTimeMethods
{
    internal static class DateTimeAddHours
    {

        public static void DateTimeAddHours1()
        {
            double[] hours = { .08333, .16667, .25, .33333, .5, .66667, 1, 2, 29, 30, 31, 90, 365 };
            DateTime dateValue = new DateTime(2009, 3, 1, 12, 0, 0);
            foreach (double hour in hours)
                Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour,
                dateValue.AddHours(hour));
        }
    }
}
