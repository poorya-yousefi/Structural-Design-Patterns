# Adapter Design Pattern

The `Adapter` Pattern converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.
An `adapter` wraps one of the objects to hide the complexity of conversion happening behind the scenes. The wrapped object isn’t even aware of the adapter. For example, you can wrap an object that operates in meters and kilometers with an adapter that converts all of the data to imperial units such as feet and miles.

## Applicability

Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.

> The Adapter pattern lets you create a middle-layer class that serves as a translator between your code and a legacy class, a 3rd-party class or any other class with a weird interface.

Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.

> You could extend each subclass and put the missing functionality into new child classes. However, you’ll need to duplicate the code across all of these new classes, which smells really bad.

## Pros

- Single Responsibility Principle. You can separate the interface or data conversion code from the primary business logic of the program.
- Open/Closed Principle. You can introduce new types of adapters into the program without breaking the existing client code, as long as they work with the adapters through the client interface.

## Cons

- The overall complexity of the code increases because you need to introduce a set of new interfaces and classes. Sometimes it’s simpler just to change the service class so that it matches the rest of your code.

## Relations with other patterns

- `Bridge` is usually designed up-front, letting you develop parts of an application independently of each other. On the other hand, **Adapter** is commonly used with an existing app to make some otherwise-incompatible classes work together nicely.

- **Adapter** provides a completely different interface for accessing an existing object. On the other hand, with the `Decorator` pattern the interface either stays the same or gets extended. In addition, Decorator supports recursive composition, which isn’t possible when you use **Adapter**.

- With **Adapter** you access an existing object via different interface. With `Proxy`, the interface stays the same. With `Decorator` you access the object via an enhanced interface.

- `Facade` defines a new interface for existing objects, whereas **Adapter** tries to make the existing interface usable. **Adapter** usually wraps just one object, while Facade works with an entire subsystem of objects.

- `Bridge`, `State`, `Strategy` (and to some degree **Adapter**) have very similar structures. Indeed, all of these patterns are based on *composition*, which is delegating work to other objects. However, they all solve different problems. A pattern isn’t just a recipe for structuring your code in a specific way. It can also communicate to other developers the problem the pattern solves.
