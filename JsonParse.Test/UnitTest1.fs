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
    [<TestCase("{\"field\":\"Hello\"}")>]
    [<TestCase("{ \"field\":\"Hello\" }")>]
    [<TestCase("{ \"field\":    \"Hello\" }")>]
    [<TestCase("{ \"field\":\t\"Hello\" }")>]
    [<TestCase("{ \"field\":\r\n\"Hello\" }")>]
    let ``Single string field regardless spaces`` (case) =
        let actual = Ok (Object (Map [("field", String "Hello")]))
        let parsed = tryParseStr case
        parsed |> shouldEqual actual
