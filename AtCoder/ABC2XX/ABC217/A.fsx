// https://atcoder.jp/contests/abc217/tasks/abc217_a

let fn s t =
    if s < t then
        "Yes"
    else
        "No"

printfn "%s" (fn "abc" "atcoder")
//=> Yes

printfn "%s" (fn "arc" "agc")
//=> No

printfn "%s" (fn "a" "aa")
//=> Yes
