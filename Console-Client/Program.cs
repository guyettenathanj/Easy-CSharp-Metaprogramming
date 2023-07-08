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




