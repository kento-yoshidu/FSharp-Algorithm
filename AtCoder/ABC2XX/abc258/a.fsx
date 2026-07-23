// https://atcoder.jp/contests/abc258/tasks/abc258_a

let fn n =
    sprintf "%d:%02d" (21 + n / 60) (n % 60)

printfn "%s" (fn 63)
//=> 22:03

printfn "%s" (fn 45)
//=> 21:45

printfn "%s" (fn 100)
//=> 22:40
