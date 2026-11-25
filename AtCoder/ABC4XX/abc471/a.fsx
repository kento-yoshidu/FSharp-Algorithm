// https://atcoder.jp/contests/abc471/tasks/abc471_a

let fn a b =
    if a + b = 9 then
        "Nine"
    elif a - b = 9 then
        "Nine"
    elif a * b = 9 then
        "Nine"
    elif float a / float b = 9.0 then
        "Nine"
    else
        "Nein"

printfn "%s" (fn 16 7)
//=> Nine

printfn "%s" (fn 66 7)
//=> Nein

printfn "%s" (fn 9 1)
//=> Nine

printfn "%s" (fn 9 9)
//=> Nein
