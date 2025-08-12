// https://atcoder.jp/contests/abc082/tasks/abc082_a

let fn a b =
    if (a + b) % 2 = 0 then
        (a + b) / 2
    else
        (a + b + 1) / 2

printfn "%i" (fn 1 3)
//=> 2

printfn "%i" (fn 7 4)
//=> 6

printfn "%i" (fn 5 5)
//=> 5
