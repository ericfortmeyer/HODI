/// <summary>
/// A set of functions used to inject dependencies into higher order functions.
/// </summary>
module HODI.Giraffe.DependencyInjection

    
open Microsoft.AspNetCore.Http
open Giraffe

/// <summary>
/// Gets a dependency from the DI container and provides it to the supplied handler.
///
/// Types can be inferred making the code below possible:
///
/// funcWithADependency |> <see cref="inject" />
/// </summary>
let inject (handler : 'Dep -> HttpHandler) (next : HttpFunc) (ctx : HttpContext) : HttpFuncResult =
    let dep = ctx.GetService<'Dep>()
    handler dep next ctx

/// <summary>
/// Gets 2 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith2Dependencies |> <see cref="inject2" />
/// </summary>
let inject2 (handler : 'Dep0 -> 'Dep1 -> HttpHandler) (next : HttpFunc) (ctx : HttpContext) : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    handler dep0 dep1 next ctx

/// <summary>
/// Gets 3 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith3Dependencies |> <see cref="inject3" />
/// </summary>
let inject3 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> HttpHandler) (next : HttpFunc) (ctx : HttpContext) : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    handler dep0 dep1 dep2 next ctx

/// <summary>
/// Gets 4 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith4Dependencies |> <see cref="inject4" />
/// </summary>
let inject4 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> HttpHandler)
            (next : HttpFunc)
            (ctx : HttpContext)
            : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    let dep3 = ctx.GetService<'Dep3>()
    handler dep0 dep1 dep2 dep3 next ctx

/// <summary>
/// Gets 5 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith5Dependencies |> <see cref="inject5" />
/// </summary>
let inject5 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> HttpHandler)
            (next : HttpFunc)
            (ctx : HttpContext)
            : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    let dep3 = ctx.GetService<'Dep3>()
    let dep4 = ctx.GetService<'Dep4>()
    handler dep0 dep1 dep2 dep3 dep4 next ctx

/// <summary>
/// Gets 6 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith6Dependencies |> <see cref="inject6" />
/// </summary>
let inject6 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> 'Dep5 -> HttpHandler)
            (next : HttpFunc)
            (ctx : HttpContext)
            : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    let dep3 = ctx.GetService<'Dep3>()
    let dep4 = ctx.GetService<'Dep4>()
    let dep5 = ctx.GetService<'Dep5>()
    handler dep0 dep1 dep2 dep3 dep4 dep5 next ctx

/// <summary>
/// Gets 7 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith7Dependencies |> <see cref="inject7" />
/// </summary>
let inject7 (handler : 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> 'Dep5 -> 'Dep6 -> HttpHandler)
            (next : HttpFunc)
            (ctx : HttpContext)
            : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    let dep3 = ctx.GetService<'Dep3>()
    let dep4 = ctx.GetService<'Dep4>()
    let dep5 = ctx.GetService<'Dep5>()
    let dep6 = ctx.GetService<'Dep6>()
    handler dep0 dep1 dep2 dep3 dep4 dep5 dep6 next ctx

/// <summary>
/// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with a dependency to the supplied handler.
/// </summary>
let injectPlus<'T, 'Dep> (handler : 'T -> 'Dep -> HttpHandler) (model : 'T) (next : HttpFunc) (ctx : HttpContext) : HttpFuncResult =
    let dep = ctx.GetService<'Dep>()
    handler model dep next ctx

/// <summary>
/// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 2 dependencies to the supplied handler.
/// </summary>
let inject2Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> HttpHandler)
                (model : 'T)
                (next : HttpFunc)
                (ctx : HttpContext)
                    : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    handler model dep0 dep1 next ctx

/// <summary>
/// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 3 dependencies to the supplied handler.
/// </summary>
let inject3Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> HttpHandler)
                        (model : 'T)
                        (next : HttpFunc)
                        (ctx : HttpContext)
                        : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    handler model dep0 dep1 dep2 next ctx

/// <summary>
/// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 4 dependencies and provides them to the supplied handler.
/// </summary>
let inject4Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> HttpHandler)
                (model : 'T)
                (next : HttpFunc)
                (ctx : HttpContext)
                : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    let dep3 = ctx.GetService<'Dep3>()
    handler model dep0 dep1 dep2 dep3 next ctx

/// <summary>
/// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 5 dependencies and provides them to the supplied handler.
/// </summary>
let inject5Plus (handler : 'T -> 'Dep0 -> 'Dep1 -> 'Dep2 -> 'Dep3 -> 'Dep4 -> HttpHandler)
                        (model : 'T)
                        (next : HttpFunc)
                        (ctx : HttpContext)
                        : HttpFuncResult =
    let dep0 = ctx.GetService<'Dep0>()
    let dep1 = ctx.GetService<'Dep1>()
    let dep2 = ctx.GetService<'Dep2>()
    let dep3 = ctx.GetService<'Dep3>()
    let dep4 = ctx.GetService<'Dep4>()
    handler model dep0 dep1 dep2 dep3 dep4 next ctx
