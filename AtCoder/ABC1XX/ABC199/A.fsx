// https://atcoder.jp/contests/abc199/tasks/abc199_a

let fn a b c =
    if a*a + b*b < c*c then
        "Yes"
    else
        "No"

printfn "%s" (fn 2 2 4)
//=> Yes

printfn "%s" (fn 10 10 10)
//=> No

printfn "%s" (fn 3 4 5)
//=> No
