namespace C19_DateTimeMethods
{
    internal static class DateTimeParse
    {
        public static void Get()
        {
            // Converts the string representation of a date and time to its DateTime equivalent
            var dateTime = DateTime.Parse("14:23 22 Jul 2016");
            Console.WriteLine(dateTime.ToString());
        }
    }
}
