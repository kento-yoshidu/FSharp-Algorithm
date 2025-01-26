// https://atcoder.jp/contests/abc044/tasks/abc044_a

let run n k x y =
    if n >= k then
        k * x + (n - k) * y
    else
        n * x

printfn "%i" (run 5 3 10000 9000)
//=> 48000

printfn "%i" (run 2 3 10000 9000)
//=> 20000
