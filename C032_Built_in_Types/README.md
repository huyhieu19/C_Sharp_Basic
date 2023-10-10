# Section 32.1: Conversion of boxed value types
## Boxing và Unboxing trong C#

Boxing và Unboxing là 2 khái niệm quan trọng trong C#. Chúng liên quan đến việc chuyển đổi giữa kiểu dữ liệu giữa các kiểu dữ liệu giá trị (value types) và kiểu dữ liệu tham chiếu (reference types).

### Boxing:
Boxing là quá trình chuyển đổi một giá trị kiểu dữ liệu giá trị (value type) thành một đối tượng kiểu dữ liệu tham chiếu (reference type), thường là kiểu object hoặc các kiểu dữ liệu tham chiếu khác. Khi một giá trị được boxed, nó được bọc trong một đối tượng, và bạn có thể thao tác với nó như là một đối tượng tham chiếu thông thường.

Ví dụ về boxing:

```csharp
int number = 42;
object boxedNumber = number; // Boxing
```

### Unboxing:
Unboxing là quá trình chuyển đổi một đối tượng kiểu dữ liệu tham chiếu (reference type), mà thực chất là một giá trị kiểu dữ liệu giá trị bên trong, trở lại kiểu dữ liệu giá trị ban đầu. Để thực hiện unboxing, bạn cần thực hiện việc ép kiểu từ kiểu dữ liệu tham chiếu về kiểu dữ liệu giá trị.

Ví dụ về unboxing:
```csharp
object boxedNumber = 42;
int unboxedNumber = (int)boxedNumber; // Unboxing
```

*`Chú ý rằng unboxing có thể gây ra lỗi ngoại lệ InvalidCastException nếu bạn ép kiểu không hợp lệ.`*

*`Boxing và unboxing có thể gây ra overhead về hiệu suất, vì chúng đòi hỏi thêm bộ nhớ và thời gian để thực hiện chuyển đổi. Vì vậy, nên sử dụng chúng cẩn thận và hợp lý để tránh ảnh hưởng đến hiệu suất của ứng dụng.`*



# Section 32.2: Comparisons with boxed value types

If value types are assigned to variables of type object they are boxed - the value is stored in an instance of a
System.Object. This can lead to unintended consequences when comparing values with ==, e.g.:

```
object left = (int)1; // int in an object box
object right = (int)1; // int in an object box

var comparison1 = left == right; // false
```
This can be avoided by using the overloaded Equals method, which will give the expected result.
```
var comparison2 = left.Equals(right); // true
```
Alternatively, the same could be done by unboxing the left and right variables so that the int values are compared:
```
var comparison3 = (int)left == (int)right; // true
```

Trong C#, so sánh giữa các giá trị boxed (boxed values) có thể gây ra sự hiểu lầm, do kiểu giá trị (value type) ban đầu đã bị đóng gói (boxed) thành kiểu tham chiếu (reference type). Điều này có thể gây ra kết quả so sánh không như mong đợi. Dưới đây là một ví dụ minh họa:
```
int a = 5;
int b = 5;

object boxedA = a;
object boxedB = b;

bool result = (boxedA == boxedB); // Kết quả không phải là true
```

Trong ví dụ trên, biến a và b là kiểu giá trị int, và sau đó chúng được đóng gói thành các biến boxedA và boxedB kiểu object. Khi bạn so sánh boxedA và boxedB bằng toán tử ==, kết quả sẽ là false do chúng đang so sánh tham chiếu của hai đối tượng boxed, không phải giá trị của chúng.

Để thực hiện so sánh giữa các giá trị boxed mà không gây ra hiểu lầm, bạn nên trích xuất giá trị thực sự từ các biến boxed và sau đó so sánh chúng:
```
int unboxedA = (int)boxedA;
int unboxedB = (int)boxedB;

bool result = (unboxedA == unboxedB); // Kết quả là true
```
Trong trường hợp này, chúng ta đã trích xuất giá trị int thực sự từ các biến boxedA và boxedB trước khi so sánh, và kết quả là true vì giá trị thực sự của unboxedA và unboxedB giống nhau.


Lưu ý rằng so sánh giữa các giá trị boxed có thể gây ra vấn đề về hiệu suất và thất bại nếu các kiểu giá trị được đóng gói không phải là kiểu dữ liệu cơ bản (primitive data types) như int, float, double,... trong trường hợp đó, bạn cần sử dụng các phương thức so sánh phù hợp như Equals.

**Dưới đây là ví dụ về cách sử dụng phương thức `Equals` để so sánh giữa các giá trị boxed:**

```csharp
int a = 5;
int b = 5;

object boxedA = a;
object boxedB = b;

bool result = boxedA.Equals(boxedB); // Sử dụng phương thức Equals
```

*Trong ví dụ này, thay vì sử dụng toán tử `==` để so sánh giữa các biến boxed `boxedA` và `boxedB`, chúng ta đã sử dụng phương thức `Equals`. Phương thức `Equals` kiểm tra giá trị thực sự của các biến và trả về kết quả đúng (true) nếu giá trị của chúng giống nhau. Trong trường hợp này, kết quả là `true` vì giá trị của `boxedA` và `boxedB` đều là 5.*

*Lưu ý rằng việc sử dụng `Equals` thường là cách an toàn hơn khi so sánh giữa các giá trị boxed, vì nó sẽ kiểm tra giá trị thực sự của các biến và tránh được các vấn đề liên quan đến tham chiếu.*

