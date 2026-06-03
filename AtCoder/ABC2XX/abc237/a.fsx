// https://atcoder.jp/contests/abc237/tasks/abc237_a

let fn (n: int64) =
    if pown -2L 31 <= n && n < pown 2L 31 then
        "Yes"
    else
        "No"

printfn "%s" (fn 10)
//=> Yes

printfn "%s" (fn -9876543210L)
//=> No

printfn "%s" (fn 483597848400000L)
//=> No
