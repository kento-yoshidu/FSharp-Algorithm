// https://atcoder.jp/contests/abc058/tasks/abc058_a

let run a b c =
    if abs a - b = abs b - c then
        "YES"
    else
        "NO"

printfn "%s" (run 2 4 6)
//=> YES

printfn "%s" (run 2 5 6)
//=> NO

printfn "%s" (run 3 2 1)
//=> YES
