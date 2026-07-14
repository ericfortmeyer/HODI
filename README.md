<div align=center>
    <img src="https://raw.githubusercontent.com/ericfortmeyer/HODI/master/hodi.png" alt="Logo of HODI">
</div>

# HODI

Higher Order Dependency Injection

[HODI](https://www.nuget.org/packages/HODI/) is a set of functions designed to be simple and consistent with a minimal implementation.

[![NuGet Downloads](https://img.shields.io/nuget/dt/HODI.svg)](https://www.nuget.org/packages/HODI/)
[![Coverage Status](https://coveralls.io/repos/github/ericfortmeyer/HODI/badge.svg?branch=main)](https://coveralls.io/github/ericfortmeyer/HODI?branch=main)

## Why HODI?

- **Testable by default**: pass dependencies as arguments, not service locators
- **Type-safe**: compiler catches missing deps before runtime
- **Works with Giraffe/web handlers**

## Install

```PowerShell
PM> Install-Package HODI
```

or...

```zsh
dotnet add package HODI
```

## Defining Handlers

Instead of...

```fsharp
let oldWayHandler : HttpHandler =
    fun (next: HttpFunc) (ctx: HttpContext) ->
        task {
            let dep = ctx.GetService<Dependency>()
            // ...
        }
```

this can be done...

```fsharp
let anotherWayHandler : HttpHandler =
    fun (dep: Dependency) (next: HttpFunc) (ctx: HttpContext) ->
        task {
            // ...
        }
```

## Usage

The functions can be used when defining routes.

```fsharp
let app =
    choose [
        route "/a" >=> exampleHandler |> inject
        route "/b" >=> handlerWith2Dependencies |> inject2
        routef "/c/%s" >=> handlerWithArgumentAndDependency |> injectPlus
    ]
```

## Unit Testing

When unit testing the HTTPHandler functions, you could simply pass the dependencies without having to set up a test server.
In other words, the tests can focus on the handlers behavior instead of caring about dependency injection.
