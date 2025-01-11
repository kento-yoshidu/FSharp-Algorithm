// https://atcoder.jp/contests/abc042/tasks/abc042_a

let run a b c =
    match List.sort [a; b; c] with
    | [5; 5; 7] -> "YES"
    | _ -> "NO"

printfn "%s" (run 5 5 7)
//=> YES

printfn "%s" (run 7 7 5)
//=> NO
