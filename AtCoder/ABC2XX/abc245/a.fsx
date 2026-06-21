// https://atcoder.jp/contests/abc245/tasks/abc245_a

let fn a b c d =
    if a*60 + b > c*60 + d then
        "Aoki"
    else
        "Takahashi"

printfn "%s" (fn 7 0 6 30)
//=> Aoki

printfn "%s" (fn 7 30 7 30)
//=> Takahashi

printfn "%s" (fn 0 0 23 59)
//=> Takahashi
