using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_CSharp_Metaprogramming
{

    // TODO: Finish this...
    /// <summary>
    /// Create a step builder pattern using 
    /// a standard builder
    /// </summary>
    public class StepBuilderBuilder
    {

        public StepBuilderBuilder AddOptionalStep(string stepName)
        {
            return this;
        }

        public StepBuilderBuilder AddMandatoryStep(string stepName)
        {
            return this;
        }

        public string Build() 
        {
            return ""; 
        }
    }
}
