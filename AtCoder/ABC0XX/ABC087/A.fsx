// https://atcoder.jp/contests/abc087/tasks/abc087_a

let fn x a b =
    (x - a) % b

printfn "%i" (fn 1234 150 100)
//=> 84

printfn "%i" (fn 1000 108 108)
//=> 28

printfn "%i" (fn 579 123 456)
//=> 0

printfn "%i" (fn 7477 549 593)
//=> 405
