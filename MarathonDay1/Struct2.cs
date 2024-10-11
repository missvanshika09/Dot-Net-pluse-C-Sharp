
namespace Structure
{
    struct SS
    {
        public int x;
        public int y;
        public static int num(string n)

        {
            int x = int.Parse(n);
            Console.WriteLine("Conversion method");
            Console.WriteLine(x);
            return x;
        }
        public static int add(int z, int j)
        {

            Console.WriteLine("Add method");
            return z + j;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String n1 = "5";
            String n2 = "9";
            int x = SS.num(n1);
            int y = SS.num(n2);
            int result = SS.add(x,y);
            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}


### Major Differences

1. **Purpose and Functionality**:
   - **`Point` Struct**: This struct represents a geometric point in a 2D space with `X` and `Y` coordinates. It provides a way to encapsulate related data and methods for working with that data (like displaying coordinates).
   - **`convert_str_num` Struct**: This struct is more functional, focusing on utility methods for converting strings to integers and performing arithmetic operations. It doesn't hold state in the form of fields but provides static methods for specific operations.

2. **Use of Static Methods**:
   - **`convert_str_num` Struct**: All methods are static, which means they don't require an instance of the struct to be called. This makes it behave more like a utility class, where you call methods directly on the struct without creating an object.
   - **`Point` Struct**: The `Point` struct has instance methods and fields, meaning you typically create an instance of `Point` to access its data and methods. This is more in line with how structs are traditionally used in C# to represent data with associated behavior.

3. **State Management**:
   - **`Point` Struct**: Contains instance fields (`X` and `Y`) that hold state and can be modified. The behavior is tied to the specific instance of `Point`.
   - **`convert_str_num` Struct**: Lacks instance fields; it operates purely through methods. There’s no state associated with it, making it a stateless utility.

4. **Constructor Behavior**:
   - **`Point` Struct**: It has constructors (including a problematic default one), which is common in data structures to initialize state.
   - **`convert_str_num` Struct**: Does not define any constructors since it only contains static methods and no instance fields.

### Why Use Each Structure

- **`Point` Struct**: Used when you want to encapsulate data that naturally belongs together and may have behaviors associated with that data. This is ideal for geometric calculations or representing entities with properties (like coordinates).

- **`convert_str_num` Struct**: Ideal for providing utility functions that don't need to maintain state. This struct acts like a static helper class, allowing easy access to conversion and calculation methods without needing to instantiate an object.


