namespace C032_Built_in_Types // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        #region Section 32.1: Conversion of boxed value types
        static void ConversionBoxed()
        {
            object boxedInt = (int)1; // int boxed in an object
            long unboxedInt1 = (long)boxedInt; // invalid cast
            long unboxedInt2 = (long)(int)boxedInt; // valid
        }
        #endregion

        #region Section 32.2: Comparisons with boxed value types
        static void Comparisonswithboxed()
        {
            object left = (int)1; // int in an object box
            object right = (int)1; // int in an object box
            var comparison1 = left == right; // false

            var comparison2 = left.Equals(right); // true

            var comparison3 = (int)left == (int)right; // true
        }

        #endregion

        #region Section 32.3: Immutable reference type - string

        #endregion

        #region Section 32.4: Value type - char
        #endregion

        #region Section 32.5: Value type - short, int, long (signed 16 bit, 32 bit, 64 bit integers)

        #endregion

        #region Section 32.6: Value type - ushort, uint, ulong (unsigned 16 bit, 32 bit, 64 bit integers)
        #endregion

        #region Section 32.7: Value type - bool
        #endregion

    }
}