# .NET Unit Testing Tutorial
.NET Unit Testing Tutorial
This is a tutorial for learning .NET Unit Testing and is part of a blog series and video series. I will cover unit testing frameworks such as, MSTest, nSpec, NUnit, xUnit, and Selenium. The more advanced techniques that will be covered will demonstrate how to use reflection to test private methods, mocking frameworks like Moq, Stubs & Fakes with MSTest, and more.

Learning to write unit tests can make you a much better developer. Instead of building the UI, then the data access layer, then the SQL database, you can work backwards. Build the stored procedure, then the data access layer, and finally the UI last.

**THIS IS UNDER CONSTRUCTION**
Blog post not ready, many of the projects below are not ready either.. video coming afterwards.

## What you need to know first.
Before venturing into unit testing it's best to make sure that you understand Dependency Injection (DI) and the Repository Pattern.

### Dependency Injection (DI)
This follows the Hollywood Principle, "Don't call us; we'll call you.". Instead of instantiating concrete classes, the principles of inversion of control can be applied by using a dependency resolver to map concrete classes to interfaces.

### Repository Pattern

### Build Servers
I'll be using Azure DevOps for my samples since this is becoming more popular. As an alternative, you could use AppVeyor or Jenkins.

## Best Practices
The biggest thing with unit testing is being able to write decoupled code that is capable of being unit tested.

### Code Coverage
100% code coverage is not a thing. It's not even remotely practical to have 100% code coverage. So, what is good code coverage? Anything above 0% is a start and is good. Ideally 70-80% code coverage should cover your application while leaving out the parts that don't need to be unit tested. It is not important to test the dependency resolver, constructors, getters, setters, or catches in your try catch calls. What is important is that you test your internal code that handles the primary functionality.

## Unit Testing Frameworks
There are many unit testing frameworks available on the market and as I learn new ones I will add them here. These are the mones that I am most familiar with and are still relevant today.

### MSTest

### NUnit

### xUnit

### nSpec

## Advanced Techniques

### Expecting Exceptions

### Reflection

### Moq

## Selenium
I thought I would put this in here just for fun. This really doesn't fall into line with typical unit testing where efficiency and speed is needed to run consitantly on a build server. However, this can be inlcluded in the build pipeline and does work. I haven't tried this before and will update this when I figure out how performant this is.
