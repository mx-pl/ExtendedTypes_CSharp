<a name="readme-top"></a>

<!-- (urls) -->

  [license-url]: https://github.com/mx-pl/ExtendedTypes_CSharp/blob/main/LICENSE

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
      </ul>
    </li>
  </ol>
</details>

<br/>

<!-- ABOUT THIS PROJECT -->
## About This Project
<a name="about-this-project"></a>

### Motivation
<a name="motivation"></a>

While the negation operator (`!`) is concise, it is also easy to miss and sometimes has to be put in places where it obstructs or does not correspond with the natural reading flow.

This library aims to provide extension methods which improve the readability and straightforwardness of such statements—and in some cases there conciseness, too.

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>

### License
<a name="license"></a>

Published under the `MIT License`. The license file can be found [here][license-url].

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>

### Package Releases
<a name="package-releases"></a>

*none*

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

This package provides a straightforward way to toggle (ie negate the value of) a boolean variable.

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

<p align="right">
  <a href="#readme-top">
    <img src="https://img.shields.io/badge/&#x2191;-back-lightgrey" />
  </a>
</p>