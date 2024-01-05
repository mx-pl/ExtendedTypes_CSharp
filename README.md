<a name="readme-top"></a>

<!-- (urls) -->

  [changelog-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/CHANGELOG.md
  [github-issues-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/issues
  [github-discussions-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/discussions
  [license-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE
  [nuget-url]: https://www.nuget.org/packages/mx-pl.ExtendedTypes

<!-- PROJECT HEADER -->
<div align="center">
  <h3 align="center" name="project-title">
    Extended Types (Library)
  </h3>
  <p align="center" name="project-description">
    A small C#/.NET library providing data type based utility methods—mainly for improved readability.
  </p>
</div>

<br/>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table Of Contents</summary>
  <ol>
    <li>
      <a href="#about-this-project">About This Project</a>
      <ul>
        <li><a href="#motivation">Motivation</a></li>
        <li><a href="#license">License</a></li>
        <li><a href="#package-releases">Package Releases</a></li>
      </ul>
    </li>
    <li>
      <a href="#features">Features</a>
      <ul>
        <li><a href="#boolean">Boolean</a></li>
        <li><a href="#string">String</a></li>
      </ul>
    </li>
    <li>
      <a href="#feedback">Feedback</a>
    </li>
  </ol>
</details>

<br/>

<!-- ABOUT THIS PROJECT -->
## About This Project
<a name="about-this-project"></a>

### Motivation
<a name="motivation"></a>

The motivation for this library is two-fold:

#### Side-stepping the negation operator

Though the negation operator (`!`) is concise, it is also easy to miss and sometimes has to be put in places where it obstructs or does not align with the natural reading flow.

This library aims to provide extension methods which improve the readability and straightforwardness of such statements—and in some cases there conciseness, too.

#### More concise string manipulation

 The C# string class comes pre-equipped with a variety of useful methods. However, invoking some of them requires rather roundabout statements (e.g. checking whether a string is empty). 

 This library provides some extension methods to simplify their usage.

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>

### License
<a name="license"></a>

Published under the `MIT License`. See the full [license file][license-url] for more information.

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>

### Package Releases
<a name="package-releases"></a>

This library is published as a [package on NuGet][nuget-url].

* Current release: `1.0.0` *(2023-12-18)*

Information on what is new and on previous releases can be found in the [CHANGELOG][changelog-url]. An overview of current features can be found in the next section.

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>


<!-- Features -->
## Features
<a name="features"></a>

### Boolean
<a name="boolean"></a>

This library provides a straightforward way to toggle (i.e. negate the value of) a boolean variable.

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

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>


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

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>


## Feedback
<a name="feedback"></a>

*Please note:* I am a hobby programmer, and the premise of this library or the way it is implemented might not make sense from a more professional point of view. Additionally, I cannot guarantee it is behaving as intended, and am not actively maintaining it.

That being said, I would appreciate your feedback. If you have any suggestions, corrections or ideas, you can leave a post in the [Discussions][github-discussions-url] or open an [Issue][github-issues-url].

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>