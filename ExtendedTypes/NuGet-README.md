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

#### Toggled()

The extension method *Toggled()* returns the negated value but does not change the variable itself.

```C#
// Value of 'myBool' is 'true'.
var result = myBool.Toggled();
// Value of 'myBool' is still 'true'.
// Value of 'result' is 'false'.
```

#### Not()

The extension method *Not()* is simply *an alias for Toggled()* mirroring its behaviour.

```C#
// Value of 'myBool' is 'true'.
var result = myBool.Not();
// Value of 'myBool' is still 'true'.
// Value of 'result' is 'false'.
```


### String
<a name="string"></a>

This library provides a concise way for checking whether a string is null or empty.

```C#
// Suppose we have a string variable.
var myString = "foo"; 
```

#### IsNullOrEmpty() and IsNullOrWhiteSpace()

If one wants to check whether a string is null, empty or only consisting of white-space characters, the C# string class does already provide methods for that: *IsNullOrEmpty()* and *IsNullOrWhiteSpace()*.

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

#### IsNotNullOrEmpty() and IsNotNullOrWhiteSpace()

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


## Feedback

*Please note:* I am a hobby programmer, so the way this library is implemented might not adhere to professional standards. I cannot guarantee it is behaving as intended, and am not actively maintaining it.

Nevertheless, if you have any suggestions, corrections or ideas, I would appreciate your feedback. Please leave a post in the *Discussions* or open an *Issue* over on [GitHub](https://github.com/mx-pl/ExtendedTypes_CSharp).