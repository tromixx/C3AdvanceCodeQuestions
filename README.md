# C3AdvanceCodeQuestions
Here is a C# Advance Code Questions repo that contains some questions that I build for everyone to get hands on into advance C# code skills.

The orfer of topics:
0. SOLID Principles
1. Hash Tables and Arrays
2. Generics
3. Lambda Expressions
4. Events and Delegates
5. Extension Methods
6. LINQ
7. Async/Await
8. Binary and AVL Tress

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