// https://atcoder.jp/contests/abc065/tasks/abc065_a

let run x a b =
    if a >= b then
        "delicious"
    elif b - a <= x then
        "safe"
    else
        "dangerous"

printfn "%s" (run 4 3 6)
//=> sage

printfn "%s" (run 6 5 1)
//=> delicious

printfn "%s" (run 3 7 12)
//=> dangerous
