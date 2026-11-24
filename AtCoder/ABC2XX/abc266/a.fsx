// https://atcoder.jp/contests/abc266/tasks/abc266_a

let fn (s: string) =
    s.[s.Length / 2]

printfn "%c" (fn "atcoder")
//=> o

printfn "%c" (fn "a")
//=> a
