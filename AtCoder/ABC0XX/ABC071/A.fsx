// https://atcoder.jp/contests/abc071/tasks/abc071_a

let run x a b =
    if abs(x-a) < abs(x-b) then
        "A"
    else
        "B"

printfn "%s" (run 5 2 7)
//=> B

printfn "%s" (run 1 999 1000)
//=> A
