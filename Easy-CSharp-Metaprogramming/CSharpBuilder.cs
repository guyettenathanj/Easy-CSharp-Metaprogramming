using System.Text;

namespace Easy_CSharp_Metaprogramming
{
    /// <summary>
    /// Lets you programatically build C# source code objects, 
    /// which can then be converted to a string representation.
    /// </summary>
    public class CSharpBuilder
    {
        public List<CSharpClass> Classes { get; set; }

        private StringBuilder _code;
        private string _currentIndent;

        public string Build()
        {
            return _code.ToString();
        }

        public CSharpBuilder AddClass(ClassBuilder cb)
        {
            return this;
        }

    }
}
