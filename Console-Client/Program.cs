using Easy_CSharp_Metaprogramming;
using static System.Console;

var animalClasses = new List<string>(){ "Cat", "Dog", "Horse"};
var plantClasses = new List<string>(){ "Flower", "Tree", "Weed"};

var indent = 2;

ExceptionHandlerBuilder exceptionHandler = new ExceptionHandlerBuilder(indent)
    .AddCatch("Exception e", "Console.WriteLine(e.Message);")
    .AddFinally("CleanUp();");


foreach (string className in plantClasses)
{
    ClassBuilder builder = new ClassBuilder("Person", indent, AccessModifier.Public);
    string classCode = builder
        .AddProperty("string", "FirstName", AccessModifier.Public)
        .AddProperty("string", "LastName", AccessModifier.Public)
        .AddProperty("DateTime", "DateOfBirth", AccessModifier.Private)
        .AddMethod(ReturnType.Int, "ReturnTwo", AccessModifier.Public, "return 2;", exceptionHandler)
        .Build();

    WriteLine(classCode);
    ;
    WriteLine();
}




