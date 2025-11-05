// https://atcoder.jp/contests/abc162/tasks/abc162_a

let fn n =
    if n.ToString().Contains("7") then
        "Yes"
    else
        "No"

printfn "%s" (fn 117)
//=> Yes

printfn "%s" (fn 123)
//=> No

printfn "%s" (fn 777)
//=> Yes
