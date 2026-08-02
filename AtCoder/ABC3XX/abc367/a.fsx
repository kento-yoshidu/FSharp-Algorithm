// https://atcoder.jp/contests/abc367/tasks/abc367_a

let fn a b c =
    if b < c then
        if b < a && a < c then
            "No"
        else
            "Yes"
    else
        if c < a && a < b then
            "Yes"
        else
            "No"

printfn "%s" (fn 21 8 14)
//=> Yes

printfn "%s" (fn 0 21 7)
//=> No

printfn "%s" (fn 10 7 17)
//=> No
