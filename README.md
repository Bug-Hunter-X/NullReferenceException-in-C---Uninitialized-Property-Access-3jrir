# C# NullReferenceException Example

This repository demonstrates a common C# error: the `NullReferenceException`.  The example shows how accessing an uninitialized property can lead to this exception and provides a solution.

## The Bug

The `bug.cs` file contains code where the `MyProperty` of `ExampleClass` is used without ensuring it has a value.  If the property is accessed before it's set, a `NullReferenceException` will be thrown.

## The Solution

The `bugSolution.cs` file demonstrates a solution.  It shows two ways to prevent the `NullReferenceException`:

1. **Initializing the Property:**  Assigning a default value to `MyProperty` in the class constructor.
2. **Null Check:** Explicitly checking for `null` before using the property.