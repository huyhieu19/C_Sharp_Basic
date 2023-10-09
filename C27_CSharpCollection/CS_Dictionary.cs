namespace C27_CSharpCollection
{
    internal class CsDictionary
    {
        // Dictionary<TKey, TValue> is a map. For a given key there can be one value in the dictionary
        public void CsDictionary1()
        {
            var people = new Dictionary<string, int>
            {
             { "John", 30 }, {"Mary", 35}, {"Jack", 40}
            };
            // Reading data
            Console.WriteLine(people["John"]); // 30
            // Console.WriteLine(people["George"]); // throws KeyNotFoundException

            int age;
            if (people.TryGetValue("Mary", out age))
            {
                Console.WriteLine(age); // 35
            }

            // Adding and changing data
            people["John"] = 40; // Overwriting values this way is ok
            // people.Add("John", 40); // Throws ArgumentException since "John" already exists

            // Iterating through contents
            foreach (KeyValuePair<string, int> person in people)
            {
                Console.WriteLine("Name={0}, Age={1}", person.Key, person.Value);
            }
            foreach (string name in people.Keys)
            {
                Console.WriteLine("Name={0}", name);
            }
            foreach (int age1 in people.Values)
            {
                Console.WriteLine("Age={0}", age1);
            }

            // Duplicate key when using collection initialization
            var people1 = new Dictionary<string, int>
            {
                { "John", 30 }, {"Mary", 35}, {"Jack", 40}, {"Jack", 40}
            }; // throws ArgumentException since "Jack" already exists
            foreach (KeyValuePair<string, int> person in people1)
            {
                Console.WriteLine("Name={0}, Age={1}", person.Key, person.Value);
            }

        }
    }
}
