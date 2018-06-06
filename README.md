Calculator
==========

You work for the Foobar Company, and you are assigned the project Calculator. It is a very old, unmaintained project, which has got some quality issues.

At the moment, the Calculator only supports sums; the Customer required a new functionality: the possibility to specify additional operations (substract, multiply and divide) to be performed on the two provided arguments. 
You should implement the required functionality and improve the code quality.

You are kindly asked to provide your result as an independent GitHub repository (not a fork), or as a zip file.

Calculator V1.0
===============

The Calculator now supports the required new functionality while keeping the backward compatibility with the previous usage patterns.
The code is organized to simplify the adding of new calculator types, beside the current File and Interactive ones, and the implementation of new operations.
In particular, the solution leverages on reflection to find out new operation types. The 'Calculator' namespace includes the code for calculator types handling and 'Calculator.Operations' for operations with int values and binary operators.  

