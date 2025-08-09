# Example of the strategy pattern implementation

This micro project is an example of the strategy pattern implementation.
The task is to create different email types (welcome email, forgot password email, welcome email, etc.) and abstract 
the logic of building this email type in the client code.

## How to read this project
The `EmailType` enum lists all email types available in the system.

The `IEmailStrategy` interface defines a method to build an email and defines a field that would set the type of the 
email. Each email type should implement this interface and set the correct `EmailType` field.

The `EmailBuilder` class is a context in this pattern and is the class that loads all the strategies into a dictionary
and defines a single method to get a strategy for a given type. The client code calls this class to get an email type.

The `UserService` is just a sample service that is supposed to send emails to users. It is calling the `EmailBuilder`
context to build and return an email of a specific type.

The runnable code is inside the `Program` class. Because this project is written in plain C# code, without the ASP.NET,
it doesn't have any DI container to manage dependencies. Thus, all dependencies are resolved manually.
