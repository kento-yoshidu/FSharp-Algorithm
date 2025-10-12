// https://atcoder.jp/contests/abc121/tasks/abc121_a

let fn h w h2 w2 =
    (h - h2) * (w - w2)

printfn "%i" (fn 3 2 2 1)
//=> 1

printfn "%i" (fn 5 5 2 3)
//=> 6

printfn "%i" (fn 2 4 2 4)
//=> 0
