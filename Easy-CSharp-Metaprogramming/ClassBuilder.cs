using Easy_CSharp_Metaprogramming;

public class ClassBuilder : CSharpCode
{
    private List<CSharpProperty> Properties { get; }
    private List<string> Usings { get; }
    public string ClassName { get; }
    public AccessModifier AccessModifier { get; }

    public ClassBuilder(string className, string indentSpaces,
        AccessModifier accessModifier = AccessModifier.Public)
        : base(indentSpaces)
    {
        Properties = new List<CSharpProperty>();
        Usings = new List<string>();    
        ClassName = className;
        AccessModifier = accessModifier;
    }

    public ClassBuilder AddProperty(string type, string name,
        AccessModifier accessModifier = AccessModifier.Public)
    {
        var propToAdd = new CSharpProperty(type, name, Indent, accessModifier);
        Properties.Add(propToAdd);
        return this;
    }

    public ClassBuilder AddUsing(string usingString)
    {
        Usings.Add(usingString);
        return this;
    }

    public ClassBuilder AddMethod(string returnType, string methodName, string accessModifier, string methodBody, 
        ExceptionHandlerBuilder exceptionHandlerBuilder)
    {
        Code.AppendLine($"{Indent}{accessModifier} {returnType} {methodName}()");
        Code.AppendLine($"{Indent}" + "{");

        if (exceptionHandlerBuilder != null)
        {
            Code.AppendLine(exceptionHandlerBuilder.Build(methodBody));
        }
        else if (!string.IsNullOrWhiteSpace(methodBody))
        {
            Code.AppendLine($"{Indent}{Indent}{methodBody}");
        }

        Code.AppendLine($"{Indent}" + "}");
        Code.AppendLine();
        return this;
    }

    public override string ReturnCodeString()
    {
        var propertiesAsCodeString = 
            Properties.Select(x => x.ReturnCodeString()).ToList();


        var accessModifierString = AccessModifier.ToString().ToLower();
        Code.AppendLines(Usings);
        Code.AppendLine();
        Code.AppendLine($"{accessModifierString} class {ClassName}");
        Code.AppendLine("{");
        Code.AppendLines(propertiesAsCodeString);
        Code.AppendLine("}");
        return Code.ToString(); 
    }
}
