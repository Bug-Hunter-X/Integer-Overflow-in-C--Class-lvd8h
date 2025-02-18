# Integer Overflow Bug in C# Example

This repository demonstrates a common integer overflow bug in C# and provides a solution.

**Bug:** The `ExampleClass` contains a method `IncrementValue` that increments an integer variable without checking for potential overflow.  If the integer reaches its maximum value and is incremented, it will wrap around to its minimum value, leading to unexpected behavior or data corruption.

**Solution:** The solution file demonstrates the correct approach by adding a check before the increment operation. If the value is already at its maximum, an exception is thrown or alternative handling is implemented. 