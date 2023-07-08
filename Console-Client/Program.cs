using Easy_CSharp_Metaprogramming;
using static System.Console;


var indent = 2;
var consoleUsing = "using static System.Console";

var appleBuilderCode = new StepBuilderBuilder()
    .AddOptionalStep("SetAppleColor")
    .AddMandatoryStep("SetAppleWeight")
    .AddMandatoryStep("SetAppleHeight");

var code = new CSharpBuilder()
    .AddClass(
        new ClassBuilder(className: "Apple", indent)
            .AddUsing(consoleUsing)
            .AddProperty("bool", "Rotten", AccessModifier.Public)
            .AddProperty("int", "Price", AccessModifier.Public)
        )
    .AddClass(
        new ClassBuilder(className: "Potato", indent)
            .AddUsing(consoleUsing)
            .AddProperty("bool", "Rotten", AccessModifier.Public)
            .AddProperty("int", "Price", AccessModifier.Public)
        );
var codeAsString = code.Build();

var animalClasses = new List<string>(){ "Cat", "Dog", "Horse"};

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




