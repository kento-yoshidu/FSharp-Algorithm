// https://atcoder.jp/contests/abc147/tasks/abc147_a

let fn a1 a2 a3 =
    if a1 + a2 + a3 >= 22 then
        "bust"
    else
        "win"

printfn "%s" (fn 5 7 9)
//=> win

printfn "%s" (fn 13 7 2)
//=> bust
