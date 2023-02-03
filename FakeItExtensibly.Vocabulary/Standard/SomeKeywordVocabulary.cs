namespace FakeItExtensibly.Vocabulary.Standard;

using System;

/// <summary>
/// Provides a standard vocabulary to use with <see cref="SomeKeyword"/>.
/// </summary>
/// <remarks>
/// The vocabulary here should all represent unambiguous terms. `Guid` returns a <see cref="Guid"/>, `String` returns a <see cref="string"/>.
///
/// A term like `Id` does not have a corresponding `Id` type, so its meaning is what the vocabulary defines it to mean.
/// </remarks>
public static class SomeKeywordVocabulary
{
    /// <summary>
    /// Get some <see cref="System.Guid"/> value.
    /// </summary>
    public static Guid Guid(this SomeKeyword some) => some.Dummy<Guid>();

    /// <summary>
    /// Get some <see cref="string"/> value.
    /// </summary>
    public static string String(this SomeKeyword some) => some.Dummy<string>();
}
