namespace JsonParse.Test

open NUnit.Framework
open FsUnit
open FsUnitTyped
open JsonParse.JsonParser

[<TestFixture>]
module MyTests =

    [<SetUp>]
    let setup () =
        FSharpCustomMessageFormatter() |> ignore

    [<Test>]
    let ``Single string field`` () =
        let actual = Ok (Object (Map [("field", String "Hello")]))
        let parsed = tryParseStr "{\"field\":\"Hello\"}"
        parsed |> shouldEqual actual
