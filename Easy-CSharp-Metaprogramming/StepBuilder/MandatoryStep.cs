using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_CSharp_Metaprogramming.StepBuilder
{
    public class MandatoryStep
    {
        public required string Name { get; init; }
        public MandatoryStep? NextStep { get; set; }

        public bool IsLastStep()
        {
            var isLast = NextStep == null ? true : false;
            return isLast;
        }
    }
}
