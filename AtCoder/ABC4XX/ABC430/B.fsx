// https://atcoder.jp/contests/abc430/tasks/abc430_b

open System

let fn n m (s: string array) =
    let chars =
        s
        |> Array.map (fun str -> str.ToCharArray())

    [ for i in 0 .. n - m do
        for j in 0 .. n - m do
            yield
                [ for k in 0 .. m - 1 do
                    for l in 0 .. m - 1 do
                        yield chars.[i + k].[j + l] ]
                |> Array.ofList
                |> String ]
    |> Set.ofList
    |> Set.count


printfn "%d" (fn 3 2 [| "..."; "###"; "#.#" |])
//=> 3

printfn "%d" (fn 10 3 [| "..#......."; ".###......"; ".#.#......"; "#####....."; "#...#....."; "......####"; "......#..#"; "......#..."; "......#..#"; "......####"; |])
//=> 36
