// https://atcoder.jp/contests/abc164/tasks/abc164_a

let fn s w =
    if w >= s then
        "unsafe"
    else
        "safe"

printfn "%s" (fn 4 5)
//=> unsafe

printfn "%s" (fn 100 2)
//=> safe

printfn "%s" (fn 10 10)
//=> unsafe
