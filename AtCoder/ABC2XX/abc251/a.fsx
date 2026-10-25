// https://atcoder.jp/contests/abc251/tasks/abc251_a

let fn (s: string) =
    String.replicate (6 / s.Length) s

printfn "%s" (fn "abc")
//=> abcabc

printfn "%s" (fn "zz")
//=> zzzzzz
