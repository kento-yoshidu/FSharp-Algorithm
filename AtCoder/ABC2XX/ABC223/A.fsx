// https://atcoder.jp/contests/abc223/tasks/abc223_a

let fn x =
    if x <> 0 && x % 100 = 0 then
        "Yes"
    else
        "No"

printfn "%s" (fn 500)
//=> Yes

printfn "%s" (fn 40)
//=> No

printfn "%s" (fn 0)
//=> No
