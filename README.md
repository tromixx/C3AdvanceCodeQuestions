# C3AdvanceCodeQuestions
Here is a C# Advance Code Questions repo that contains some questions that I build for everyone to get hands on into advance C# code skills.

The orfer of topics:
0. SOLID Principles
1. Hash Tables and Arrays
2. Lambda Expressions
3. Extension Methods 
4. Events and Delegates
5. Generics
6. LINQ
7. Async/Await
8. Binary and AVL Tress
9. Generic C# questions

0. Solid Principles:

Single Responsibility Principle: States that a class should have only one reason to change, meaning it should only have one job or responsibility. This principle helps in making classes more cohesive and less coupled.
Example: Having a class for ReportSaver and a different one for PrintReport

Open/Closed Principle: States that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. This means that the behavior of a module can be extended without modifying its source code.
Example:
public abstract class Shape
{
    public abstract double GetArea();
}
public class Circle : Shape 
{...}
public class Rectangle : Shape
{...}

Liskov Substitution Principle: States that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. In other words, a subclass should behave in such a way that it does not violate the expectations established by the superclass.

Interface Segregation Principle states that no client should be forced to depend on methods it does not use. This means that larger interfaces should be split into smaller, more specific ones so that clients only need to know about the methods that are relevant to them.
Example:
public interface IPrinter
{...}
public interface IScanner
{...}
public class MultifunctionPrinter : IPrinter, IScanner
{...}

Dependency Inversion Principle states that high-level modules should not depend on low-level modules. Both should depend on abstractions. Additionally, abstractions should not depend on details; details should depend on abstractions. This principle helps in reducing the coupling between different parts of the code.


1. Dictionaries and Arrays:


2. Lambda Expressions:
Lambda expressions are a concise way to represent anonymous methods using a special syntax.
They are often used with LINQ queries and delegate/event handlers.
Syntax: (parameters) => expression or (parameters) => { statements; }.


3. Extension Methods 
Extension methods allow you to "add" methods to existing types without modifying the original type or using inheritance.
They are defined as static methods but are called as if they were instance methods on the extended type.

4. Events and Delegates
A delegate is a type-safe function pointer that defines a method signature.
Delegates can point to methods with the same signature and return type.

5. Generics
Generics allow you to define classes, methods, delegates, and interfaces with a placeholder for the type of data they store and manipulate.
They increase code reusability, type safety, and performance.

6. LINQ
LINQ is a set of features that extends powerful query capabilities to the C# language syntax.
It allows querying of collections like arrays, enumerable classes, XML, relational databases, and more using a unified syntax.

7. Async/Await
async and await are keywords used for asynchronous programming.
async marks a method as asynchronous, while await pauses the method execution until the awaited task completes.

8. Binary and AVL Tress
A binary tree is a tree data structure where each node has at most two children, referred to as the left child and the right child.
AVL Tree:
An AVL tree is a self-balancing binary search tree.
It maintains the property that the heights of the two child subtrees of any node differ by at most one.


9. Generic C# questions:
### C# Interview Questions

1. **What is the difference between abstract and virtual methods in C#?**
   - **Abstract Methods:** Declared in an abstract class and must be implemented in derived classes. They do not have any implementation in the base class.
   - **Virtual Methods:** Can be overridden in derived classes. They have an implementation in the base class, but derived classes can provide their own implementation.

2. **What is the purpose of the using statement in C#?**
   - The `using` statement is used to ensure that `IDisposable` objects are disposed of properly. It defines a scope, at the end of which the object's `Dispose` method is called.

3. **What are extension methods in C#?**
   - Extension methods allow you to add new methods to existing types without modifying the original type. They are static methods in static classes, with the first parameter specifying the type they extend, using the `this` keyword.

4. **Explain the concept of delegates and events in C#.**
   - **Delegates:** Type-safe function pointers, allowing methods to be passed as parameters.
   - **Events:** A way for objects to communicate, allowing a publisher to notify subscribers when something happens. Events are based on delegates.

5. **What is LINQ and how is it used in C#?**
   - LINQ (Language Integrated Query) allows querying of collections using a SQL-like syntax directly in C#. It works with arrays, lists, and other collections, providing a standardized way to query and manipulate data.

6. **What is the difference between `IEnumerable<T>` and `IQueryable<T>`?**
   - **`IEnumerable<T>`:** Executes queries on collections in-memory, suitable for LINQ to Objects.
   - **`IQueryable<T>`:** Executes queries out-of-memory, suitable for LINQ to SQL and Entity Framework, enabling deferred execution and building dynamic queries.

7. **How do you implement exception handling in C#?**
   - Use `try`, `catch`, `finally` blocks to handle exceptions. The `try` block contains code that may throw exceptions, `catch` handles exceptions, and `finally` contains cleanup code.

8. **What are the `async` and `await` keywords in C#?**
   - `async` defines an asynchronous method, and `await` pauses the method execution until the awaited task completes, allowing other work to be done concurrently.

9. **What are generics in C# and why are they useful?**
   - Generics allow the creation of classes, methods, and interfaces with placeholders for data types. They provide type safety without compromising performance, enabling code reusability.

10. **Explain the difference between value types and reference types in C#.**
    - **Value Types:** Store data directly, allocated on the stack, e.g., `int`, `struct`.
    - **Reference Types:** Store a reference to data, allocated on the heap, e.g., `class`, `array`.

11. **What is the difference between `String` and `StringBuilder` in C#?**
    - `String` is immutable, creating a new instance for every modification.
    - `StringBuilder` is mutable, providing better performance for frequent string modifications.

12. **How do you implement inheritance in C#?**
    - Use the `:` symbol to inherit from a base class. The derived class inherits fields and methods from the base class.

13. **What is polymorphism and how is it implemented in C#?**
    - Polymorphism allows methods to do different things based on the object it is acting upon. It is implemented using method overriding and interfaces.

14. **What are the access modifiers in C# and what do they do?**
    - **public:** Accessible from any other code.
    - **private:** Accessible only within the containing class.
    - **protected:** Accessible within the containing class and derived classes.
    - **internal:** Accessible within the same assembly.
    - **protected internal:** Accessible within the same assembly and derived classes.

15. **Explain the concept of interfaces in C#.**
    - Interfaces define a contract that implementing classes must follow, providing method signatures without implementations. They enable multiple inheritance and polymorphism.

16. **What is a lambda expression in C#?**
    - A concise way to write anonymous methods using the `=>` syntax, often used in LINQ queries.

17. **How does garbage collection work in C#?**
    - Garbage collection automatically frees up memory by removing objects that are no longer in use. It works in the background, managed by the .NET runtime.

18. **What is a null reference exception and how do you handle it in C#?**
    - Occurs when attempting to use an object reference that is `null`. Handle it using null checks and the `?.` and `??` operators.

19. **What is the difference between `Array` and `List` in C#?**
    - **Array:** Fixed size, elements of the same type.
    - **List:** Dynamic size, more flexible, and provides additional methods for manipulation.

20. **How do you implement a singleton pattern in C#?**
    ```csharp
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }
    }
    ```

21. **What is the purpose of the `lock` statement in C#?**
    - The `lock` statement ensures that a block of code runs by only one thread at a time, providing thread safety.

22. **What is dependency injection and how is it used in C#?**
    - Dependency Injection (DI) is a design pattern where dependencies are injected into a class, rather than being created within the class. It promotes loose coupling and easier testing.

23. **How do you create a thread in C#?**
    ```csharp
    Thread thread = new Thread(new ThreadStart(MyMethod));
    thread.Start();
    ```

24. **What is the difference between `Task` and `Thread` in C#?**
    - **Task:** Higher-level abstraction, part of the Task Parallel Library, supports async programming.
    - **Thread:** Lower-level, represents an actual OS thread.

25. **What is the purpose of the `yield` keyword in C#?**
    - `yield` is used in iterator methods to return elements one at a time, allowing the caller to iterate through the collection.

26. **Explain the concept of reflection in C#.**
    - Reflection allows inspection and manipulation of types at runtime. It can be used to dynamically create instances, invoke methods, and access fields and properties.

27. **What is the `var` keyword in C#?**
    - The `var` keyword allows implicit typing, where the compiler infers the type based on the assigned value.

28. **How do you serialize and deserialize an object in C#?**
    ```csharp
    // Serialization
    using (Stream stream = File.Open("data.bin", FileMode.Create))
    {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, myObject);
    }

    // Deserialization
    using (Stream stream = File.Open("data.bin", FileMode.Open))
    {
        BinaryFormatter formatter = new BinaryFormatter();
        MyObject myObject = (MyObject)formatter.Deserialize(stream);
    }
    ```

29. **What are the differences between `public`, `private`, `protected`, and `internal` access modifiers in C#?**
    - **public:** Accessible from any code.
    - **private:** Accessible only within the containing class.
    - **protected:** Accessible within the containing class and derived classes.
    - **internal:** Accessible within the same assembly.

30. **What is the difference between `==` and `.Equals()` in C#?**
    - `==` compares object references for reference types and values for value types.
    - `.Equals()` checks for value equality, can be overridden to provide custom comparison logic.

31. **Explain the concept of async programming and the Task Parallel Library (TPL) in C#.**
    - Async programming allows non-blocking operations, improving responsiveness. TPL provides a higher-level abstraction for parallel and asynchronous programming using `Task`.

32. **How do you use the `Dispose` pattern in C#?**
    ```csharp
    public class MyClass : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                }
                // Dispose unmanaged resources
                disposed = true;
            }
        }

        ~MyClass()
        {
            Dispose(false);
        }
    }
    ```

33. **What is the difference between `const` and `readonly` in C#?**
    - **const:** Compile-time constant, value cannot change, must be initialized at declaration.
    - **readonly:** Runtime constant, can be initialized in constructor, value cannot change after initialization.

34. **What are nullable types in C#?**
    - Nullable types allow value types to represent null values, using the `?` syntax, e.g., `int?`.

35. **Explain the difference between `interface` and `abstract class` in C#.**
    - **Interface:** Only method signatures, no implementation, can be implemented by any class or struct.
    - **Abstract class:** Can have method implementations


    ### C# Interview Questions

36. **Explain the difference between interface and abstract class in C#.**
   - **Interface:**
     - Only method signatures, no implementation.
     - Can be implemented by any class or struct.
     - Supports multiple inheritance.
     - Members are public by default.
   - **Abstract Class:**
     - Can have method implementations and method signatures.
     - Can only be inherited by classes.
     - Supports single inheritance.
     - Members can have any access modifier.

37. **What is a sealed class in C#?**
   - A sealed class is a class that cannot be inherited. It is declared using the `sealed` keyword. This is used to prevent further inheritance and can help in optimizing performance by allowing certain compiler optimizations.

   ```csharp
   public sealed class SealedClass
   {
       // Class members here
   }
   ```

38. **How do you handle multiple exceptions in C#?**
   - You can handle multiple exceptions using multiple `catch` blocks or by using a single `catch` block with an exception filter.

   ```csharp
   try
   {
       // Code that may throw exceptions
   }
   catch (ArgumentNullException ex)
   {
       // Handle ArgumentNullException
   }
   catch (InvalidOperationException ex)
   {
       // Handle InvalidOperationException
   }
   catch (Exception ex)
   {
       // Handle all other exceptions
   }
   ```

39. **What is an indexer in C#?**
   - An indexer allows an object to be indexed like an array. It is defined with the `this` keyword and takes parameters to define the indexing.

   ```csharp
   public class SampleCollection<T>
   {
       private T[] arr = new T[100];

       public T this[int i]
       {
           get { return arr[i]; }
           set { arr[i] = value; }
       }
   }
   ```

40. **How do you implement custom exceptions in C#?**
   - Create a class that derives from `Exception` and provides constructors.

   ```csharp
   public class CustomException : Exception
   {
       public CustomException() { }

       public CustomException(string message) : base(message) { }

       public CustomException(string message, Exception inner) : base(message, inner) { }
   }
   ```

41. **What is the difference between lock, Monitor, and Mutex in C#?**
   - **lock:** Simplified syntax for `Monitor.Enter` and `Monitor.Exit`, used for intra-process synchronization.
   - **Monitor:** Provides a more flexible and feature-rich way for thread synchronization within a process.
   - **Mutex:** Can be used for both intra-process and inter-process synchronization, ensuring that only one thread across multiple processes can access a resource.

42. **How do you work with JSON in C#?**
   - You can use the `System.Text.Json` or `Newtonsoft.Json` (Json.NET) libraries to serialize and deserialize JSON.

   ```csharp
   using System.Text.Json;

   var jsonString = JsonSerializer.Serialize(object);
   var obj = JsonSerializer.Deserialize<MyClass>(jsonString);
   ```

43. **What are the key differences between foreach and for loops in C#?**
   - **foreach:** Iterates through each element in a collection, read-only, cannot modify the collection during iteration.
   - **for:** Provides more control over iteration, can modify the collection, and allows index-based access.

44. **How do you create and use attributes in C#?**
   - Define a class derived from `System.Attribute` and use the attribute by placing it above a class, method, or property.

   ```csharp
   [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
   public class MyCustomAttribute : Attribute
   {
       public string Description { get; }

       public MyCustomAttribute(string description)
       {
           Description = description;
       }
   }

   [MyCustomAttribute("This is a sample class")]
   public class SampleClass
   {
       // Class members
   }
   ```

45. **What is the difference between Hashtable and Dictionary in C#?**
    - **Hashtable:** Non-generic collection, stores key-value pairs as `object`, not type-safe.
    - **Dictionary<TKey, TValue>:** Generic collection, type-safe, better performance due to type safety and lack of boxing/unboxing.

46. **How do you use Tuple and ValueTuple in C#?**
    - **Tuple:** Immutable, reference type, elements are accessed via properties like `Item1`, `Item2`, etc.
    - **ValueTuple:** Mutable, value type, supports deconstruction.

    ```csharp
    var tuple = new Tuple<int, string>(1, "One");
    var valueTuple = (1, "One");

    var (number, text) = valueTuple;
    ```

47. **Explain the concept of covariance and contravariance in C#.**
    - **Covariance:** Allows a method to return a more derived type than specified by the generic parameter (out).
    - **Contravariance:** Allows a method to accept a parameter of a less derived type than specified by the generic parameter (in).

    ```csharp
    IEnumerable<object> objects = new List<string>(); // Covariance
    Action<string> action = (Action<object>)DoSomething; // Contravariance
    ```

48. **What is the difference between finalize and dispose in C#?**
    - **Finalize:** Called by the garbage collector to clean up unmanaged resources before the object is reclaimed. Implemented via a destructor.
    - **Dispose:** Explicitly called to free unmanaged resources, implemented via `IDisposable`.

    ```csharp
    protected override void Finalize()
    {
        // Cleanup code
    }

    public void Dispose()
    {
        // Cleanup code
        GC.SuppressFinalize(this);
    }
    ```

49. **How do you implement a deep copy of an object in C#?**
    - Implement `ICloneable` and create a method that copies all fields and properties.

    ```csharp
    public class MyClass : ICloneable
    {
        public int Value { get; set; }

        public MyClass DeepCopy()
        {
            return new MyClass { Value = this.Value };
        }

        object ICloneable.Clone()
        {
            return DeepCopy();
        }
    }
    ```

50. **What is method overloading and method overriding in C#?**
    - **Method Overloading:** Multiple methods with the same name but different parameters within the same class.
    - **Method Overriding:** Redefining a base class method in a derived class using the `override` keyword.

    ```csharp
    // Method Overloading
    public void Print(int number) { }
    public void Print(string text) { }

    // Method Overriding
    public class BaseClass
    {
        public virtual void Display() { }
    }

    public class DerivedClass : BaseClass
    {
        public override void Display() { }
    }
    ```

16. **What are async streams in C#?**
    - Async streams allow asynchronous iteration over a collection of data using `IAsyncEnumerable<T>` and `await foreach`.

    ```csharp
    public async IAsyncEnumerable<int> GetNumbersAsync()
    {
        for (int i = 0; i < 10; i++)
        {
            await Task.Delay(100);
            yield return i;
        }
    }

    public async Task ProcessNumbersAsync()
    {
        await foreach (var number in GetNumbersAsync())
        {
            Console.WriteLine(number);
        }
    }
    ```