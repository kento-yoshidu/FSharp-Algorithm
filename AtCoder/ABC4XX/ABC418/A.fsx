// https://atcoder.jp/contests/abc418/tasks/abc418_a

let fn _n (s: string) =
    if s.EndsWith("tea") then
        "Yes"
    else
        "No"

printfn "%s" (fn 8 "greentea")
//=> Yes

printfn "%s" (fn 6 "coffee")
//=> No

printfn "%s" (fn 3 "tea")
//=> Yes

printfn "%s" (fn 1 "t")
//=> No
