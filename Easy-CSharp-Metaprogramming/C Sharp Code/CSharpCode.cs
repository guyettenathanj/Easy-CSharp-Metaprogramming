using System.Text;

namespace Easy_CSharp_Metaprogramming
{
    public class CSharpCode
    {
        #region Properties
        protected StringBuilder Code { get; set; }
        public string Indent { get; init; }
        #endregion

        #region Constructors
        public CSharpCode(string indent)
        {
            Indent = indent;
            Code = new StringBuilder();
        }
        #endregion

        #region Methods
        public virtual string ReturnCodeString()
        {
            return Code.ToString();
        }
        #endregion
    }
}