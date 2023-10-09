namespace C27_CSharpCollection
{
    internal class CsHashSet
    {

        /*
         This is a coletion od unique item, with O(1) lookup
         */
        public void CSHashSetLookup()
        {

            HashSet<int> validStoryPointValues = new HashSet<int>() { 1, 2, 3, 5, 8, 13, 21 };
            var timeStart = DateTime.Now;
            bool containsEight = validStoryPointValues.Contains(8); // O(1)
            var time = DateTime.Now.Subtract(timeStart);
            Console.WriteLine(containsEight);
            Console.WriteLine("Time find in HashSet: {0}", time);
        }
        // By way of comparison, doing a Contains on a List yields poorer performance:

        public void CSListLookup()
        {
            List<int> validStoryPointValues = new List<int>() { 1, 2, 3, 5, 8, 13, 21 };
            var timeStart = DateTime.Now;
            bool containsEight = validStoryPointValues.Contains(8); // O(n)
            var time = DateTime.Now.Subtract(timeStart);
            Console.WriteLine(containsEight);
            Console.WriteLine("Time find in List: {0}", time);
        }
        /*
         HashSet.Contains uses a hash table, so that lookups are extremely fast, regardless of the number of items in the
collection.
        */
    }
}
