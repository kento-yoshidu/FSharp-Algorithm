// https://atcoder.jp/contests/abc102/tasks/abc102_a

let fn n =
    if n % 2 = 0 then
        n
    else
        n * 2

printfn "%i" (fn 3)
//=> 6

printfn "%i" (fn 10)
//=> 10

printfn "%i" (fn 999999999)
//=> 1999999998
