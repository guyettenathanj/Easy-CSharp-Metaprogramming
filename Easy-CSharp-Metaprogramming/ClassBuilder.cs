using Easy_CSharp_Metaprogramming;
using System.Text;
using static AccessModifier;
using static ReturnType;

public static class AccessModifier
{
    public const string Public = "public";
    public const string Protected = "protected";
    public const string Internal = "internal";
    public const string Private = "private";
    public const string ProtectedInternal = "protected internal";
    public const string PrivateProtected = "private protected";
}

public static class ReturnType
{
    public const string Void = "void";
    public const string Int = "int";
    public const string String = "string";
    public const string Bool = "bool";
    public const string Double = "double";
    public const string Decimal = "decimal";
    public const string DateTime = "DateTime";
}

public class ClassBuilder
{
    private StringBuilder _classCode;
    private string _indent;

    public ClassBuilder(string className, int indentSpaces, string accessModifier = Public)
    {
        _classCode = new StringBuilder();
        _indent = GenerateIndent(indentSpaces);

        _classCode.AppendLine($"{accessModifier} class {className}");
        _classCode.AppendLine("{");
    }

    public ClassBuilder AddProperty(string type, string name, string accessModifier = Public)
    {
        _classCode.AppendLine($"{_indent}{accessModifier} {type} {name} {{ get; set; }}");
        _classCode.AppendLine();
        return this;
    }

    public ClassBuilder AddUsing(string usingString)
    {
        return this;
    }

    public ClassBuilder AddMethod(string returnType, string methodName, string accessModifier, string methodBody, 
        ExceptionHandlerBuilder exceptionHandlerBuilder)
    {
        _classCode.AppendLine($"{_indent}{accessModifier} {returnType} {methodName}()");
        _classCode.AppendLine($"{_indent}" + "{");

        if (exceptionHandlerBuilder != null)
        {
            _classCode.AppendLine(exceptionHandlerBuilder.Build(methodBody));
        }
        else if (!string.IsNullOrWhiteSpace(methodBody))
        {
            _classCode.AppendLine($"{_indent}{_indent}{methodBody}");
        }

        _classCode.AppendLine($"{_indent}" + "}");
        _classCode.AppendLine();
        return this;
    }

    public string Build()
    {
        _classCode.AppendLine("}");
        return _classCode.ToString();
    }

    private string GenerateIndent(int spaces)
    {
        return new string(' ', spaces);
    }

    public ClassBuilder AddBaseClass(ClassBuilder baseClass)
    {
        return this;
    }
}
