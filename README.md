# FakeItExtensibly


[![Nuget Version](https://img.shields.io/nuget/v/FakeItExtensibly?label=FakeItExtensibly)](https://www.nuget.org/packages/FakeItExtensibly/)
[![Nuget Version](https://img.shields.io/nuget/v/FakeItExtensibly.Vocabulary?label=FakeItExtensibly.Vocabulary)](https://www.nuget.org/packages/FakeItExtensibly.Vocabulary/)

A wrapping API for FakeItEasy that can be extended with extension methods.

## Why?

I wanted to be able to customize the FakeItEasy APIs with extension methods, that way code could be more easily composed.
I didn't want to fork FakeItEasy nor create a replacement. I wanted FakeItEasy but customizable.


## Usage

To start using the new API, include a `using static` to the `SomeKeyword` and you can start using `Some` wherever you normally use `A.` or `An.` with FakeItEasy.

```csharp
using static FakeItExtensibly.SomeKeyword;

var dummyString = Some.Dummy<string>();
```


### Extending

To extend the API, simply extend `SomeKeyword` with an extension method.

```csharp
public static Guid Guid(this SomeKeyword some) => some.Dummy<Guid>();
```


## Vocabulary

In addition to the main API, there is a separate `Vocabulary` library. This library contains extensions to the API that define a "vocabulary" for the API. The vocabulary you decide to use will dictate the API available for use.

Included is a `Standard` vocabulary. This is intended to contain common or standard extensions that can be broadly useful. For instance, `Some.Dummy<Guid>()` may read easier to some as `Some.Guid()`. The two are equivalent, though.


## Thanks
The awesome folks who created and maintain [FakeItEasy](https://github.com/FakeItEasy/FakeItEasy)
