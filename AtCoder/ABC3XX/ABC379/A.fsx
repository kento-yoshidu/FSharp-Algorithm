// https://atcoder.jp/contests/abc379/tasks/abc379_a

let fn n =
    let a = n / 100
    let b = n % 100 / 10
    let c = n % 10

    b * 100 + c * 10 + a, c * 100 + a * 10 + b

printfn "%A" (fn 379)
//=> (793, 937)

printfn "%A" (fn 919)
//=> (199, 991)
