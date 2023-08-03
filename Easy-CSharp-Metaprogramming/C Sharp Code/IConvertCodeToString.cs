using Easy_CSharp_Metaprogramming.C_Sharp_Builders;

namespace Easy_CSharp_Metaprogramming.C_Sharp_Code
{
    internal interface IConvertCodeToString<CSCodeType> where 
        CSCodeType :CSharpCode 
    {
        string ConvertToCodeString(CSCodeType code);
    }
}
