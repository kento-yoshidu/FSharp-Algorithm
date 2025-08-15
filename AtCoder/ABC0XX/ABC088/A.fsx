// https://atcoder.jp/contests/abc088/tasks/abc088_a

let fn n a =
    let d = n % 500

    if a >= d then
        "YES"
    else
        "NO"

printfn "%s" (fn 2018 218)
//=> YES

printfn "%s" (fn 2763 0)
//=> NO

printfn "%s" (fn 37 514)
//=> YES
