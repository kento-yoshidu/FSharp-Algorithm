// https://atcoder.jp/contests/abc150/tasks/abc150_a

let fn k x =
    if k * 500 >= x then
        "Yes"
    else
        "No"

printfn "%s" (fn 2 900)
//=> Yes

printfn "%s" (fn 1 501)
//=> No

printfn "%s" (fn 4 2000)
//=> Yes
