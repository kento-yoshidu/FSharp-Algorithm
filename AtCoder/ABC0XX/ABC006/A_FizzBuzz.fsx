// https://atcoder.jp/contests/abc006/tasks/abc006_1

let run n =
    if n % 3 = 0 || n.ToString().Contains("3") then
        "YES"
    else
        "NO"

printfn "%s" (run 2)
//=> NO

printfn "%s" (run 9)
//=> YES

printfn "%s" (run 3)
//=> YES

printf "%s" (run 13)
//=> YES
