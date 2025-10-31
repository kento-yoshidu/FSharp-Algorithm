// https://atcoder.jp/contests/abc135/tasks/abc135_a

let fn a b =
    if (a + b) % 2 = 0 then
        string ((a + b) / 2)
    else
        "IMPOSSIBLE"

printfn "%s" (fn 2 16)
//=> 9

printfn "%s" (fn 0 3)
//=> IMPOSSIBLE

printfn "%s" (fn 998244353 99824435)
//=> 549034394
