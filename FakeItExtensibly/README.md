# FakeItExtensibly

An alternative API to FakeItEasy that wraps the FakeItEasy API in a way that allows you to extend it with extension methods.

To avoid naming conflicts, `Some` is used instead of `A`.

## Usage

### Basic

```csharp
using static FakeItExtensibly.SomeKeyword;

var dummyString = Some.Dummy<string>();
```

### Extending

```csharp
using static FakeItExtensibly.SomeKeyword;

public static class SomeKeywordExtensions
{
    public static Guid Guid(this SomeKeyword some) => some.Dummy<Guid>();
}

var guid = Some.Guid();
```
