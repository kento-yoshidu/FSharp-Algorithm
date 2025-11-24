// https://atcoder.jp/contests/abc156/tasks/abc156_a

let fn n r =
    if n >= 10 then
        r
    else
        r + 100 * (10 - n)

printfn "%i" (fn 2 2919)
//=> 3719

printfn "%i" (fn 22 3051)
//=> 3051
