// https://atcoder.jp/contests/abc136/tasks/abc136_a

let fn a b c =
    max 0 (c - (a - b))

printfn "%i" (fn 6 4 3)
//=> 1

printfn "%i" (fn 8 3 9)
//=> 4

printfn "%i" (fn 12 3 7)
//=> 0
