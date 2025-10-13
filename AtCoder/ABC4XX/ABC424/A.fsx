// https://atcoder.jp/contests/abc424/tasks/abc424_a

let fn a b c =
    if a = b || a = c || b = c then
        "Yes"
    else
        "No"

printfn "%s" (fn 4 2 4)
//=> Yes

printfn "%s" (fn 3 4 5)
//=> No

printfn "%s" (fn 10 10 10)
//=> Yes
