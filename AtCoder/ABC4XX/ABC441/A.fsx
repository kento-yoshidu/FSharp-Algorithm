// https://atcoder.jp/contests/abc441/tasks/abc441_a

let fn p q x y =
    if x < p || y < q || p+99 < x || q+99 < y then
        "No"
    else
        "Yes"

printfn "%s" (fn 3 3 5 10)
//=> Yes

printfn "%s" (fn 5 5 10 1000)
//=> No

printfn "%s" (fn 1 2 1 1)
//=> No
