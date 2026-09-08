// https://atcoder.jp/contests/abc352/tasks/abc352_a

let fn n x y z =
    let min = min x y
    let max = max x y

    if min <= z && z <= max then
        "Yes"
    else
        "No"

printfn "%s" (fn 7 6 1 3)
//=> Yes

printfn "%s" (fn 10 3 2 9)
//=> No

printfn "%s" (fn 100 23 67 45)
//=> Yes
