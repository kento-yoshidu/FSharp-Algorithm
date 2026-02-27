// https://atcoder.jp/contests/abc208/tasks/abc208_a

let fn a b =
    if a <= b && b <= a*6 then
        "Yes"
    else
        "No"

printfn "%s" (fn 2 11)
//=> Yes

printfn "%s" (fn 2 13)
//=> No

printfn "%s" (fn 100 600)
//=> Yes
