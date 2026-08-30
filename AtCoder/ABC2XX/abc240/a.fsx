// https://atcoder.jp/contests/abc240/tasks/abc240_a

let fn a b =
    let abs = abs (a - b)
    if abs = 1 || abs = 9 then
        "Yes"
    else
        "No"

printfn "%s" (fn 4 5)
//=> Yes

printfn "%s" (fn 3 5)
//=> No

printfn "%s" (fn 1 10)
//=> Yes
