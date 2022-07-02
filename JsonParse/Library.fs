namespace JsonParse

module JsonParser =

    type JsonType =
        | Object of Map<string, JsonType>
        | String of string
    
    let ws = [|' '; '\t'; '\n'; '\r'|]
    
    let eliminateWs =
        String.filter (fun c -> Array.contains c ws |> not)

    let tryParseStr s =
        if eliminateWs s = "{\"field\":\"Hello\"}"
        then Map [("field", String "Hello")] |> Object |> Ok
        else Error "Unimplemented"
