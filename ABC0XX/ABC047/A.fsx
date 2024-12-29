// https://atcoder.jp/contests/abc047/tasks/abc047_a

let run a b c =
    if a + b = c || a + c = b || b + c = a then
        "Yes"
    else
        "No"

printfn "%s" (run 10 30 20)
//=> Yes

printfn "%s" (run 30 30 100)
//=> No

printfn "%s" (run 56 25 31)
//=> Yes
