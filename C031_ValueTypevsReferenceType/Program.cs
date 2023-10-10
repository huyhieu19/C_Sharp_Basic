using System;
using System.Xml.Linq;

namespace C031_ValueTypevsReferenceType // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            RefOutKeyword();
            Assignment();

            DifferenceRefvsOut();
        }
        #region Section 31.1: Passing by reference using ref keyword
        static void Callee(int a)
        {
            a += 5;
            Console.WriteLine("Inside Callee a : {0}", a); // 25
        }
        static void CalleeRef(ref int a)
        {
            a += 10;
            Console.WriteLine("Inside CalleeRef a : {0}", a); // 30
        }
        static void CalleeOut(out int a)
        {
            // can't use a+=15 since for this method 'a' is not intialized only declared in the method declaration
             a = 25; //has to be initialized
            Console.WriteLine("Inside CalleeOut a : {0}", a); // 25
        }
        static void RefOutKeyword()
        {
            int a = 20;
            Console.WriteLine("Inside Main - Before Callee: a = {0}", a); // 20
            Callee(a);
            Console.WriteLine("Inside Main - After Callee: a = {0}", a); // 20
            Console.WriteLine();
            Console.WriteLine("Inside Main - Before CalleeRef: a = {0}", a); // 20
            CalleeRef(ref a);
            Console.WriteLine("Inside Main - After CalleeRef: a = {0}", a); // 30
            Console.WriteLine();
            Console.WriteLine("Inside Main - Before CalleeOut: a = {0}", a); // 30
            CalleeOut(out a);
            Console.WriteLine("Inside Main - After CalleeOut: a = {0}", a); // 25
        }
        #endregion

        #region Section 31.4: Assignment

        /*
         Assigning to a variable of a List<int> does not create a copy of the List<int>. Instead, it copies the reference to the List<int>. We call types that behave this way reference types.
         */
        private static void Assignment()
        {
            List<int> a = new List<int>() { 1 };

            List<int> b = a;
            int[] array = new int[a.Count];
            a.CopyTo(array);

            a.Add(5);

            Console.WriteLine(a.Count); // 2
            Console.WriteLine(b.Count); // 2


            List<int> c = b;
            Console.WriteLine(c.Count); // 2

            Console.WriteLine(array.Length); // 1

        }
        #endregion

        #region Section 31.5: Dierence with method parameters ref and out

        /*
            There are two possible ways to pass a value type by reference: ref and out. The difference is that by passing it with
            ref the value must be initialized but not when passing it with out. Using out ensures that the variable has a value
            after the method call
         */
        private static void DifferenceRefvsOut()
        {
            TestOut();
            TestRef();
        }
        static void ByRef(ref int value)
        {
            Console.WriteLine(nameof(ByRef) + value);
            value += 4;
            Console.WriteLine(nameof(ByRef) + value);
        }
        static void ByOut(out int value)
        {
            // value += 4; // CS0269: Use of unassigned out parameter `value' 
            // Console.WriteLine(nameof(ByOut) + value); // CS0269: Use of unassigned out parameter `value' 
            value = 4;
            Console.WriteLine(nameof(ByOut) + value);
        }
        static void TestOut()
        {
            int outValue1;
            ByOut(out outValue1); // prints 4
            int outValue2 = 10; // does not make any sense for out
            ByOut(out outValue2); // prints 4
        }
        static void TestRef()
        {
            int refValue1; // if use this variable for ref -> must create value initial for variable
            // ByRef(ref refValue1); // S0165 Use of unassigned local variable 'refValue'
            int refValue2 = 0;
            ByRef(ref refValue2); // prints 0 and 4
            int refValue3 = 10;
            ByRef(ref refValue3); // prints 10 and 14
        }
        /*
         The catch is that by using out the parameter must be initialized before leaving the method, therefore the following method is possible with ref but not with out:
         */
        static void EmtyRef(bool condition, ref int value)
        {
            if (condition)
            {
                value += 10;
            }
        }
        //static void EmtyOut(bool condition, out int value)
        //{
        //    if (condition)
        //    {
        //        value = 10;
        //    }
        //} //CS0177: The out parameter 'value' must be assigned before control leaves the current method

        // This is because if condition does not hold, value goes unassigned.
        #endregion

        #region Section 31.6: Passing by reference
        /**
            If you want the Value Types vs Reference Types in methods example to work properly, use the ref keyword in your
            method signature for the parameter you want to pass by reference, as well as when you call the method.

            public static void Main(string[] args)
            {
             ...
             DoubleNumber(ref number); // calling code
             Console.WriteLine(number); // outputs 8
             ...
            }
            public void DoubleNumber(ref int number)
            {
             number += number;
            }

            Making these changes would make the number update as expected, meaning the console output for number would
            be 8.

         */
        #endregion

    }
}