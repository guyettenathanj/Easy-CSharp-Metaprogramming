using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
