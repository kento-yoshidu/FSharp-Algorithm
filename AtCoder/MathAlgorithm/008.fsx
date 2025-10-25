// https://atcoder.jp/contests/math-and-algorithm/tasks/math_and_algorithm_h

let fn n s =
    [1 .. n]
    |> List.collect (fun i -> [1 .. n] |> List.map (fun j -> (i, j)))
    |> List.filter (fun (i, j) -> i + j <= s)
    |> List.length

printfn "%i" (fn 3 4)
//=> 6

printfn "%i" (fn 869 120)
//=> 7140
