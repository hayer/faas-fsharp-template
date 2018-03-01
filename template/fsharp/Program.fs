module root

open System
open System.Text
open Function

[<EntryPoint>]
let main argv = 
    let buffer = StringBuilder()
    
    let rec readInput (sb:StringBuilder) = 
        match Console.ReadLine() with
        | null -> sb.ToString()
        | str -> 
            sb.AppendLine(str) |> ignore
            readInput sb
    
    let input = readInput buffer
    Function.Handle input

    0