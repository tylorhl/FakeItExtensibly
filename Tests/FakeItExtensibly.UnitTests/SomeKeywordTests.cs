namespace FakeItExtensibly.UnitTests;

using static FakeItExtensibly.SomeKeyword;

[TestClass]
public class SomeKeywordTests
{
    [TestMethod]
    public void Dummy_T_Matches_FakeItEasy()
    {
        // Arrange
        var fakeItEasyDummy = Some.Dummy<string>();

        // Act
        var dummy = Some.Dummy<string>();

        // Assert
        dummy.Should().NotBeNull().And.Be(fakeItEasyDummy);
    }

    [TestMethod]
    public void Fake_T_Matches_FakeItEasy()
    {
        // Arrange
        var fakeItEasyDummy = Some.Fake<IEnumerable<string>>();

        // Act
        var dummy = Some.Fake<IEnumerable<string>>();

        // Assert
        dummy.Should().NotBeNull().And.BeEquivalentTo(fakeItEasyDummy);
    }
}