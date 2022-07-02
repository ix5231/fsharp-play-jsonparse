namespace JsonParser

open NUnit.Framework
open FsUnit

module t =
  let add a b = a + b

[<TestFixture>]
type MyTests () =

    [<SetUp>]
    member _.setup () =
        FSharpCustomMessageFormatter() |> ignore

    [<Test>]
    member _.``Simple test`` () = t.add 1 2 |> should equal 3
