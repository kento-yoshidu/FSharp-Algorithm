// https://atcoder.jp/contests/abc444/tasks/abc444_a

let fn n =
    let a = n / 100
    let b = n % 100 / 10
    let c = n % 10

    if a = b && b = c then
        "Yes"
    else
        "No"

printfn "%s" (fn 444)
//=> Yes

printfn "%s" (fn 160)
//=> No

printfn "%s" (fn 999)
//=> Yes
