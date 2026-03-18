// https://atcoder.jp/contests/abc378/tasks/abc378_a

let fn a b c d =
    [| a; b; c; d |]
    |> Array.countBy id
    |> Map.ofArray
    |> fun counts ->
        [0..4]
        |> List.map (fun i ->
            let c = Map.tryFind i counts |> Option.defaultValue 0
            if c = 4 then 2
            elif c > 1 then 1
            else 0
        )
        |> List.sum

printfn "%i" (fn 2 1 2 1)
//=> 2

printfn "%i" (fn 4 4 4 1)
//=> 1

printfn "%i" (fn 1 2 3 4)
//=> 0
