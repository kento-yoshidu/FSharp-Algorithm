// https://atcoder.jp/contests/abc077/tasks/abc077_a

let run (s: string) (t: string) =
    if s.[0] = t.[2] && s.[1] = t.[1] && s.[2] = t.[0] then
        "Yes"
    else
        "No"

printfn "%s" (run "pot" "top")
//=> Yes

printfn "%s" (run "tab" "bet")
//=> No

printfn "%s" (run "eye" "eel")
//=> No
