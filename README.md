# Design-Patterns

### Creational Patterns:


## 1 -> Factory Method

Factory Method is a pattern that provides a interface for creating objects in a superclass and allows the child classes to modify the type of objects that will be created.
Despite its name, the creator class main responsibility is not creating products, and it usually contains some core business logic that relies on product objects returned by this creator. Subclasses can even change some details of the core logic overriding a method.

**When to use this pattern?**

- Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.

- Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.


## 2 -> Abstract Factory

Abstract Factory is a pattern that lets your produce families or related objects without specifying their concrete class.
The abstract factory interface declares a set of methods that return different abstract products.
Concrete factories produce a family of products that belong to a single variant.
For example: We want to create chairs an tables, but each chair or table can be victorian or modern. So, the abstract factory declares the methdos CreateChair() : Chair and CreateTable(): Table. Now, the concrete factory will create all the products of style modern. So, ModernFactory will be able to return either a modern chair or a modern table, and the type of the return will be an abstract class or interface _Table_ or _Chair_ so the abstract factory will never know wich type of product is being made.

**When to use this pattern?**

- Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.

- Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.


## 3 -> Builder Pattern

The Builder Pattern allows you to construct complex objects step by step. It allows you to produce different types and representations of an object using the same construction code.
Using the Builder pattern makes sense only when your products are quite complex and require extensive configuration. Such as nested objects, you can build each object in a different step, making the final object in many steps.

**When to use this pattern?**

- Use the Builder pattern to get rid of a “telescoping constructor”. That means overloading the constructor many times for each variant of the object and some constructors may finish with a lot of parametters, wich is not recommended.


## 4 -> Prototype Pattern

Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.
The Prototype pattern delegates the cloning process to the actual objects that are being cloned. If not, we would have to create the object, and iterate through all its fields to copy them, but doing this we would break the privacy of the object and we would being exposing too much the object.
The pattern declares a common interface for all objects that support cloning, usuallt with only one method Clone(). In the concrete object to clone is as simple as implement that method returning a new ObjectName(this).

**When to use this pattern?**

- Use the Prototype pattern when your code shouldn’t depend on the concrete classes of objects that you need to copy.

- Use the pattern when you want to reduce the number of subclasses that only differ in the way they initialize their respective objects.
 
 
## 5 -> Singleton Pattern
 
Singleton is a creational design pattern that ensure that a class has only one instance, allowing acces globally.
Constructor of this class will be private so anyone can instanciate it, and provides a static method to get the instance, where if no one called that method a new instance will be returned, but if that method were called at least once, it will return the existing instance.
 
 **When to use this pattern?**
 
 - When you want only one instance of a class for all clients, for example, a single database object shared by different parts of the program. 
 
 - Use the Singleton pattern when you need stricter control over global variables.
 
 
### Structural Patterns:
 
## 1 -> Adapter
 
Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
If there is a class that you need to use, but its interface is not compatible with the rest of the code, you can use this pattern, that creating a class that support both the interface of the new class and the old class that need the new one, it can make a business logic that includes both classes.
One option is that the adapter class extends the old class so it can operate like that class, and it has an instance of the new class, so you can make logic that includes both classes.
 
 **When to use this pattern?**
 
 - Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.
 
 - Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.
 
 
## 2 -> Bridge
 
Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.
Without using brinde, a class can get a lot of subclasses for variants of the superclass. For example, a class Shape that has two subclasses, Circle and Square. If we want to add colours to that classes, we should extend Circle and make as much subclasses as colours we want. So, instead, we can make an independent hierarchy, with a superclass Colour, and subclasses with the real implementation, and in the class Shape, we declare an instance of the hierarchy Colour. So, now we can combine any shape with any colour without getting a hierarchy with many subclasses.



## 3 -> Composite

Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.
When a project structure is tree-like, I mean, if your hierarchy is structured by products and containers (containers can store products or more containers), and you want to iterate every class for doing something, lets say CalculateTotal(), you could iterate between all objects and asking if its a product or its a containers, and then if its a containers you should iterate that container as well, and that would be messy.
Instead you could apply composite pattern which declares a common interface between all objects in the tree with business logic method, in this case CalculateTotal(), and in the case of composite that method will iterate all the products inside and ask for its total, and in the case of the product it will just return its total. That way, from the client code, you don't need to know if its a final product or a container, you just call the method and the classes work it through.
Imagine a project that contains directorys and files. Directorys can store more directorys or just files (will be stored in a variable of the type of the interface, lets call it Component. So you can just call the method without worrying if its a file or a directory). In the directory class the buisness logic method will iterate the collection of components without knowing its type and calling the method. If the iterator is on a container, will repeat that logic, if its a product it will return the total, so every component will be iterated.

**When to use this pattern?**

- Use the Composite pattern when you have to implement a tree-like object structure

- Use the pattern when you want the client code to treat both simple and complex elements uniformly.


## 4 -> Decorator

Decorator is a structural design pattern that allows you to add extra functionality to an object without changing it, but instead declaring a wrapper that contains that object and can add extra methods. Each wrapper can hold another wrapper with a concrete component inside or another wrapper, there is no limit of the chain of wrappers. Allways the last wrapper must have the concrete component.
Every decorator and component must implement the same interface, so both can be wrapped with composition/aggregation under the same type. So, the base decorator implemets the same interface that the concrete object and at the same time contains a reference to an object (component or another decorator) under the type of the interface.

**When to use this pattern?**

- Use the Decorator pattern when you need to be able to assign extra behaviors to objects at runtime without breaking the code that uses these objects.
- Use the pattern when it’s awkward or not possible to extend an object’s behavior using inheritance.


## 5 -> Facade

Facade is a structural design pattern that gives a reduced interface to a library or framework or any other complex group of objects.
If you want to acces a specific functionality of a complex structure of classes you may want to use a facade, wich knows only how to deal with that funcionality, without accesing directly to the structure. The facade can have references to the objects needed, or as well it can receive it as parameters of a method, and solve the funcionality by itself. The client only know the facade.


**When to use this pattern?**

- Use the facade pattern if you need a limited but direct interface to a complex system.
- When you want to structure a subsystem in layers.


## 6 -> Flyweight

Is a structural pattern that allows you to keep shared parts of an object divided in different objects insted of keeping all the information inside each object. This aims to reduce the amount of RAM consumed.
Imagine that you have a forest with a collection of trees. Each tree has a name, colour, texture and position in the forest. Almost every tree is of the same family so its name, colour and texture will be the same.
So, you can extract that information to another class so, now we have two classes: TreeType (name, colour, texture) and Tree (x, y). That information that is immutable and shared with a lot of objects its called "Instrinsic state" whereas the information that
change in every object like position its called "Extrinsic state". So, the class wich we are dividing should keep the extrinsic state, and the intrinsic state should be moved to another class. (Tree will be our main class and TreeType our Flyweight class).
It is used to have a factory for the Flyweight class with a method GetFlyweight where check if in the collection of flyweights already exist a class with required attributes, if does return that instance, if not, return a new instance with that attributes.

**When to use this pattern?**

-Use the Flyweight pattern only when your program must support a huge number of objects which barely fit into available RAM.

## 7 -> Proxy

A structural pattern that allows to provide a substitute or intermediate for an object. It could have many reasons for existing like, security steps, cache storaging, basically everything that you would like to execute before executing the actual object you can do it at the proxy class.
And yu can add more proxies without touching the service code, that helps with open/closed principle.

**When to use this pattern?**

-Acces control: When you want that only specific clients be able to use the object of service.
-Local execution of a remote service: When an object is located at a remote server, you can delegate all the ugly steps of working with the network to the proxy so the object only receive the final data.
-Register request: When you want to keep a history of requests to the service object.



### Behavioral Patterns:

## 1 -> Chain of Responsibility

It's a pattern that lets you pass requests along a chain of handlers. Each handler can decide if process the request or pass it to the next handler in chain.
You could have several validations methods in a class with a lot of conditionals but that would be messy.
Instead, you define several classes with a single method that performs the check, and the request, along with its data is passed to this method as an argument. Each one of this classes has a pointer to the next class in chain.
The class can perform the check or pass it to another class if the conditions are not for this class, or even cancel the action if data is corrupted or incorrect.

**When to use this pattern?**

- Use the Chain of Responsibility pattern when your program is expected to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand.
- Use the pattern when it’s essential to execute several handlers in a particular order.
- When the set of handlers and their order are supposed to change at runtime. If you provide setters for a reference field inside the handler classes, you’ll be able to insert, remove or reorder handlers dynamically.


## 2 -> Command

Its a pattern that converts a request into an object (command) wich contains all the info about the request. That allows you to make the request into different methods, put it int a queue.

**When to use this pattern?**

- If you want to put operations in queue, program its execution or execute them remotely.
- If you want to implement reversible operations. When you make a request that request converts into an object and putted into a queue or requests. If you want to delete, or change a request, you can just go to that queue and modify it.


## 3 -> Iterator


Iterator pattern allows to iterate through a collection without knowing its implementation. I mean that that collection can be of any type, and for each type we can create a different iterator, so each concrete iterator will know how to iterate that collection. We even can create multiple iterators for a same collection, if we want to iterate it in different ways.

**When to use this pattern?**

 - Use the Iterator pattern when your collection has a complex data structure under the hood, but you want to hide its complexity from clients: The iterator encapsulates the details of working with a complex data structure, providing the client with several simple methods of accessing the collection elements. 
 - Use the pattern to reduce duplication of the traversal code across your app: Iteration codes can be very unplacent to see, so if we implement that in the middle of a business logic it could be very difficult to understand and mantain. So we delegate that responsibility to a concrete class. 


## 4 -> Mediator

When a class has a specific behaviour based on the stimulus that receive, and you want to reuse that class if the stimulus is different, you're gonna have to add a bunch of conditionals to change the behaviour. Instead of that, you can use a Mediator class, that receive the stimulus of the class, and can receive stimulus from a bunch of other classes, and there is where you put all the logic and conditionals to change the behaviour. Imagine a button that you want to reuse to make it do different actions, and input textbox, all connected and with a lot of conditionals in each class to respond to a certain button, or a certain input textbox. Instead of that, you send all the information to a Mediator class through a common interface so each component only depends on an abstraction, and that class process and make a response based on the information received.

**When to use this pattern?**

- When you realise that a few classes depends on a lot of other classes, you can extract all the dependencies to a single Mediator class and aislating any specific change of the specific classes.
- When you can't use a component in another program because it has too many dependencies on specific classes.
- When you find yourself creating a lot of subclasses to change specific behaviours to classes that share a common basic behaviour.


## 5 -> Memento

Allows to go back to a previous state of an object, that is possible trough an intermediate class Memento, wich store the state of the object at that time, and saved in a stack of Mementos, so the object can go back to a previous state popping out a state of the stack.

**When to use this pattern?**
- When you want to produce snapshots of the object’s state to be able to restore a previous state of the object: A common example is the "undo" function, but it is also very common in transactions, when you need to undo it because of an error.
- When direct access to the object’s fields/getters/setters violates its encapsulation.


## 6 -> Observer


