using System.Text;

namespace Easy_CSharp_Metaprogramming.ExtensionMethods
{
    public static class StringBuilderExtensions
    {
        public static void AppendLines(this StringBuilder sb,
            IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                sb.AppendLine(line);
            }
        }
    }
}
