// https://atcoder.jp/contests/abc243/tasks/abc243_a

let fn v a b c =
    let rem = v % (a + b + c)

    if rem < a then
        "F"
    elif rem < (a + b) then
        "M"
    else
        "T"

printfn "%s" (fn 25 10 11 12)
//=> T

printfn "%s" (fn 30 10 10 10)
//=> F

printfn "%s" (fn 100000 1 1 1)
//=> M
