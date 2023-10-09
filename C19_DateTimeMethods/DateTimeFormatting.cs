namespace C19_DateTimeMethods
{
    internal static class DateTimeFormatting
    {
        public static void Get()
        {
            // Create Date
            DateTime dt = new DateTime(2016, 08, 01, 18, 50, 23, 230);

            var t = string.Format("{0:t}", dt); // "6:50 PM"                    ->   ShortTime
            Console.WriteLine($"ShortTime: {t,-50}");
            var d = string.Format("{0:d}", dt);// "8/1/2016"                    ->  ShortDate
            Console.WriteLine("ShortDate:\t\t\t {0}", d);
            string T = string.Format("{0:T}", dt);// "6:50:23 PM"              ->   LongTime
            Console.WriteLine("LongTime:\t\t\t {0}", T);
            string D = string.Format("{0:D}", dt);// "Monday, August 1, 2016"  ->  LongDate
            Console.WriteLine("LongDate:\t\t\t {0}", D);
            string f = string.Format("{0:f}", dt); // "Monday, August 1, 2016 6:50 PM" ->  LongDate + ShortTime
            Console.WriteLine("LongDate + ShortTime:\t\t {0}", f);
            var F = String.Format("{0:F}", dt); // "Monday, August 1, 2016 6:50:23 PM" -> FullDateTime
            Console.WriteLine("FullDateTime:\t\t\t {0}", F);
            var g = string.Format("{0:g}", dt);// "8/1/2016 6:50 PM"        ->       ShortDate+ShortTime
            Console.WriteLine("ShortDate+ShortTime:\t\t {0}", g);
            var G = String.Format("{0:G}", dt); // "8/1/2016 6:50:23 PM" -> ShortDate+LongTime
            Console.WriteLine("ShortDate+LongTime:\t\t {0}", G);
            var m = String.Format("{0:m}", dt); // "August 1" MonthDay
            Console.WriteLine("MonthDay:\t\t\t {0}", m);
            var y = String.Format("{0:y}", dt); // "August 2016" YearMonth
            Console.WriteLine("YearMonth:\t\t\t {0}", y);
            var r = String.Format("{0:r}", dt); // "SMon, 01 Aug 2016 18:50:23 GMT" RFC1123
            Console.WriteLine("RFC1123:\t\t\t {0}", r);
            var s = String.Format("{0:s}", dt); // "2016-08-01T18:50:23" SortableDateTime
            Console.WriteLine("SortableDateTime:\t\t {0}", s);
            var u = String.Format("{0:u}", dt); // "2016-08-01 18:50:23Z" UniversalSortableDateTime
            Console.WriteLine("UniversalSortableDateTime:\t {0}", u);



            var year = String.Format("{0:y yy yyy yyyy}", dt); // "16 16 2016 2016" year
            var month = String.Format("{0:M MM MMM MMMM}", dt); // "8 08 Aug August" month
            var day = String.Format("{0:d dd ddd dddd}", dt); // "1 01 Mon Monday" day
            var hour = String.Format("{0:h hh H HH}", dt); // "6 06 18 18" hour 12/24
            var minute = String.Format("{0:m mm}", dt); // "50 50" minute
            var second = String.Format("{0:s ss}", dt); // "23 23" second
            var fraction = String.Format("{0:f ff fff ffff}", dt); // "2 23 230 2300" sec.fraction
            var fraction2 = String.Format("{0:F FF FFF FFFF}", dt); // "2 23 23 23" without zeroes
            var period = String.Format("{0:t tt}", dt); // "P PM" A.M. or P.M.
            var zone = String.Format("{0:z zz zzz}", dt); // "+0 +00 +00:00" time zone

            Console.WriteLine(@$"
Year: {year},
Month: {month},
Day: {day},
hour 12/24: {hour},
minute: {minute},
second: {second},
fraction: {fraction},
fraction2: {fraction2},
period: {period},
zone: {zone}");
        }
    }
}

/*
     Custom DateTime Formatting
    There are following custom format specifiers:
    y (year)
    M (month)
    d (day)
    h (hour 12)
    H (hour 24)
    m (minute)
    s (second)
    f (second fraction)
    F (second fraction, trailing zeroes are trimmed)
    t (P.M or A.M)
    z (time zone).
 */