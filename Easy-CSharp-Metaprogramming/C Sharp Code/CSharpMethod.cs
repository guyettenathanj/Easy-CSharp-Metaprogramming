using Easy_CSharp_Metaprogramming;

public class CSharpMethod : CSharpCode
{
    private List<CSharpParameter> Parameters { get; set; }
    public string Name { get; }
    public string ReturnType { get; }

    public CSharpMethod(string name, 
        string returnType, string indent) : base(indent)
    {
        Name = name;
        ReturnType = returnType;
    }

    public CSharpMethod AddParameter(CSharpParameter parameter)
    {
        Parameters.Add(parameter);
        return this;
    }
}