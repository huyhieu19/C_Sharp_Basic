namespace C47_Methods // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        #region Section 47.1: Calling a Method
        static void CallingaMethod()
        {
            // Single argument
            Console.WriteLine("Hello world");

            // Multiple arguments
            string name = "User";
            Console.WriteLine("Hello, {0}!", name);

            // Calling a static method and storing its return value:
            string input = Console.ReadLine();

            // Calling instance method:
            int x = 24;
            string xAsString = x.ToString();

            // Calling a generic method
            DateTime[] dates = CreateArray<DateTime>(8);
        }

        private static T[] CreateArray<T>(int v)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Section 47.2: Anonymous method
        // Anonymous methods provide a technique to pass a code block as a delegate paramter. They are methods with a body,but no name
        delegate int IntOp(int lhs, int rhs);
        static void AnonymousMethod()
        {


            // C# 2.0 definition
            IntOp add = delegate (int lhs, int rhs)
            {
                return lhs + rhs;
            };
            // C# 3.0 definition
            IntOp mul = (lhs, rhs) =>
            {
                return lhs * rhs;
            };
            // C# 3.0 definition - shorthand
            IntOp sub = (lhs, rhs) => lhs - rhs;
            // Calling each method
            Console.WriteLine("2 + 3 = " + add(2, 3));
            Console.WriteLine("2 * 3 = " + mul(2, 3));
            Console.WriteLine("2 - 3 = " + sub(2, 3));
        }
        #endregion
        #region Section 47.3: Declaring a Method
        #endregion
        #region Section 47.4: Parameters and Arguments
        #endregion
        #region Section 47.5: Return Types
        #endregion
        #region Section 47.6: Default Parameters
        #endregion
        #region Section 47.7: Method overloading

        #endregion
        #region Section 47.8: Access rights
        #endregion
    }
}