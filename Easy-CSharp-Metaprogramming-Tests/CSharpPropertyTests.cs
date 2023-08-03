namespace Easy_CSharp_Metaprogramming_Tests
{
    public class CSharpPropertyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnCodeString_IndentIsEmptyString_PropertyIsGenerated()
        {
            //Arrange 
            CSharpProperty csp =
                new CSharpProperty(type: "string",
                name: "Weight", indent: "");

            // Act 
            var actual = csp.ReturnCodeString();
            var expected = "public string Weight { get; set; }";

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ReturnCodeString_AccessModifierIsPrivate_AccessModifierGeneratedIsLowercasePrivate()
        {
            //Arrange 
            CSharpProperty csp =
                new CSharpProperty(type: "string",
                name: "Weight", indent: "", accessModifier: AccessModifier.Private);

            // Act 
            var actual = csp.ReturnCodeString();
            var expected = "private string Weight { get; set; }";

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}