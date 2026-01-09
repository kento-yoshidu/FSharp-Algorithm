// https://atcoder.jp/contests/abc191/tasks/abc191_a

let fn v t s d =
    if d < v*t || v*t < d then
        "Yes"
    else
        "No"

printfn "%s" (fn 10 3 5 20)
//=> Yes

printfn "%s" (fn 10 3 5 30)
//=> No
