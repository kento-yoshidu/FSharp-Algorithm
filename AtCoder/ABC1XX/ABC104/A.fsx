// https://atcoder.jp/contests/abc104/tasks/abc104_a

let fn r =
    if r < 1200 then
        "ABC"
    elif r < 2800 then
        "ARC"
    else
        "AGC"

printfn "%s" (fn 1199)
//=> ABC

printfn "%s" (fn 1200)
//=> ARC

printfn "%s" (fn 4208)
//=> AGC
