// https://atcoder.jp/contests/abc244/tasks/abc244_a

let fn n (s: string) =
    s.[n-1]

printfn "%c" (fn 5 "abcde")
//=> e

printfn "%c" (fn 1 "a")
//=> a
