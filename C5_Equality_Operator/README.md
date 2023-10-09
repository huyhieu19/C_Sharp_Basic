Section5.1: Loại đẳng thức trong C# và toán tử đẳng thức.

Trong C# có hai loại đẳng thức khác nhau: là đẳng thức tham chiếu và đẳng thức giá trị. Giá trị bình đẳng là ý nghĩa thường được hiểu của sự bình đẳng: Nó có nghĩa là 2 đối tượng chứa cùng 1 giá trị. Ví dụ có hai số nguyên có 2 giá trị bằng nhau. Bình đẳng tham chiếu có nghĩa là không có hai đối tượng để so sánh. Thay vào đó, có hai tham chiếu đối tượng, cả hai đều tham chiếu đến cùng một đối tượng.

For predefined value types, the equality operator (==) returns true if the values of its operands are equal, false otherwise. For reference types other than string, == returns true if its two operands refer to the same object. For the string type, == compares the values of the strings.
