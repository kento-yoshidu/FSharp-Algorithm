// https://atcoder.jp/contests/abc109/tasks/abc109_a

let fn a b =
    if a * b % 2 = 0 then
        "No"
    else
        "Yes"

printfn "%s" (fn 3 1)
//=> Yes

printfn "%s" (fn 1 2)
//=> No

printfn "%s" (fn 2 2)
//=> No
