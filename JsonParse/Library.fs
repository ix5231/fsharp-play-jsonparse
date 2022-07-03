namespace JsonParse

open System.Text.RegularExpressions

module JsonParser =

    type JsonType =
        | Object of Map<string, JsonType>
        | String of string
    
    let ws = [|' '; '\t'; '\n'; '\r'|]
    
    let eliminateWs =
        String.filter (fun c -> Array.contains c ws |> not)

    let tryParseStr s =
        let toParse = eliminateWs s
        let parsed = Regex.Match(toParse, "{\"(.*)\":\"(.*)\"}")
        if parsed.Groups.Count <> 3
        then Error "Error"
        else Map [(parsed.Groups[1].Value, String parsed.Groups[2].Value)] |> Object |> Ok
