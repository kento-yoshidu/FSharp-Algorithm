// https://atcoder.jp/contests/joi2026yo1c/tasks/joi2026_yo1c_c

let fn n x h =
    h
    |> Array.filter (fun h -> h >= x)
    |> Array.length

printfn "%i" (fn 3 20 [| 18; 25; 20 |])
//=> 2

printfn "%i" (fn 4 10 [| 3; 9; 1; 3 |])
//=> 0

printfn "%i" (fn 1 100 [| 100 |])
//=> 1

printfn "%i" (fn 5 634 [| 829; 679; 632; 601; 600 |])
//=> 2
