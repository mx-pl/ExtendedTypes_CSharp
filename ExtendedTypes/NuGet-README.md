## About This Project

A small C#/.NET library providing data type based utility methods—mainly for improved readability.

### Motivation

#### Side-stepping the negation operator

Even though the negation operator (`!`) is concise, it is also easy to miss and sometimes has to be put in places where it obstructs or does not align with the natural reading flow.

This library aims to provide extension methods which improve the readability and straightforwardness of such statements—and in some cases there conciseness, too.


## Features

### Boolean

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