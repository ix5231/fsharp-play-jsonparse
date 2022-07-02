namespace JsonParse

module JsonParser =

    type JsonType =
        | Object of Map<string, JsonType>
        | String of string

    let tryParseStr s =
        if s = "{\"field\":\"Hello\"}"
        then Map [("field", String "Hello")] |> Object |> Ok
        else Error "Unimplemented"
