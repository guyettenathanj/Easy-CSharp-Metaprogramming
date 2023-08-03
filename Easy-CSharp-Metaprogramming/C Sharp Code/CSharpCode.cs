using System.Text;

namespace Easy_CSharp_Metaprogramming
{
    public class CSharpCode
    {
        protected StringBuilder Code { get; set; }
        public string Indent { get; init; }

        public CSharpCode(string indent)
        {
            Indent = indent;
            Code = new StringBuilder();
        }

        public virtual string ReturnCodeString()
        {
            return Code.ToString();
        }
    }
}