// https://atcoder.jp/contests/abc428/tasks/abc428_a

let fn s a b x =
    let rem = x % (a + b)
    let sum = x / (a + b) * a * s

    sum + (min a rem) * s

printfn "%i" (fn 7 3 2 11)
//=> 49

printfn "%i" (fn 6 3 2 9)
//=> 36

printfn "%i" (fn 1 1 666 428)
//=> 1
