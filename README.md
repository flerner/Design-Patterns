# Design-Patterns

Creational Patterns:

1 -> Factory Method
Factory Method is a pattern that provides a interface for creating objects in a superclass and allows the child classes to modify the type of objects that will be created.
Despite its name, the creator class main responsibility is not creating products, and it usually contains some core business logic that relies on product objects returned by this creator. Subclasses can even change some details of the core logic overriding a method.

When to use this pattern?
-Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
-Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.

2 -> Abstract Factory
