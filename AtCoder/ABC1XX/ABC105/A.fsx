// https://atcoder.jp/contests/abc105/tasks/abc105_a

let fn n k =
    if n % k = 0 then
        0
    else
        1

printfn "%i" (fn 7 3)
//=> 1

printfn "%i" (fn 100 10)
//=> 0

printfn "%i" (fn 1 1)
//=> 0
