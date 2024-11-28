// https://atcoder.jp/contests/joi2025yo1c/tasks/joi2025_yo1c_c

let run n a b =
    [1 .. n]
    |> List.filter(fun num -> (num % a = 0 && num % b <> 0) || (num % a <> 0 && num % b = 0))
    |> List.length

printfn "%i" (run 6 2 3)
//=> 3

printfn "%i" (run 1 5 3)
//=> 0

printfn "%i" (run 100 1 2)
//=> 50
