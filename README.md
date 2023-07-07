# Easy-CSharp-Metaprogramming

This is a bit of a hobby project for now, not currently intended for production.

The current options for metaprogramming in C# are pretty lacking. It's either mostly just string manipulation or having to work with obtuse ASTs with poor documentation.

I hope I can offer a more user-friendly experience by using the builder pattern to construct C# code, which can then be outputted to a string.


# Quick Example
```csharp
using Easy_CSharp_Metaprogramming;
using static System.Console;

var animalClasses = new List<string>(){ "Cat", "Dog", "Horse"};

var indent = 2;

ExceptionHandlerBuilder exceptionHandler = new ExceptionHandlerBuilder(indent)
    .AddCatch("Exception e", "Console.WriteLine(e.Message);")
    .AddFinally("CleanUp();");

foreach (string className in animalClasses)
{
    ClassBuilder builder = new ClassBuilder(className, indent, AccessModifier.Public);
    string classCode = builder
        .AddProperty("string", "FirstName", AccessModifier.Public)
        .AddProperty("string", "LastName", AccessModifier.Public)
        .AddProperty("DateTime", "DateOfBirth", AccessModifier.Private)
        .AddMethod(ReturnType.Int, "ReturnNumberofEars", AccessModifier.Public, "return 2;", exceptionHandler)
        .Build();

    WriteLine(classCode);
    WriteLine();
}
```

# Output
```csharp
public class Cat
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    private DateTime DateOfBirth { get; set; }

    public int ReturnNumberofEars()
    {
        try
        {
            return 2;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            CleanUp();
        }


    }

}


public class Dog
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    private DateTime DateOfBirth { get; set; }

    public int ReturnNumberofEars()
    {
        try
        {
            return 2;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            CleanUp();
        }


    }

}


public class Horse
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    private DateTime DateOfBirth { get; set; }

    public int ReturnNumberofEars()
    {
        try
        {
            return 2;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            CleanUp();
        }


    }

}
```

# Real Use-case Ideas for the Future
1. JSON to C# Class
2. Injecting Logging / Exception Handling






