// https://atcoder.jp/contests/abc265/tasks/abc265_a

let fn x y n =
    if x * 3 > y then
        n / 3 * y + n % 3 * x
    else
        x * n

printfn "%i" (fn 10 25 10)
//=> 85

printfn "%i" (fn 10 40 10)
//=> 100

printfn "%i" (fn 100 100 2)
//=> 200

printfn "%i" (fn 100 100 100)
//=> 3400
