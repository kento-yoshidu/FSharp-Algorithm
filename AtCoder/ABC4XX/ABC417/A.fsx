// https://atcoder.jp/contests/abc417/tasks/abc417_a

let fn n a b (s: string) =
    s.Substring(a, n - b - a)

printfn "%s" (fn 7 1 3 "atcoder")
//=> tco

printfn "%s" (fn 1 0 0 "a")
//=> a

printfn "%s" (fn 20 4 8 "abcdefghijklmnopqrst")
//=> efghijkl
