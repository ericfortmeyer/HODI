/// <summary>
/// A set of functions used to inject dependencies into higher order functions.
///
/// This module is obsolute.
/// Use the HODI.DependencyInjection module instead
/// </summary>
module HODI.Giraffe.DependencyInjection

open System
open System.Diagnostics.CodeAnalysis

/// <summary>
/// Gets a dependency from the DI container and provides it to the supplied handler.
///
/// Types can be inferred making the code below possible:
///
/// funcWithADependency |> <see cref="inject" />
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject = HODI.DependencyInjection.inject


/// <summary>
/// Gets 2 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith2Dependencies |> <see cref="inject2" />
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject2 = HODI.DependencyInjection.inject2


/// <summary>
/// Gets 3 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith3Dependencies |> <see cref="inject3" />
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject3 = HODI.DependencyInjection.inject3


/// <summary>
/// Gets 4 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith4Dependencies |> <see cref="inject4" />
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject4 = HODI.DependencyInjection.inject4


/// <summary>
/// Gets 5 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith5Dependencies |> <see cref="inject5" />
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject5 = HODI.DependencyInjection.inject5


/// <summary>
/// Gets 6 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith6Dependencies |> <see cref="inject6" />
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject6 = HODI.DependencyInjection.inject6


/// <summary>
/// Gets 7 dependencies from the DI container and provides them to the supplied handler.
///
/// Type inference makes the following possible:
///
/// funcWith7Dependencies |> <see cref="inject7" />
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject7 = HODI.DependencyInjection.inject7


/// <summary>
/// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with a dependency to the supplied handler.
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let injectPlus = HODI.DependencyInjection.injectPlus


/// <summary>
/// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 2 dependencies to the supplied handler.
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject2Plus = HODI.DependencyInjection.inject2Plus


/// <summary>
/// Provides a given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 3 dependencies to the supplied handler.
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject3Plus = HODI.DependencyInjection.inject3Plus


/// <summary>
/// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 4 dependencies and provides them to the supplied handler.
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject4Plus = HODI.DependencyInjection.inject4Plus


/// <summary>
/// Passes given value (e.g. the result of a <see cref="routef" /> or <see cref="bindForm" />) along with 5 dependencies and provides them to the supplied handler.
/// </summary>
[<Obsolete("Use the functions in the HODI.DependencyInjection module instead")>]
[<ExcludeFromCodeCoverage>]
let inject5Plus = HODI.DependencyInjection.inject5Plus
