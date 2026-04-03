// https://atcoder.jp/contests/abc407/tasks/abc407_a

let fn a b =
    let a = float a
    let b = float b

    int (floor (a / b + 0.5))

printfn "%i" (fn 4 7)
//=> 1

printfn "%i" (fn 407 29)
//=> 14

printfn "%i" (fn 22 11)
//=> 2
