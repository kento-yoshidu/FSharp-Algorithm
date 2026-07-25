// https://atcoder.jp/contests/abc228/tasks/abc228_a

let fn s t x =
    if s < t then
        if s <= x && x < t then
            "Yes"
        else
            "No"
    else
        if x < t || s <= x then
            "Yes"
        else
            "No"

printfn "%s" (fn 7 20 12)
//=> Yes

printfn "%s" (fn 20 7 12)
//=> No

printfn "%s" (fn 23 0 23)
//=> Yes
