![AutoMapper](https://camo.githubusercontent.com/603a9fdf1c6578e4df423ecdb784cb5d634e016850c10ba0798970fd48c55d41/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f6175746f6d61707065722f6c6f676f2e706e67)

## Forked
This project was forked due to development only progressing on .Net Core and being dropped for the .Net Framework. .Net Framework 4.8 needs support due to WPF applications that require integration with MS Office and/or COM libraries.



### What is AutoMapper?

AutoMapper is a simple little library built to solve a deceptively complex problem - getting rid of code that mapped one object to another. This type of code is rather dreary and boring to write, so why not invent a tool to do it for us?

This is the main repository for AutoMapper, but there's more:

* [Microsoft DI Extensions](https://github.com/AutoMapper/AutoMapper.Extensions.Microsoft.DependencyInjection)
* [Collection Extensions](https://github.com/AutoMapper/AutoMapper.Collection)
* [Expression Mapping](https://github.com/AutoMapper/AutoMapper.Extensions.ExpressionMapping)
* [EF6 Extensions](https://github.com/AutoMapper/AutoMapper.EF6)
* [IDataReader/Record Extensions](https://github.com/AutoMapper/AutoMapper.Data)
* [Enum Extensions](https://github.com/AutoMapper/AutoMapper.Extensions.EnumMapping)

### How do I get started?

First, configure AutoMapper to know what types you want to map, in the startup of your application:

```csharp
var configuration = new MapperConfiguration(cfg => 
{
    cfg.CreateMap<Foo, FooDto>();
    cfg.CreateMap<Bar, BarDto>();
});
// only during development, validate your mappings; remove it before release
configuration.AssertConfigurationIsValid();
// use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
var mapper = configuration.CreateMapper();
```
Then in your application code, execute the mappings:

```csharp
var fooDto = mapper.Map<FooDto>(foo);
var barDto = mapper.Map<BarDto>(bar);
```

Check out the [getting started guide](https://automapper.readthedocs.io/en/latest/Getting-started.html). When you're done there, the [wiki](https://automapper.readthedocs.io/en/latest/) goes in to the nitty-gritty details. If you have questions, you can post them to [Stack Overflow](https://stackoverflow.com/questions/tagged/automapper) or in our [Gitter](https://gitter.im/AutoMapper/AutoMapper).

### Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [AutoMapper](https://www.nuget.org/packages/AutoMapper/) from the package manager console:

```
PM> Install-Package AutoMapper
```
Or from the .NET CLI as:
```
dotnet add package AutoMapper
```

### Do you have an issue?

First check if it's already fixed by trying the [MyGet build](https://automapper.readthedocs.io/en/latest/The-MyGet-build.html).

You might want to know exactly what [your mapping does](https://automapper.readthedocs.io/en/latest/Understanding-your-mapping.html) at runtime.

If you're still running into problems, file an issue above.

### License, etc.

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

AutoMapper is Copyright &copy; 2009 [Jimmy Bogard](https://jimmybogard.com) and other contributors under the [MIT license](LICENSE.txt).

### .NET Foundation

This project is supported by the [.NET Foundation](https://dotnetfoundation.org).
