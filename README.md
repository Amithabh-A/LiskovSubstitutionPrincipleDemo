## Overview
Liskov's Substitution Principle is the third of the five SOLID principles. The property is as follows : 

>Let `φ(x)` be a property provable about objects `x` of type `T`. Then `φ(y)` should also be true for objects `y` of type `S` where `S` is a subtype of `T` 

In simple words, 
1. Objects of a superclass should be able to be replaced with objects of a subclass without affecting the program.
2. Object of subclass should be able to access the all the methods and properties of the superclass.

## Design
This project defines a Notifications Interface which have `Send()`. Two classes inherited from above, namely `EmailNotification` and `SmsNotification` implement the functions. 

![Module & Class diagram][def]

[def]: ModuleAndClassDiagram.jpg

## Environment
The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.