// https://atcoder.jp/contests/abc433/tasks/abc433_b

let fn n a =
    a
    |> Array.mapi (fun i x ->
        a
        |> Array.take i
        |> Array.tryFindIndexBack (fun y -> y > x)
        |> Option.map ((+) 1)
        |> Option.defaultValue -1)


printfn "%A" (fn 4 [| 4; 3; 2; 5 |])
//=> [|-1; 1; 2; -1|]

printfn "%A" (fn 3 [| 7; 7; 7 |])
//=> [|-1; -1; -1 |]

printfn "%A" (fn 6 [| 31; 9; 17; 10; 2; 9 |])
//=> [|-1; 1; 1; 3; 4; 4|]
