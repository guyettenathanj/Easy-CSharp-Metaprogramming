using Easy_CSharp_Metaprogramming.C_Sharp_Builders;

namespace Easy_CSharp_Metaprogramming_Tests
{
    public class ClassBuilderTests
    {
        [Test]
        public void ClassBuilder_BuildSimpleClassWithNoNamespace_ClassIsBuilt()
        {
            //Arrange 
            var indent = "  ";
            var staticConsoleUsing = "using static System.Console;";

            var actual = new ClassBuilder(className: "Cat", indentSpaces: indent)
                .AddProperty(type: "string", name: "Name")
                .AddProperty(type: "int", name: "Age")
                .AddUsing(staticConsoleUsing)
                .ReturnCodeString();

            // Act 
            var expected =
            """"""
            using static System.Console;

            public class Cat
            {
              public string Name { get; set; }
              public int Age { get; set; }
            }
            """""";

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}