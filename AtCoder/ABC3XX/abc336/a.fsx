// https://atcoder.jp/contests/abc336/tasks/abc336_a

let fn n =
    "l" + String.replicate n "o" + "ng"

printfn "%s" (fn 3)
//=> looong

printfn "%s" (fn 1)
//=> long
