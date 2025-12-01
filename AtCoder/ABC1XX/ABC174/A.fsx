// https://atcoder.jp/contests/abc174/tasks/abc174_a

let fn x =
    if x >= 30 then
        "Yes"
    else
        "No"

printfn "%s" (fn 25)
//=> No

printfn "%s" (fn 30)
//=> Yes
