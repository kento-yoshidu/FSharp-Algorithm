// https://atcoder.jp/contests/abc334/tasks/abc334_a

let fn b g =
    if b > g then
        "Bat"
    else
        "Glove"

printfn "%s" (fn 300 100)
//=> Bat

printfn "%s" (fn 334 343)
//=> Glove
