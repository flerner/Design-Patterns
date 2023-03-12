# Design-Patterns

Creational Patterns:


1 -> Factory Method
Factory Method is a pattern that provides a interface for creating objects in a superclass and allows the child classes to modify the type of objects that will be created.
Despite its name, the creator class main responsibility is not creating products, and it usually contains some core business logic that relies on product objects returned by this creator. Subclasses can even change some details of the core logic overriding a method.

When to use this pattern?

-Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.

-Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.


2 -> Abstract Factory
Abstract Factory is a pattern that lets your produce families or related objects without specifying their concrete class.
The abstract factory interface declares a set of methods that return different abstract products.
Concrete factories produce a family of products that belong to a single variant.
For example: We want to create chairs an tables, but each chair or table can be victorian or modern. So, the abstract factory declares the methdos CreateChair() : Chair and CreateTable(): Table. Now, the concrete factory will create all the products of style modern. So, ModernFactory will be able to return either a modern chair or a modern table, and the type of the return will be an abstract class or interface _Table_ or _Chair_ so the abstract factory will never know wich type of product is being made.

When to use this pattern?

-Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.

-Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.


3 -> Builder Pattern
The Builder Pattern allows you to construct complex objects step by step. It allows you to produce different types and representations of an object using the same construction code.
Using the Builder pattern makes sense only when your products are quite complex and require extensive configuration. Such as nested objects, you can build each object in a different step, making the final object in many steps.

When to use this pattern?

-Use the Builder pattern to get rid of a “telescoping constructor”. That means overloading the constructor many times for each variant of the object and some constructors may finish with a lot of parametters, wich is not recommended.


4 -> Prototype Pattern
Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.
The Prototype pattern delegates the cloning process to the actual objects that are being cloned. If not, we would have to create the object, and iterate through all its fields to copy them, but doing this we would break the privacy of the object and we would being exposing too much the object.
The pattern declares a common interface for all objects that support cloning, usuallt with only one method Clone(). In the concrete object to clone is as simple as implement that method returning a new ObjectName(this).

When to use this pattern?

Use the Prototype pattern when your code shouldn’t depend on the concrete classes of objects that you need to copy.

 Use the pattern when you want to reduce the number of subclasses that only differ in the way they initialize their respective objects.

