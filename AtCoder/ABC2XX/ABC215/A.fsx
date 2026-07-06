// https://atcoder.jp/contests/abc215/tasks/abc215_a

let fn s =
    if s = "Hello,World!" then
        "AC"
    else
        "WA"

printfn "%s" (fn "Hello,World!")
//=> AC

printfn "%s" (fn "Hello,world!")
//=> WA

printfn "%s" (fn "Hello!World!")
//=> WA
