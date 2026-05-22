// https://atcoder.jp/contests/abc195/tasks/abc195_a

let fn m h =
    if h % m = 0 then
        "Yes"
    else
        "No"

printfn "%s" (fn 10 120)
//=> Yes

printfn "%s" (fn 10 125)
//=> No
