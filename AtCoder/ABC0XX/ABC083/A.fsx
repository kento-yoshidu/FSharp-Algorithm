// https://atcoder.jp/contests/abc083/tasks/abc083_a

let fn a b c d =
    if a + b = c + d then
        "Balanced"
    elif a + b > c + d then
        "Left"
    else
        "Right"

printfn "%s" (fn 3 8 7 1)
//=> Left

printfn "%s" (fn 3 4 5 2)
//=> Balanced

printfn "%s" (fn 1 7 6 4)
//=> Right
