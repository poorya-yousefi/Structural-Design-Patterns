# Decorator Design Pattern

## Summary

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

## Problem

You want to add responsibilities to objects without modifying their code. Subclassing is one way to extend functionality, but it is not always the best approach. Subclassing can lead to a class hierarchy that is difficult to understand and maintain.

## Solution

Extending a class is the first thing that comes to mind when you need to alter an object’s behavior. However, `inheritance` has several serious caveats that you need to be aware of.

- `Inheritance` is static. You can’t alter the behavior of an existing object at runtime. You can only replace the whole object with another one that’s created from a different subclass.
- Subclasses can have just one parent class. In most languages, `inheritance` doesn’t let a class inherit behaviors of multiple classes at the same time.
  
One of the ways to overcome these caveats is by using `Aggregation` or `Composition`  instead of `Inheritance`. Both of the alternatives work almost the same way: one object has a reference to another and delegates it some work, whereas with `inheritance`, the object itself is able to do that work, inheriting the behavior from its superclass.

> **Aggregation**: object A contains objects B; B can live without A.
> **Composition**: object A consists of objects B; A manages life cycle of B; B can’t live without A.

With this new approach you can easily substitute the linked “helper” object with another, changing the behavior of the container at runtime. An object can use the behavior of various classes, having references to multiple objects and delegating them all kinds of work. Aggregation/composition is the key principle behind many design patterns, including Decorator. On that note, let’s return to the pattern discussion.

## Pros

- **Flexibility**: You can add or remove responsibilities to objects at runtime.
- **Single Responsibility Principle**: You can divide a complex task into smaller, more manageable classes.
- **Open/Closed Principle**: You can extend the behavior of an object without modifying its code.

## Cons

- **Complexity**: The code can become complex and harder to understand due to the many small classes.
- **Performance**: Adding multiple layers of decorators can impact performance.
- **Code Style**: The initial configuration code of layers might look pretty ugly.

## Usage in Real World

- **Graphical User Interfaces (GUIs)**: Adding functionalities like scroll bars, borders, or shadows to windows or text fields.
- **Streams in I/O**: Java I/O streams use decorators to add functionalities like buffering, data conversion, or compression.
- **Logging**: Adding different logging behaviors (e.g., logging to a file, console, or remote server) dynamically.
- **Data Wrappers**: Wrapping data objects to add additional behaviors like *validation*, *formatting*, or *encryption*.
- **Middleware in Web Servers**: Adding functionalities like *authentication*, *logging*, or *compression* to HTTP requests and responses.

## Relations with Other Patterns

- `Adapter` provides a completely different interface for accessing an existing object. On the other hand, with the **Decorator** pattern the interface either stays the same or gets extended. In addition, **Decorator** supports recursive composition, which isn’t possible when you use Adapter.

- With `Adapter` you access an existing object via different interface. With `Proxy`, the interface stays the same. With **Decorator** you access the object via an enhanced interface.

- `Chain of Responsibility` and **Decorator** have very similar class structures. Both patterns rely on recursive composition to pass the execution through a series of objects. However, there are several crucial differences.

> The CoR handlers can execute arbitrary operations independently of each other. They can also stop passing the request further at any point. On the other hand, various Decorators can extend the object’s behavior while keeping it consistent with the base interface. In addition, decorators aren’t allowed to break the flow of the request.

- `Composite` and **Decorator** have similar structure diagrams since both rely on recursive composition to organize an open-ended number of objects.

> A **Decorator** is like a `Composite` but only has one child component. There’s another significant difference: **Decorator** adds additional responsibilities to the wrapped object, while `Composite` just “sums up” its children’s results.
> However, the patterns can also cooperate: you can use **Decorator** to extend the behavior of a specific object in the Composite tree.

- Designs that make heavy use of `Composite` and **Decorator** can often benefit from using `Prototype`. Applying the pattern lets you clone complex structures instead of re-constructing them from scratch.

- **Decorator** lets you change the skin of an object, while `Strategy` lets you change the guts.

- **Decorator** and `Proxy` have similar structures, but very different intents. Both patterns are built on the composition principle, where one object is supposed to delegate some of the work to another. The difference is that a Proxy usually manages the life cycle of its service object on its own, whereas the composition of Decorators is always controlled by the client.
