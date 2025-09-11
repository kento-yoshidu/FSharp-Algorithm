// https://atcoder.jp/contests/abc108/tasks/abc108_a

let fn k =
    if k % 2 = 0 then
        k / 2 * (k / 2)
    else
        k / 2 * (k / 2 + 1)

printfn "%i" (fn 3)
//=> 2

printfn "%i" (fn 6)
//=> 3

printfn "%i" (fn 11)
//=> 30

printfn "%i" (fn 50)
//=> 625
