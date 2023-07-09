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


