
// Section 19.2: DateTime.AddDays(Double)
namespace C019_DateTimeMethods
{
    public class DateTimeAddDays
    {
        public static void DateTimeAddDays1()
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(36);
            Console.WriteLine("Today: {0:dddd}", today);
            Console.WriteLine("36 days from today: {0:dddd}", answer);
        }
        public static void DateTimeAddDays2()
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(-3);
            Console.WriteLine("Today: {0:dddd}", today);
            Console.WriteLine("-3 days from today: {0:dddd}", answer);
        }
    }
}
