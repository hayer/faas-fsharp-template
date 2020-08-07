module Function

open System
open FSharp.Data

type RequestParameters = JsonProvider<"""{"name": "John Doe", "age": 31}""">

let Handle(input:string) =
    let requestParameters = RequestParameters.Parse(input)
    sprintf "Hello %s, age %i" requestParameters.Name requestParameters.Age |> Console.WriteLine
