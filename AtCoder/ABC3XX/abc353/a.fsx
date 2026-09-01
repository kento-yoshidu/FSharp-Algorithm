// https://atcoder.jp/contests/abc353/tasks/abc353_a

let fn _n (h: int[]) =
    h
    |> Array.tryFindIndex(fun num -> num > Array.head h)
    |> Option.map ((+) 1)
    |> Option.defaultValue -1

printfn "%i" (fn 4 [| 3; 2; 5; 2 |])
//=> 3

printfn "%i" (fn 3 [| 4; 3; 2 |])
//=> -1

printfn "%i" (fn 7 [| 10; 5; 10; 2; 10; 13; 15 |])
//=> 6
