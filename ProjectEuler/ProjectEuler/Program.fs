﻿module Program

open System

[<EntryPoint>]
let main argv =
    //Problem19.numSundays
    //Problem25.thousandDigitFibonacci
    Problem30.digitFifthPowers

    printfn "done!"
    Console.ReadLine() |> ignore
    0