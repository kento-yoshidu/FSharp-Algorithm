// https://atcoder.jp/contests/abc456/tasks/abc456_a

let fn x =
    if 3 <= x && x <= 18 then
        "Yes"
    else
        "No"

printfn "%s" (fn 15)
//=> Yes

printfn "%s" (fn 2)
//=> No
