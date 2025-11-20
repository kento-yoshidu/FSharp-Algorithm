// https://atcoder.jp/contests/joi2026yo1c/tasks/joi2026_yo1c_b

let fn x y n =
    if n % 2 = 0 then
        y * n
    else
        y * (n - 1) + x

printfn "%i" (fn 4 3 5)
//=> 16

printfn "%i" (fn 3 1 6)
//=> 6

printfn "%i" (fn 10 2 1)
//=> 10
