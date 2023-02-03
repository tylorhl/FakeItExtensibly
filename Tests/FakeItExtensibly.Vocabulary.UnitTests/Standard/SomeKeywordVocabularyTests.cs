namespace FakeItExtensibly.Vocabulary.UnitTests.Standard;

using FakeItExtensibly.Vocabulary.Standard;

[TestClass]
public class SomeKeywordVocabularyTests
{
    [TestMethod]
    public void Guid_Returns_Guid()
    {
        var _ = Some.Guid();
    }

    [TestMethod]
    public void String_Returns_String()
    {
        Some.String().Should().NotBeNull();
    }
}