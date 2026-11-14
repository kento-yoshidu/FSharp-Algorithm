// https://atcoder.jp/contests/abc261/tasks

let fn l1 r1 l2 r2 =
    max 0 (abs (min r1 r2) - (max l1 l2))

printfn "%i" (fn 0 3 1 5)
//=> 2

printfn "%i" (fn 0 1 4 5)
//=> 0

printfn "%i" (fn 0 3 3 7)
//=> 0
