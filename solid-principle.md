
##SOLID

### Single Responsibility Principle (SRP)
SRP says "Every software module should have only one reason to change".

### Open/Closed Principle
The Open/closed Principle says "A software module/class is open for extension and closed for modification".

### Liskov Substitution Principle
The Liskov Substitution Principle (LSP) states that "you should be able to use any derived class instead of a parent class 
and have it behave in the same manner without modification". It ensures that a derived class does not affect the behavior of the parent class, 
in other words,, that a derived class must be substitutable for its base class.
 
This principle is just an extension of the Open Closed Principle and it means that we must ensure that new derived classes 
extend the base classes without changing their behavior.

### Interface Segregation Principle (ISP)
The Interface Segregation Principle states "that clients should not be forced to implement interfaces they don't use. Instead of one fat interface, 
many small interfaces are preferred based on groups of methods, each one serving one submodule.".

### Dependency Inversion Principle
The Dependency Inversion Principle (DIP) states that high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions.
