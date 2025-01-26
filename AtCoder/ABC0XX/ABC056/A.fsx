// https://atcoder.jp/contests/abc056/tasks/abc056_a

let run a b =
    if a = "H" then
        b
    else
        if b = "H" then
            "D"
        else
            "H"

printfn "%s" (run "H" "H")
//=> H

printfn "%s" (run "D" "H")
//=> D

printfn "%s" (run "D" "D")
//=> H
