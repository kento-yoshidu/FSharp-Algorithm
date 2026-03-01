// https://atcoder.jp/contests/abc177/tasks/abc177_a

let fn d t s =
    if s * t >= d then
        "Yes"
    else
        "No"

printfn "%s" (fn 1000 15 80)
//=> Yes

printfn "%s" (fn 2000 20 100)
//=> Yes

printfn "%s" (fn 10000 1 1)
//=> No
