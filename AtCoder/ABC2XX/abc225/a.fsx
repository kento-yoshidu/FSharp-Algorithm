// https://atcoder.jp/contests/abc225/tasks/abc225_a

let fn (s: string) =
    if s.[0] = s.[1] && s.[1] = s.[2] then
        1
    elif s.[0] <> s.[1] && s.[1] <> s.[2] && s.[0] <> s.[2] then
        6
    else
        3

printfn "%i" (fn "aba")
//=> 3

printfn "%i" (fn "ccc")
//=> 1

printfn "%i" (fn "xyz")
//=> 6
