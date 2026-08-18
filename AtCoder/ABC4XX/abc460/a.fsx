// https://atcoder.jp/contests/abc460/tasks/abc460_a

let rec calc n m count =
    if m = 0 then
        count
    else
        calc n (n % m) count + 1

let fn n m =
    calc n m 0

printfn "%i" (fn 8 5)
//=> 3

printfn "%i" (fn 14 6)
//=> 2

printfn "%i" (fn 460 33)
//=> 5
