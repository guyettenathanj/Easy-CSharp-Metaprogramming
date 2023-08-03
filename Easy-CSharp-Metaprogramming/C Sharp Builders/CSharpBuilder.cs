using System.Text;

namespace Easy_CSharp_Metaprogramming
{
    /// <summary>
    /// Lets you programatically build C# source code objects, 
    /// which can then be converted to a string representation.
    /// </summary>
    public class CSharpBuilder
    {
        #region Properties
        public List<CSharpClass> Classes { get; set; }
        #endregion

        #region Feilds
        private StringBuilder _code;
        private string _currentIndent;
        #endregion

        #region Constructors
        public CSharpBuilder AddClass(ClassBuilder cb)
        {
            return this;
        }
        #endregion

        #region Methods
        public string Build()
        {
            return _code.ToString();
        }
        #endregion
    }
}
