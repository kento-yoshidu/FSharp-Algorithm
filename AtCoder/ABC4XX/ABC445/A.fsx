// https://atcoder.jp/contests/abc445/tasks/abc445_a

let fn (s: string) =
    if s.[0] = s.[String.length s - 1] then
        "Yes"
    else
        "No"

printfn "%s" (fn "luminol")
//=> Yes

printfn "%s" (fn "rule")
//=> No
