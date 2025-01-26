// https://atcoder.jp/contests/abc054/tasks/abc054_a

let run a b =
    if a = b then
        "Draw"
    elif a = 1 then
        "Alice"
    elif b = 1 then
        "Bob"
    elif a > b then
        "Alice"
    else
        "Bob"

printfn "%s" (run 8 6)
//=> Alice

printfn "%s" (run 1 1)
//=> Draw

printfn "%s" (run 13 1)
//=> Bob
