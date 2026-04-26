// https://atcoder.jp/contests/abc455/tasks/abc455_a

let fn a b c =
    if a <> b && b = c then
        "Yes"
    else
        "No"

printfn "%s" (fn 4 5 5)
//=> Yes

printfn "%s" (fn 1 3 7)
//=> No

printfn "%s" (fn 6 6 6)
//=> No
