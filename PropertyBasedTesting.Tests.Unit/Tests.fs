namespace PropertyBasedTesting.Tests.Unit

open FsCheck.Xunit
open Swensen.Unquote
open PropertyTesting.MyOperators

module AdditionTests =
    [<Property>]
    let ``Test associativity`` x y z =

        test <@ ((x |+ y) |+ z) = (x |+ (y |+ z)) @>

    [<Property>]
    let ``Test commutativity`` x y =

        test <@ (x |+ y) = (y |+ x) @>

    [<Property>]
    let ``Test identity`` x =

        test <@ x |+ 0 = x @>

    [<Property>]
    let ``Test repetition`` x =

        let x = abs x
        let ones = List.replicate x 1

        test <@ ones |> List.fold (|+) 0 = x @>