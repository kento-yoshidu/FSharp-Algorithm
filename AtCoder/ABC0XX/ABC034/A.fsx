// https://atcoder.jp/contests/abc034/tasks/abc034_a

let run x y =
    if x < y then
        "Better"
    else
        "Worse"

printfn "%s" (run 12 34)
//=> Better

printfn "%s" (run 98 56)
//=> Worse
