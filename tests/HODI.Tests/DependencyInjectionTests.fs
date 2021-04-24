module HODI.DependencyInjection.Tests

open System.Threading.Tasks

open Microsoft.AspNetCore.Http

open Microsoft.Extensions.DependencyInjection

open NSubstitute

open NUnit.Framework

type HttpFunc = HttpContext -> Task<HttpContext option>

let next = Substitute.For<HttpFunc>()

type TestDependency() =
    member dep.AssertCreated() = Assert.Pass()

type FakeDependency0() =
    inherit TestDependency()

type FakeDependency1() =
    inherit TestDependency()

type FakeDependency2() =
    inherit TestDependency()

type FakeDependency3() =
    inherit TestDependency()

type FakeDependency4() =
    inherit TestDependency()

type FakeDependency5() =
    inherit TestDependency()

type FakeDependency6() =
    inherit TestDependency()

[<Test>]
let ``The inject function should get a dependency from the service container and pass it to the given handler`` () =
    let systemUnderTest = inject

    let givenHandler =
        fun (dep : FakeDependency0) next (ctx : HttpContext) ->
            dep.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler next serviceContainer
    |> ignore


[<Test>]
let ``The inject2 function should get 2 dependenies from the service container and pass it to the given handler`` () =
    let systemUnderTest = inject2

    let givenHandler =
        fun (dep : FakeDependency0) (dep2 : FakeDependency1) next (ctx : HttpContext) ->
            dep.AssertCreated()
            dep2.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler next serviceContainer
    |> ignore

[<Test>]
let ``The inject3 function should get 3 dependenies from the service container and pass it to the given handler`` () =
    let systemUnderTest = inject3

    let givenHandler =
        fun (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) next (ctx : HttpContext) ->
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler next serviceContainer
    |> ignore

[<Test>]
let ``The inject4 function should get 4 dependenies from the service container and pass it to the given handler`` () =
    let systemUnderTest = inject4

    let givenHandler =
        fun (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) (dep4 : FakeDependency3) next (ctx : HttpContext) ->
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            dep4.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    services.AddTransient<FakeDependency3>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler next serviceContainer
    |> ignore

[<Test>]
let ``The inject5 function should get 5 dependenies from the service container and pass it to the given handler`` () =
    let systemUnderTest = inject5

    let givenHandler =
        fun (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) (dep4 : FakeDependency3) (dep5 : FakeDependency4) next (ctx : HttpContext) ->
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            dep4.AssertCreated()
            dep5.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    services.AddTransient<FakeDependency3>() |> ignore
    services.AddTransient<FakeDependency4>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler next serviceContainer
    |> ignore


[<Test>]
let ``The inject6 function should get 6 dependenies from the service container and pass it to the given handler`` () =
    let systemUnderTest = inject6

    let givenHandler =
        fun (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) (dep4 : FakeDependency3) (dep5 : FakeDependency4) (dep6 : FakeDependency5) next (ctx : HttpContext) ->
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            dep4.AssertCreated()
            dep5.AssertCreated()
            dep6.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    services.AddTransient<FakeDependency3>() |> ignore
    services.AddTransient<FakeDependency4>() |> ignore
    services.AddTransient<FakeDependency5>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler next serviceContainer
    |> ignore

[<Test>]
let ``The inject7 function should get 7 dependenies from the service container and pass it to the given handler`` () =
    let systemUnderTest = inject7

    let givenHandler =
        fun (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) (dep4 : FakeDependency3) (dep5 : FakeDependency4) (dep6 : FakeDependency5) (dep7 : FakeDependency6) next (ctx : HttpContext) ->
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            dep4.AssertCreated()
            dep5.AssertCreated()
            dep6.AssertCreated()
            dep7.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    services.AddTransient<FakeDependency3>() |> ignore
    services.AddTransient<FakeDependency4>() |> ignore
    services.AddTransient<FakeDependency5>() |> ignore
    services.AddTransient<FakeDependency6>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler next serviceContainer
    |> ignore

[<Test>]
[<TestCase("This is a string")>]
let ``The injectPlus function should get a dependency from the service container and pass them and an additional argument to the given handler`` givenAdditionalArgument
                                                                                                                                                 =
    let systemUnderTest = injectPlus

    let givenHandler =
        fun (addl : string) (dep : FakeDependency0) next (ctx : HttpContext) ->
            Assert.AreEqual(givenAdditionalArgument, addl)
            dep.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler givenAdditionalArgument next serviceContainer
    |> ignore


[<Test>]
[<TestCase("This is a string")>]
let ``The inject2Plus function should get 2 dependenies from the service container and pass it and an additional argument to the given handler`` givenAdditionalArgument
                                                                                                                                                 =
    let systemUnderTest = inject2Plus

    let givenHandler =
        fun (addl : string) (dep : FakeDependency0) (dep2 : FakeDependency1) next (ctx : HttpContext) ->
            Assert.AreEqual(givenAdditionalArgument, addl)
            dep.AssertCreated()
            dep2.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler givenAdditionalArgument next serviceContainer
    |> ignore

[<Test>]
[<TestCase("This is a string")>]
let ``The inject3Plus function should get 3 dependenies from the service container and pass them and another argument to the given handler`` givenAdditionalArgument
                                                                                                                                             =
    let systemUnderTest = inject3Plus

    let givenHandler =
        fun (addl : string) (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) next (ctx : HttpContext) ->
            Assert.AreEqual(givenAdditionalArgument, addl)
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler givenAdditionalArgument next serviceContainer
    |> ignore

[<Test>]
[<TestCase("This is a string")>]
let ``The inject4Plus function should get 4 dependenies from the service container and pass them and another argument to the given handler`` givenAdditionalArgument
                                                                                                                                             =
    let systemUnderTest = inject4Plus

    let givenHandler =
        fun (addl : string) (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) (dep4 : FakeDependency3) next (ctx : HttpContext) ->
            Assert.AreEqual(givenAdditionalArgument, addl)
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            dep4.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    services.AddTransient<FakeDependency3>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler givenAdditionalArgument next serviceContainer
    |> ignore

[<Test>]
[<TestCase("This is a string")>]
let ``The inject5Plus function should get 5 dependenies from the service container and pass them and another arguments to the given handler`` givenAdditionalArgument
                                                                                                                                              =
    let systemUnderTest = inject5Plus

    let givenHandler =
        fun (addl : string) (dep : FakeDependency0) (dep2 : FakeDependency1) (dep3 : FakeDependency2) (dep4 : FakeDependency3) (dep5 : FakeDependency4) next (ctx : HttpContext) ->
            Assert.AreEqual(givenAdditionalArgument, addl)
            dep.AssertCreated()
            dep2.AssertCreated()
            dep3.AssertCreated()
            dep4.AssertCreated()
            dep5.AssertCreated()
            next ctx

    let serviceContainer = Substitute.For<HttpContext>()

    let services = ServiceCollection()
    services.AddTransient<FakeDependency0>() |> ignore
    services.AddTransient<FakeDependency1>() |> ignore
    services.AddTransient<FakeDependency2>() |> ignore
    services.AddTransient<FakeDependency3>() |> ignore
    services.AddTransient<FakeDependency4>() |> ignore
    let provider = services.BuildServiceProvider()
    serviceContainer.RequestServices <- provider

    systemUnderTest givenHandler givenAdditionalArgument next serviceContainer
    |> ignore
