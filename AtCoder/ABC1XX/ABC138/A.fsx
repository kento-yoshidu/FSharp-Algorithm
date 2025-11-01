// https://atcoder.jp/contests/abc138/tasks/abc138_a

let fn a s =
    if a >= 3200 then
        s
    else
        "red"

printfn "%s" (fn 3200 "pink")
//=> pink

printfn "%s" (fn 3199 "pink")
//=> red

printfn "%s" (fn 4049 "red")
//=> red
