// https://atcoder.jp/contests/joi2026yo1a/tasks/joi2026_yo1a_b

let fn a b =
    if a > b * 3 then
        1
    else
        0

printfn "%i" (fn 100 20)
//=> 1

printfn "%i" (fn 70 30)
//=> 0

printfn "%i" (fn 30 10)
//=> 0

printfn "%i" (fn 76 25)
//=> 1
