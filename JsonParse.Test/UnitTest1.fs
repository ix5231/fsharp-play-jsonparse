namespace JsonParse.Test

open NUnit.Framework
open FsUnit

[<TestFixture>]
module MyTests =

    [<SetUp>]
    let setup () =
        FSharpCustomMessageFormatter() |> ignore

    [<Test>]
    let ``Simple test`` () = JsonParse.Say.hello "World" |> should equal "Hello World" 
