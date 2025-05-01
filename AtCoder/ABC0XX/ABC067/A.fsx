// https://atcoder.jp/contests/abc067/tasks/abc067_a

let run a b =
    if a % 3 = 0 || b % 3 = 0 || (a+b) % 3 = 0 then
        "Possible"
    else
        "Impossible"

printfn "%s" (run 4 5)
//=> Possible

printfn "%s" (run 1 1)
//=> Impossible
