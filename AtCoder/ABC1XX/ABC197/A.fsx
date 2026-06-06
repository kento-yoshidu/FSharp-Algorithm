// https://atcoder.jp/contests/abc197/tasks/abc197_a

let fn (s: string) =
    s.[1..] + s.[0..0]

printfn "%s" (fn "abc")
//=> bca

printfn "%s" (fn "aab")
//=> aba
