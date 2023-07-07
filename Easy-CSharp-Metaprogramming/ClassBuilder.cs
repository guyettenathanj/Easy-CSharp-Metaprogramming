using Easy_CSharp_Metaprogramming;
using System.Text;

public enum AccessModifier
{
    Public,
    Protected,
    Internal,
    Private,
    ProtectedInternal,
    PrivateProtected
}

public enum ReturnType
{
    Void,
    Int,
    String,
    Bool,
    Double,
    Decimal,
    DateTime
    // You can add more types here as needed.
}

public class ClassBuilder
{
    private StringBuilder _classCode;
    private string _indent;

    public ClassBuilder(string className, int indentSpaces, AccessModifier accessModifier = AccessModifier.Public)
    {
        _classCode = new StringBuilder();
        _indent = GenerateIndent(indentSpaces);

        _classCode.AppendLine($"{accessModifier.ToString().ToLower()} class {className}");
        _classCode.AppendLine("{");
    }

    public ClassBuilder AddProperty(string type, string name, AccessModifier accessModifier = AccessModifier.Public)
    {
        _classCode.AppendLine($"{_indent}{accessModifier.ToString().ToLower()} {type} {name} {{ get; set; }}");
        _classCode.AppendLine();
        return this;
    }

    public ClassBuilder AddMethod(ReturnType returnType, string methodName, AccessModifier accessModifier, string methodBody, ExceptionHandlerBuilder exceptionHandlerBuilder)
    {
        return AddMethod(returnType.ToString().ToLower(), methodName, accessModifier, methodBody, exceptionHandlerBuilder);
    }

    public ClassBuilder AddMethod(string returnType, string methodName, AccessModifier accessModifier, string methodBody, ExceptionHandlerBuilder exceptionHandlerBuilder)
    {
        _classCode.AppendLine($"{_indent}{accessModifier.ToString().ToLower()} {returnType} {methodName}()");
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
}
