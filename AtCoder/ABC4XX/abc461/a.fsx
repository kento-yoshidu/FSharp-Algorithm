// https://atcoder.jp/contests/abc461/tasks/abc461_a

let fn a d =
    if a <= d then
        "Yes"
    else
        "No"

printfn "%s" (fn 4 5)
//=> Yes

printfn "%s" (fn 5 5)
//=> Yes

printfn "%s" (fn 6 5)
//=> No
