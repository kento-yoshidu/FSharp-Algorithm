// https://atcoder.jp/contests/abc038/tasks/abc038_a

let run (s: string) =
    if s.[s.Length - 1] = 'T' then
        "YES"
    else
        "NO"

printfn "%s" (run "ICEDT")
//=> YES

printfn "%s" (run "MUGICHA")
//=> NO

printfn "%s" (run "OOLONGT")
//=> YES

printfn "%s" (run "T")
//=> YES

printfn "%s" (run "TEA")
//=> NO
