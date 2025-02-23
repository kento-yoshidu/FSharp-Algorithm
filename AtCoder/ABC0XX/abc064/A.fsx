// https://atcoder.jp/contests/abc064/tasks/abc064_a

let run r g b =
    if (r*100 + g* 10 + b) % 4 = 0 then
        "YES"
    else
        "NO"

printfn "%s" (run 4 3 2)
//=> YES

printfn "%s" (run 2 3 4)
//=> NO
