# Easy-CSharp-Metaprogramming

This is a bit of a hobby project for now, not currently intended for production.

The current options for metaprogramming in C# are pretty lacking. It's either mostly just string manipulation or having to work with obtuse top down ASTs / Rosyln's SyntaxFactory type, which is all top down.

I hope I can offer a more user-friendly experience by using the builder pattern to construct C# code, which can then be outputted to a string.
This offers a more intuitive bottom up approach to building up the code.


# Quick Example
```csharp
using static System.Console;


var indent = "  ";
var staticConsoleUsing = "using static System.Console;";
List<string> animals = new List<string>() { "Horse", "Dog", "Cat" };
List<string> animalsCodeStrings = new List<string>(); 

// Build up the code strings...
foreach (var animal in animals)
{
    var animalCode = new ClassBuilder(className: animal, indentSpaces: indent)
    .AddProperty(type: "string", name: "Name")
    .AddProperty(type: "string", name: "Age")
    .AddUsing(staticConsoleUsing)
    .ReturnCodeString();
    animalsCodeStrings.Add(animalCode);
}

// Print out the code strings
animalsCodeStrings.ForEach(c => WriteLine(c));
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
3. Automatically register implimenters with a given IFactory class
4. Create builder classes for any given design pattern.

# Future Functionality
## Source Code To Builder
Take existing code, get the AST, and then generate the code to build it, in the builder pattern provided here.

This would enable a user to directly modify generated source files, have an analyzer recognize the modification,
and then suggest a builder pattern to construct it programmatically so the changes don't get lost. 

This bidirectional conversation between the client and the generator is a really exciting possibility 




