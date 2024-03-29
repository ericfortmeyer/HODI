![Logo of HODI](https://raw.githubusercontent.com/ericfortmeyer/HODI/master/hodi.png)

# HODI

Higher Order Dependency Injection

[HODI](https://www.nuget.org/packages/HODI/) is a set of functions designed to be simple and consistent with a minimal implementation.

The purpose of this library is to make unit testing of functions used as HTTP handlers in F# web applications more straightforward.

[![NuGet Info](https://buildstats.info/nuget/HODI?includePreReleases=true)](https://www.nuget.org/packages/HODI/)

[![Build](https://github.com/ericfortmeyer/HODI/actions/workflows/multiple_builds.yml/badge.svg)](https://github.com/ericfortmeyer/HODI/actions/workflows/multiple_builds.yml)
[![Coverage Status](https://coveralls.io/repos/github/ericfortmeyer/HODI/badge.svg?branch=main)](https://coveralls.io/github/ericfortmeyer/HODI?branch=main)

## Install

```
PM> Install-Package HODI
```

or...

```
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
