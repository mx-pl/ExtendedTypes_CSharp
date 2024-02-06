## About This Project

A small C#/.NET library providing data type based utility methods—mainly for improved readability.

### Motivation

The motivation for this library is two-fold:

#### Side-stepping the negation operator

Though the negation operator (`!`) is concise, it is also easy to miss and sometimes has to be put in places where it obstructs or does not align with the natural reading flow.

This library aims to provide extension methods which improve the readability and straightforwardness of such statements—and in some cases there conciseness, too.

#### More concise string manipulation

The C# string class comes pre-equipped with a variety of useful methods. However, invoking some of them requires rather roundabout statements (e.g. checking whether a string is empty). 

This library provides some extension methods to simplify their usage.


## Features

— An overview of all current features is also available in the repo's *Wiki* over on [GitHub](https://github.com/mx-pl/ExtendedTypes_CSharp/wiki). —

Nevertheless, for your convenience, here is the full rundown:
### Boolean

This package provides a straightforward way to toggle (i.e. negate the value of) a boolean variable.

```C#
// Let's define a bool variable and set it to true.
var myBool = true; 
```

#### Toggle()

The extension method *Toggle()* negates the value of the instance without returning anything.
 
```C#
// Value of 'myBool' is 'true'.
myBool.Toggle();
// Value of 'myBool' is 'false'.
```

#### Toggled() — Not()

The extension method *Toggled()* returns the negated value but does not change the variable itself.

The extension method *Not()* is *an alias for Toggled()* mirroring its behaviour.

```C#
// Value of 'myBool' is 'true'.
var result = myBool.Toggled();
// Value of 'myBool' is still 'true'.
// Value of 'result' is 'false'.
```


### String—NullOrEmpty Checks

This library provides a concise way for checking whether a string is null or empty.

```C#
// Suppose we have a string variable.
var myString = "foo"; 
```

#### IsNullOrEmpty() — IsNullOrWhiteSpace()

If one wants to check whether a string is null, empty or only consisting of whitespace characters, the C# string class does already provide methods for that: *IsNullOrEmpty()* and *IsNullOrWhiteSpace()*.

This library, however, offers these build-in methods as extension methods.

```C#
// Conventionally, one would check whether the string is empty (or whitespace) like this:
string.IsNullOrEmpty(myString);
string.IsNullOrWhiteSpace(myString);

// Using this library's extension methods the statement looks like that:
myString.IsNullOrEmpty();
myString.IsNullOrWhiteSpace();

// In each case a boolean value is returned to indicate the answer.
```

The newly provided methods mirror the behaviour of the pre-existing ones (in fact, internally, they just invoke them).

#### IsNotNullOrEmpty() — IsNotNullOrWhiteSpace()

Additionally, this library offers the negated versions of these methods.

```C#
// The extension methods ...
myString.IsNotNullOrEmpty();
myString.IsNotNullOrWhiteSpace();

// ... are equivalent to:
!string.IsNullOrEmpty(myString);
!string.IsNullOrWhiteSpace(myString);

// Again, a boolean value is returned to indicate the result.
```

### String—Whitespace Removal

This library provides a quick way to condense, remove or replace the whitespace in a string.

```C#
// Suppose we have a string variable containing whitespace.
var myString = "foo···bar\n";
```

#### SquashWhiteSpace()

The extension method *SquashWhiteSpace()* returns the string with all sequences of whitespace characters replaced with a single space char. Optionally, an alternative replacement can be specified.

```C#
// By default, whitespace is replaced with a single space.
var squashedString_Default = myString.SquashWhiteSpace();
// Value of 'squashedString_Default' is "foo·bar·".

// Alternatively, you can specify your own replacement char.
var squashedString_CustomReplacement = myString.SquashWhiteSpace('-');
// Value of 'squashedString_CustomReplacement' is "foo-bar-".

// If the replacement is set to null, whitespace is removed entirely.
var squashedString_ReplacementIsNull = myString.SquashWhiteSpace(null);
// Value of 'squashedString_ReplacementIsNull' is "foobar".
```

#### Shrink()

The extension method *Shrink()* returns the string with all leading and trailing whitespace removed (i.e. trimmed) and all remaining sequences of whitespace characters replaced with a single space char.

Optionally, an alternative replacement can be specified. In addition, the trimming can be disabled.

```C#
// By default, the string is trimmed and remaining whitespace is replaced with a single space.
var shrunkString_Default = myString.Shrink();
// Value of 'shrunkString_Default' is "foo·bar".

// Alternatively, you can specify your own replacement char.
var shrunkString_CustomReplacement = myString.Shrink('-');
// Value of 'shrunkString_CustomReplacement' is "foo-bar".

// Additionally, trimming can be disabled.
var shrunkString_NotTrimmed = myString.Shrink('-', false);
// Value of 'shrunkString_NotTrimmed' is "foo-bar-".
// This mirrors the behaviour of SquashWhiteSpace().
```

### String—Removal of Identical Chars

This library provides a way to compress sequences of identical characters.

```C#
// Suppose we have a string variable with sequences of the same character.
var myString = "··\t··FfoooBaAr";
```

#### Condense()

The extension method *Condense()* returns the string with all sequences of identical characters replaced with just one instance of that character.

The behaviour can be modified using the options *OnlyWhiteSpace* and *IgnoreCase*.

```C#
// By default, all kinds of characters are condensed.
var condensedString_Default = myString.Condense();
// Value of 'condensedString_Default' is "·\t·FfoBaAr".

// With option 'OnlyWhiteSpace' non-whitespace characters are not removed.
var condensedString_OnlyWhiteSpace = myString.Condense(StringCondenseOptions.OnlyWhiteSpace);
// Value of 'condensedString_OnlyWhiteSpace' is "·\t·FfoooBaAr".

// With option 'IgnoreCase' the upper- and lowercase form of a character are considered identical.
// Nevertheless, the first char of each sequence of identical chars retains its case.
var condensedString_IgnoreCase = myString.Condense(StringCondenseOptions.IgnoreCase);
// Value of 'condensedString_IgnoreCase' is "·\t·FoBar".
```

## Feedback

*Please note:* I am a hobby programmer, so the way this library is implemented might not adhere to professional standards. I cannot guarantee it is behaving as intended, and am not actively maintaining it.

Nevertheless, if you have any suggestions, corrections or ideas, I would appreciate your feedback. Please leave a post in the *Discussions* or open an *Issue* over on [GitHub](https://github.com/mx-pl/ExtendedTypes_CSharp).