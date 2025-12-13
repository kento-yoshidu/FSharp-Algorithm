// https://atcoder.jp/contests/abc411/tasks/abc411_a

let fn p l =
    if String.length p >= l then
        "Yes"
    else
        "No"

printfn "%s" (fn "chokudai" 5)
//=> Yes

printfn "%s" (fn "ac" 3)
//=> No

printfn "%s" (fn "atcoder" 7)
//=> Yes
