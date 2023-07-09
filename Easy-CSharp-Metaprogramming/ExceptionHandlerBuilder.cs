﻿using System.Text;

namespace Easy_CSharp_Metaprogramming
{
    public class ExceptionHandlerBuilder : CSharpCode
    {

        public ExceptionHandlerBuilder(string indentSpaces) :
            base(indentSpaces)
        {
        }

        public ExceptionHandlerBuilder AddCatch(string exceptionType, string catchBody)
        {
            Code.AppendLine($"{Indent}catch({exceptionType})");
            Code.AppendLine($"{Indent}" + "{");
            Code.AppendLine($"{Indent}{Indent}{catchBody}");
            Code.AppendLine($"{Indent}" + "}");
            return this;
        }

        public ExceptionHandlerBuilder AddFinally(string finallyBody)
        {
            Code.AppendLine($"{Indent}finally");
            Code.AppendLine($"{Indent}" + "{");
            Code.AppendLine($"{Indent}{Indent}{finallyBody}");
            Code.AppendLine($"{Indent}" + "}");
            return this;
        }

        public string Build(string methodBody)
        {
            var sb = new StringBuilder();
            Code.AppendLine($"{Indent}try");
            Code.AppendLine($"{Indent}" + "{");
            Code.AppendLine($"{Indent}{Indent}{methodBody}");
            Code.AppendLine($"{Indent}" + "}");
            sb.AppendLine(Code.ToString());
            return sb.ToString();
        }
    }
}
