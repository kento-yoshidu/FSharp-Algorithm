// https://atcoder.jp/contests/abc431/tasks/abc431_a

let fn h b =
    max 0 (h - b)

printfn "%i" (fn 43 1)
//=> 42

printfn "%i" (fn 4 31)
//=> 0

printfn "%i" (fn 1 1)
//=> 0
