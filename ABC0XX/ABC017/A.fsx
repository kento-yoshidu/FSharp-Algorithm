// https://atcoder.jp/contests/abc017/tasks/abc017_1

let run (tuples: (int * int) list) =
    tuples
    |> List.map (fun (a, b) -> float a * (float b * 0.1))
    |> List.sum

printfn "%i" (int (run [(50, 7); (40, 8); (30, 9)]))
//=> 94

printfn "%i" (int (run [(990, 10); (990, 10); (990, 10)]))
//=> 2970
