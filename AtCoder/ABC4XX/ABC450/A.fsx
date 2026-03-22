// https://atcoder.jp/contests/abc450/tasks/abc450_a

let fn n =
    [| 1 .. n|]
    |> Array.rev
    |> Array.map string
    |> String.concat ","

printfn "%s" (fn 9)
//=> 9,8,7,6,5,4,3,2,1

printfn "%s" (fn 5)
//=> 5,4,3,2,1

printfn "%s" (fn 1)
//=> 1
