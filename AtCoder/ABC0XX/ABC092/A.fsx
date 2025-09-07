// https://atcoder.jp/contests/abc092/tasks/abc092_a

let fn a b c d =
    min a b + min c d

printfn "%i" (fn 600 300 220 420)
//=> 520

printfn "%i" (fn 555 555 400 200)
//=> 755

printfn "%i" (fn 549 817 715 603)
//=> 1152
