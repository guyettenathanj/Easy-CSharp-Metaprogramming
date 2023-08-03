using Easy_CSharp_Metaprogramming.C_Sharp_Builders;
using Easy_CSharp_Metaprogramming.Property;
using System.Text;

namespace Easy_CSharp_Metaprogramming.C_Sharp_Code.Property
{
    /// <summary>
    /// A way to convert CSharpProperty class to text.
    /// The IConvertCodeToString interface is written
    /// in such a way you can provide many different ways
    /// of turning some bit of CSharpCode to a string output,
    /// and this is just one!
    /// </summary>
    internal class CSharpPropertyTextConverter :
        IConvertCodeToString<CSharpProperty>
    {
        public string ConvertToCodeString(CSharpProperty code)
        {
            var accessModifierString = code.AccessModifier.ToString().ToLower();
            StringBuilder sb = new StringBuilder();
            sb.Append($"{code.Indent}{accessModifierString} {code.Type} {code.Name} {{ get; set; }}");
            return sb.ToString();
        }
    }
}
