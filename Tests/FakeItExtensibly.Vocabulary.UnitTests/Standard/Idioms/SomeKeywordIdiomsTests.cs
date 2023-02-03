namespace FakeItExtensibly.Vocabulary.UnitTests.Standard.Idioms;

using FakeItExtensibly.Vocabulary.Standard.Idioms;

[TestClass]
public class SomeKeywordIdiomsTests
{
    [TestMethod]
    public void Id_Returns_GuidString()
    {
        // Act
        var id = Some.Id();

        // Assert
        Guid.TryParse(id, out _).Should().BeTrue();
    }
}
