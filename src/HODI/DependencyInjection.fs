namespace HODI

open System.Threading.Tasks
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection

/// <summary>
/// A set of functions used to inject dependencies into higher order functions.
/// </summary>
module DependencyInjection =

    /// <summary>
    /// Gets a dependency from the DI container and provides it to the supplied handler.
    ///
    /// Types can be inferred making the code below possible:
    ///
    /// funcWithADependency |> <see cref="inject" />
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject (handler : 'Dep -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
               (next : HttpContext -> Task<HttpContext option>)
               (ctx : HttpContext)
               : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep: 'Dep = services.GetRequiredService<'Dep>()

        handler dep next ctx

    /// <summary>
    /// Gets 2 dependencies from the DI container and provides them to the supplied handler.
    ///
    /// Type inference makes the following possible:
    ///
    /// funcWith2Dependencies |> <see cref="inject2" />
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject2 (handler : 'Dep0 -> 'Dep1 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                (next : HttpContext -> Task<HttpContext option>)
                (ctx : HttpContext)
                : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        handler dep0 dep1 next ctx

    /// <summary>
    /// Gets 3 dependencies from the DI container and provides them to the supplied handler.
    ///
    /// Type inference makes the following possible:
    ///
    /// funcWith3Dependencies |> <see cref="inject3" />
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject3 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                (next : HttpContext -> Task<HttpContext option>)
                (ctx : HttpContext)
                : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        handler dep0 dep1 dep2 next ctx

    /// <summary>
    /// Gets 4 dependencies from the DI container and provides them to the supplied handler.
    ///
    /// Type inference makes the following possible:
    ///
    /// funcWith4Dependencies |> <see cref="inject4" />
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject4 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                (next : HttpContext -> Task<HttpContext option>)
                (ctx : HttpContext)
                : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        handler dep0 dep1 dep2 dep3 next ctx

    /// <summary>
    /// Gets 5 dependencies from the DI container and provides them to the supplied handler.
    ///
    /// Type inference makes the following possible:
    ///
    /// funcWith5Dependencies |> <see cref="inject5" />
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject5 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                (next : HttpContext -> Task<HttpContext option>)
                (ctx : HttpContext)
                : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        let dep4: 'Dep4 = services.GetRequiredService<'Dep4>()

        handler dep0 dep1 dep2 dep3 dep4 next ctx

    /// <summary>
    /// Gets 6 dependencies from the DI container and provides them to the supplied handler.
    ///
    /// Type inference makes the following possible:
    ///
    /// funcWith6Dependencies |> <see cref="inject6" />
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject6 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> 'Dep5 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                (next : HttpContext -> Task<HttpContext option>)
                (ctx : HttpContext)
                : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        let dep4: 'Dep4 = services.GetRequiredService<'Dep4>()

        let dep5: 'Dep5 = services.GetRequiredService<'Dep5>()

        handler dep0 dep1 dep2 dep3 dep4 dep5 next ctx

    /// <summary>
    /// Gets 7 dependencies from the DI container and provides them to the supplied handler.
    ///
    /// Type inference makes the following possible:
    ///
    /// funcWith7Dependencies |> <see cref="inject7" />
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject7 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> 'Dep5 -> 'Dep6 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                (next : HttpContext -> Task<HttpContext option>)
                (ctx : HttpContext)
                : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        let dep4: 'Dep4 = services.GetRequiredService<'Dep4>()

        let dep5: 'Dep5 = services.GetRequiredService<'Dep5>()

        let dep6: 'Dep6 = services.GetRequiredService<'Dep6>()

        handler dep0 dep1 dep2 dep3 dep4 dep5 dep6 next ctx

    /// <summary>
    /// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with a dependency to the supplied handler.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let injectPlus<'T, 'Dep> (handler : 'T -> 'Dep -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                             (model : 'T)
                             (next : HttpContext -> Task<HttpContext option>)
                             (ctx : HttpContext)
                             : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep: 'Dep = services.GetRequiredService<'Dep>()

        handler model dep next ctx

    /// <summary>
    /// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 2 dependencies to the supplied handler.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject2Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                    (model : 'T)
                    (next : HttpContext -> Task<HttpContext option>)
                    (ctx : HttpContext)
                    : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        handler model dep0 dep1 next ctx

    /// <summary>
    /// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 3 dependencies to the supplied handler.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject3Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                    (model : 'T)
                    (next : HttpContext -> Task<HttpContext option>)
                    (ctx : HttpContext)
                    : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        handler model dep0 dep1 dep2 next ctx

    /// <summary>
    /// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 4 dependencies and provides them to the supplied handler.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject4Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                    (model : 'T)
                    (next : HttpContext -> Task<HttpContext option>)
                    (ctx : HttpContext)
                    : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        handler model dep0 dep1 dep2 dep3 next ctx

    /// <summary>
    /// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 5 dependencies and provides them to the supplied handler.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject5Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                    (model : 'T)
                    (next : HttpContext -> Task<HttpContext option>)
                    (ctx : HttpContext)
                    : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        let dep4: 'Dep4 = services.GetRequiredService<'Dep4>()

        handler model dep0 dep1 dep2 dep3 dep4 next ctx

    /// <summary>
    /// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 6 dependencies and provides them to the supplied handler.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject6Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> 'Dep5 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                    (model : 'T)
                    (next : HttpContext -> Task<HttpContext option>)
                    (ctx : HttpContext)
                    : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        let dep4: 'Dep4 = services.GetRequiredService<'Dep4>()

        let dep5: 'Dep5 = services.GetRequiredService<'Dep5>()

        handler model dep0 dep1 dep2 dep3 dep4 dep5 next ctx

    /// <summary>
    /// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 7 dependencies and provides them to the supplied handler.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    /// There is no service of requested type
    /// </exception>
    let inject7Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> 'Dep5 -> 'Dep6 -> (HttpContext -> Task<HttpContext option>) -> (HttpContext -> Task<HttpContext option>))
                    (model : 'T)
                    (next : HttpContext -> Task<HttpContext option>)
                    (ctx : HttpContext)
                    : Task<HttpContext option> =

        let services: System.IServiceProvider = ctx.RequestServices

        let dep0: 'Dep0 = services.GetRequiredService<'Dep0>()

        let dep1: 'Dep1 = services.GetRequiredService<'Dep1>()

        let dep2: 'Dep2 = services.GetRequiredService<'Dep2>()

        let dep3: 'Dep3 = services.GetRequiredService<'Dep3>()

        let dep4: 'Dep4 = services.GetRequiredService<'Dep4>()

        let dep5: 'Dep5 = services.GetRequiredService<'Dep5>()

        let dep6: 'Dep6 = services.GetRequiredService<'Dep6>()

        handler model dep0 dep1 dep2 dep3 dep4 dep5 dep6 next ctx
