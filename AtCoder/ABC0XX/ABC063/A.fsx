// https://atcoder.jp/contests/abc063/tasks/abc063_a

let run a b =
    if a + b >= 10 then
        "error"
    else
        string (a + b)

printfn "%s" (run 6 3)
//=> 9

printfn "%s" (run 6 4)
//=> error
