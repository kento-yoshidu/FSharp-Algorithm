// https://atcoder.jp/contests/abc254/tasks/abc254_a

let fn n =
    sprintf "%02d" (n % 100)

printfn "%s" (fn 254)
//=> 54

printfn "%s" (fn 101)
//=> 01
