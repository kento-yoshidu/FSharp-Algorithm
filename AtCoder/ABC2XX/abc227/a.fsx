// https://atcoder.jp/contests/abc227/tasks/abc227_a

let fn n k a =
    let rem = (k + a - 1) % n

    if rem <> 0 then
        rem
    else
        n

printfn "%i" (fn 3 3 2)
//=> 2

printfn "%i" (fn 1 100 1)
//=> 1

printfn "%i" (fn 3 14 2)
//=> 3
