// https://atcoder.jp/contests/abc178/tasks/abc178_a

let fn x =
    match x with
    | 0 -> 1
    | _ -> 0

printfn "%i" (fn 1)
//=> 0

printfn "%i" (fn 0)
//=> 1
