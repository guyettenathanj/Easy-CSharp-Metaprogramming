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
