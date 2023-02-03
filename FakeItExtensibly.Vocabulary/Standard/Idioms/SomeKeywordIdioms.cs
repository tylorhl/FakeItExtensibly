namespace FakeItExtensibly.Vocabulary.Standard.Idioms;

/// <summary>
/// Defines a set of idiomatic terms to use with <see cref="SomeKeyword"/>.
/// </summary>
/// <remarks>
/// The terms defined here should be ones that don't have an unambiguous type associated.
///
/// A term like `Id` does not have a concrete corresponding type.
/// We define it here in a way that provides value that isn't otherwise provided through the "denotative" vocabulary.
/// </remarks>
public static class SomeKeywordIdioms
{
    /// <summary>
    /// Get some <see cref="Guid"/> as a <see cref="string"/>.
    /// </summary>
    public static string Id(this SomeKeyword some) => some.Guid().ToString();
}
