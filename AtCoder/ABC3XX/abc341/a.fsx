// https://atcoder.jp/contests/abc341/tasks/abc341_a

let fn n =
    String.replicate n "10" + "1"


printfn "%s" (fn 4)
//=> 101010101

printfn "%s" (fn 1)
//=> 101

printfn "%s" (fn 10)
//=> 101010101010101010101
