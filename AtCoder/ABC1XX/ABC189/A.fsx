// https://atcoder.jp/contests/abc189/tasks/abc189_a

let fn (c: string) =
    if c.[0] = c.[1] && c.[1] = c.[2] then
        "Won"
    else
        "Lost"

printfn "%s" (fn "SSS")
//=> Won

printfn "%s" (fn "WVW")
//=> Lost
