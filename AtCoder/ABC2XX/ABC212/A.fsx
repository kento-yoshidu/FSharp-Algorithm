// https://atcoder.jp/contests/abc212/tasks/abc212_a

let fn a b =
    if 0 < a && b = 0 then
        "Gold"
    elif a = 0 && 0 < b then
        "Silver"
    else
        "Alloy"

printfn "%s" (fn 50 50)
//=> Alloy

printfn "%s" (fn 100 0)
//=> Gold

printfn "%s" (fn 0 100)
//=> Silver

printfn "%s" (fn 100 2)
//=> Alloy
