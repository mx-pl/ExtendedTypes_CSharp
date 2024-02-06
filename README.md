<a name="readme-top"></a>

<!-- (urls) -->

  [changelog-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/CHANGELOG.md
  [github-issues-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/issues
  [github-discussions-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/discussions
  [github-wiki-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/wiki
  [license-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE
  [nuget-url]: https://www.nuget.org/packages/mx-pl.ExtendedTypes

<!-- PROJECT HEADER -->
<div align="center">
  <h3 align="center" name="project-title">
    Extended Types (Library)
  </h3>
  <div>
    <a href="https://www.nuget.org/packages/mx-pl.ExtendedTypes"><img alt="NuGet Version" src="https://img.shields.io/nuget/v/mx-pl.ExtendedTypes?style=flat&logo=nuget&logoColor=blue"></a>
    <a href="https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE"><img alt="GitHub License" src="https://img.shields.io/github/license/mx-pl/ExtendedTypes_CSharp?style=flat"></a>
  </div>
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

* Current release: `1.2.0` *(2024-02-06)*

Information on what is new and on previous releases can be found in the [CHANGELOG][changelog-url]. An overview of all features currently included can be found [here][github-wiki-url].

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>


<!-- Features -->
## Features
<a name="features"></a>

This library provides extension methods for:

* Boolean
  * Straightforward toggling.
* String
  * Concise null-or-empty checks.
  * Quick whitespace removal.
  * Easy shortening of sequences of identical chars.

Please see the [Wiki][github-wiki-url] for a detailed feature overview.

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