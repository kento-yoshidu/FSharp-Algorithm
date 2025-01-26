// https://atcoder.jp/contests/joi2025yo1c/tasks/joi2025_yo1c_b

let run a b c =
    if a + b + c <= 21 then
        1
    else
        0

printfn "%i" (run 5 10 6)
//=> 1

printfn "%i" (run 7 8 13)
//=> 0
