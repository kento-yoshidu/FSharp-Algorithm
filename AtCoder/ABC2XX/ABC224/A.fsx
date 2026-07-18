// https://atcoder.jp/contests/abc224/tasks/abc224_a

let fn (s: string) =
    if s.[s.Length-1] = 'r' then
        "er"
    else
        "ist"

printfn "%s" (fn "atcoder")
//=> er

printfn "%s" (fn "tourist")
//=> ist

printfn "%s" (fn "er")
//=> er

