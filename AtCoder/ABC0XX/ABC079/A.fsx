// https://atcoder.jp/contests/abc079/tasks/abc079_a

let fn n =
    let n1 = n / 1000
    let n2 = n / 100 % 10
    let n3 = n / 10 % 10
    let n4 = n % 10

    if n1 = n2 && n2 = n3 || n2 = n3 && n3 = n4 then
        "Yes"
    else
        "No"

printfn "%s" (fn 1118)
//=> Yes

printfn "%s" (fn 7777)
//=> Yes

printfn "%s" (fn 1234)
//=> No

printfn "%s" (fn 8111)
//=> Yes
