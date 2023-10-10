# Chapter 35: Dynamic type
## Section 35.1: Creating a dynamic object with properties
```
using System;
using System.Dynamic;
dynamic info = new ExpandoObject();
info.Id = 123;
info.Another = 456;
Console.WriteLine(info.Another);
// 456
Console.WriteLine(info.DoesntExist);
// Throws RuntimeBinderException
```
## Section 35.2: Creating a dynamic variable
```
dynamic foo = 123;
Console.WriteLine(foo + 234);
// 357 Console.WriteLine(foo.ToUpper())
// RuntimeBinderException, since int doesn't have a ToUpper method
foo = "123";
Console.WriteLine(foo + 234);
// 123234
Console.WriteLine(foo.ToUpper()):
// NOW A STRING
```

## Section 35.3: Returning dynamic
```
using System;
public static void Main()
{
	 var value = GetValue();
	 Console.WriteLine(value);
	 // dynamics are useful!
}
private static dynamic GetValue()
{
	return "dynamics are useful!";
}
```
## Section 35.4: Handling Specific Types Unknown at Compile Time
The following output equivalent results:
```
class IfElseExample
{
 public string DebugToString(object a)
 {
	 if (a is StringBuilder)
	 {
		return DebugToStringInternal(a as StringBuilder);
	 }
	 else if (a is List<string>)
	 {
		return DebugToStringInternal(a as List<string>);
	 }
	 else
	 {
		return a.ToString();
	 }
 }
 private string DebugToStringInternal(object a)
 {
	 // Fall Back
	 return a.ToString();
 }
 private string DebugToStringInternal(StringBuilder sb)
 {
	return $"StringBuilder - Capacity: {sb.Capacity}, MaxCapacity: {sb.MaxCapacity}, Value: {sb.ToString()}";
 }
 private string DebugToStringInternal(List<string> list)
 {
	return $"List<string> - Count: {list.Count}, Value: {Environment.NewLine + "\t" + string.Join(Environment.NewLine + "\t", list.ToArray())}";
 }
}
class DynamicExample
{
 public string DebugToString(object a)
 {
	return DebugToStringInternal((dynamic)a);
 }
 private string DebugToStringInternal(object a)
 {
	 // Fall Back
	 return a.ToString();
 }
 private string DebugToStringInternal(StringBuilder sb)
 {
	return $"StringBuilder - Capacity: {sb.Capacity}, MaxCapacity: {sb.MaxCapacity}, Value: {sb.ToString()}";
 }
 private string DebugToStringInternal(List<string> list)
 {
	return $"List<string> - Count: {list.Count}, Value: {Environment.NewLine + "\t" + string.Join(Environment.NewLine + "\t", list.ToArray())}";
 }
}
```
The advantage to the dynamic, is adding a new Type to handle just requires adding an overload of DebugToStringInternal of the new type. Also eliminates the need to manually cast it to the type as well.