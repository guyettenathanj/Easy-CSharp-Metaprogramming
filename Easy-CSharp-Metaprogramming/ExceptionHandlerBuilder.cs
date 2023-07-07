using System.Text;

namespace Easy_CSharp_Metaprogramming
{
    public class ExceptionHandlerBuilder
    {
        private string _indent;
        private StringBuilder _exceptionHandlerCode;

        public ExceptionHandlerBuilder(int indentSpaces)
        {
            _indent = GenerateIndent(indentSpaces);
            _exceptionHandlerCode = new StringBuilder();
        }

        public ExceptionHandlerBuilder AddCatch(string exceptionType, string catchBody)
        {
            _exceptionHandlerCode.AppendLine($"{_indent}catch({exceptionType})");
            _exceptionHandlerCode.AppendLine($"{_indent}" + "{");
            _exceptionHandlerCode.AppendLine($"{_indent}{_indent}{catchBody}");
            _exceptionHandlerCode.AppendLine($"{_indent}" + "}");
            return this;
        }

        public ExceptionHandlerBuilder AddFinally(string finallyBody)
        {
            _exceptionHandlerCode.AppendLine($"{_indent}finally");
            _exceptionHandlerCode.AppendLine($"{_indent}" + "{");
            _exceptionHandlerCode.AppendLine($"{_indent}{_indent}{finallyBody}");
            _exceptionHandlerCode.AppendLine($"{_indent}" + "}");
            return this;
        }

        public string Build(string methodBody)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{_indent}try");
            sb.AppendLine($"{_indent}" + "{");
            sb.AppendLine($"{_indent}{_indent}{methodBody}");
            sb.AppendLine($"{_indent}" + "}");
            sb.AppendLine(_exceptionHandlerCode.ToString());
            return sb.ToString();
        }

        private string GenerateIndent(int spaces)
        {
            return new string(' ', spaces);
        }
    }


}
