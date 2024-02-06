<a name="readme-top"></a>

<!-- PROJECT HEADER -->
<div align="center">
  <h3 align="center" name="project-title">
    CHANGELOG
  </h3>
  <p align="center" name="project-description">
    Extended Types (Library)
  </p>
</div>

<br/>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table Of Contents</summary>
  <ul>
    <li><a href="#v_1-2-0">v1.2.0</a></li>
    <li><a href="#v_1-1-0">v1.1.0</a></li>
    <li><a href="#v_1-0-0">v1.0.0</a></li>
    <li><a href="#v_1-0-0_beta">v1.0.0-beta</a></li>
  </ul>
</details>

<br/>

<!-- 1.2.0 -->
## v1.2.0
<a name="v_1-2-0"></a>
> 2024-02-06

### Features

* Add extension methods for quick whitespace removal from strings:
  * `SquashWhiteSpace()`
  * `Shrink()`.
* Add extension method `Condense()` for easy compression of sequences of identical chars in strings.

### Testing

* Add unit tests for new string based methods.
* Refactor TestSuite.

### Package

* On GitHub, move Feature Overview from README to Wiki.
* Update PackageTags and add PackageReleaseNotes.

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>


<!-- 1.1.0 -->
## v1.1.0
<a name="v_1-1-0"></a>
> 2024-01-06

### Features

* Add extension methods for concise string empty checks:
  * `IsNullOrEmpty()` and `IsNullOrWhiteSpace()` (mirroring string's pre-existing regular methods of the same name).
  * Their negated versions: `IsNotNullOrEmpty()` and `IsNotNullOrWhiteSpace()`.
* Add `Not()` as an alias for `Toggled()`.

### Testing

* Add unit tests for new string based methods.
* Add unit tests for method `Not()`.

### Package

* Let documentation files be generated when packing (so IntelliSense can display the method descriptions). 

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>


<!-- 1.0.0 -->
## v1.0.0
<a name="v_1-0-0"></a>
> 2023-12-18

### Features

*no new features*

### Testing

* Add unit tests for methods `Toggle()` and `Toggled()`.

### Package

* Add missing metadata, esp. PackageTags.
* Fix README (remove html, which was not correctly displayed on NuGet).

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>


<!-- 1.0.0 BETA -->
## v1.0.0-beta
<a name="v_1-0-0_beta"></a>
> 2023-12-15

_Initial release to see if everything works._

### Features

* Extension methods `Toggle()` and `Toggled()` for easily readable boolean negation.

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>