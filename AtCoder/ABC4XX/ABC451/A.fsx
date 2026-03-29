// https://atcoder.jp/contests/abc451/tasks/abc451_a

let fn (s: string) =
    if String.length s % 5 = 0 then
        "Yes"
    else
        "No"

printfn "%s" (fn "legal")
//=> Yes

printfn "%s" (fn "atcoder")
//=> No

printfn "%s" (fn "illegal")
//=> No
