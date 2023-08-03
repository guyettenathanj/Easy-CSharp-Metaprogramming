namespace Easy_CSharp_Metaprogramming.C_Sharp_Builders;

public class ParameterBuilder
{
    public enum ParameterType
    {
        Standard,
        In,
        Out,
        Ref
    }

    public ParameterBuilder(string name, string type,
        ParameterType pt = ParameterType.Standard,
        bool isOptional = false)
    {

    }

}
