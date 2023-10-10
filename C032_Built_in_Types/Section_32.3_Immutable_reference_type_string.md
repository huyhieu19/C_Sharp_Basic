# Section 32.3: Immutable reference type - string
```
// assign string from a string literal
string s = "hello";
// assign string from an array of characters
char[] chars = new char[] { 'h', 'e', 'l', 'l', 'o' };
string s = new string(chars, 0, chars.Length);
// assign string from a char pointer, derived from a string
string s;
unsafe
{
	 fixed (char* charPointer = "hello")
	 {
		s = new string(charPointer);
	 }
}
```

In C#, `string` is a special type of reference type known as an "immutable reference type." This means that once a string object is created, its value cannot be changed. Any operation that appears to modify a string actually creates a new string object with the modified value. This immutability property has several important implications:

1. **String Modification:** When you perform operations that change a string, such as concatenation or substitution, it creates a new string with the result, leaving the original string unchanged. This behavior ensures that strings are thread-safe.

   ```csharp
   string original = "Hello";
   string modified = original + ", World"; // Creates a new string
   ```

2. **String Comparison:** When comparing strings for equality, you should use methods like `string.Equals` or the `==` operator, which compare the content of the strings, not their references.

   ```csharp
   string str1 = "Hello";
   string str2 = "Hello";
   bool areEqual = string.Equals(str1, str2); // true
   ```

3. **Memory Efficiency:** Immutability allows for memory optimizations. Repeated string literals with the same value are often interned, meaning they share the same memory location. This reduces memory consumption.

4. **Thread Safety:** Immutable strings are inherently thread-safe because they cannot be changed once created. Multiple threads can safely access and use the same string object without concerns about concurrent modifications.

5. **Value Semantics:** Immutable strings have value semantics. This means that when you pass a string to a method or assign it to another variable, you're working with a copy of the string's value, not a reference to the original string. Modifications to one string won't affect the others.

   ```csharp
   string greeting = "Hello";
   string copy = greeting; // Creates a copy of the value
   ```

Immutable reference types like `string` provide predictable and reliable behavior, making them suitable for scenarios where data integrity, thread safety, and predictability are crucial.